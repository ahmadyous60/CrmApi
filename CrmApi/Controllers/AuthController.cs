using CrmApi.Data;
using CrmApi.DTOs;
using CrmApi.Models;
using CrmApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;


namespace CrmApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly IEmailSender _emailSender;
    private readonly CrmDbContext _db;
    private readonly JwtService _jwtService;

    public AuthController(
        UserManager<ApplicationUser> userManager,
        SignInManager<ApplicationUser> signInManager,
        IEmailSender emailSender,
        CrmDbContext db,
        JwtService jwtService)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _emailSender = emailSender;
        _db = db;
        _jwtService = jwtService;
    }

    // ✅ Signup
    [HttpPost("signup")]
    public async Task<IActionResult> Signup([FromBody] SignUpDto dto)
    {
        if (!ModelState.IsValid)
        {
            var errors = ModelState.Values
                .SelectMany(v => v.Errors)
                .Select(e => e.ErrorMessage);
            return BadRequest(new { errors });
        }

        // Check if username/email already exists
        if (await _userManager.FindByNameAsync(dto.Username) != null)
            return BadRequest(new { message = "Username already exists" });

        if (await _userManager.FindByEmailAsync(dto.Email) != null)
            return BadRequest(new { message = "Email already exists" });

        // Create user
        var user = new ApplicationUser
        {
            UserName = dto.Username,
            Email = dto.Email,
            Name = dto.Name,
            EmailConfirmed = true
        };

        var result = await _userManager.CreateAsync(user, dto.Password);
        if (!result.Succeeded)
            return BadRequest(result.Errors.Select(e => e.Description));

        // Assign default role = "user"
        await _userManager.AddToRoleAsync(user, "user");

        // Generate JWT + refresh token (permissions & roles inside token only)
        var (accessToken, refreshToken, refreshExpiry, _) = await _jwtService.GenerateTokensAsync(user);

        // Save refresh token
        _db.RefreshTokens.Add(new RefreshToken
        {
            UserId = user.Id,
            Token = refreshToken,
            Expires = refreshExpiry,
            IsRevoked = false
        });
        await _db.SaveChangesAsync();

        // Return only tokens
        return Ok(new
        {
            AccessToken = accessToken,
            RefreshToken = refreshToken
        });
    }


   

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginDto dto)
    {
        var user = await _userManager.FindByNameAsync(dto.Username);
        if (user == null)
            return NotFound(new { message = "User not found" });

        var result = await _signInManager.CheckPasswordSignInAsync(user, dto.Password, false);
        if (!result.Succeeded)
            return Unauthorized(new { message = "Wrong password entered" });

        var (accessToken, refreshToken, refreshExpiry, userPermissions) = await _jwtService.GenerateTokensAsync(user);

        _db.RefreshTokens.Add(new RefreshToken
        {
            UserId = user.Id,
            Token = refreshToken,
            Expires = refreshExpiry,
            IsRevoked = false
        });
        await _db.SaveChangesAsync();

        return Ok(new { accessToken, refreshToken });
    }



    // ✅ Forgot Password
    [HttpPost("forgot-password")]
    public async Task<IActionResult> ForgotPassword([FromBody] ForgotPasswordDto dto)
    {
        var user = await _userManager.FindByEmailAsync(dto.Email);
        if (user == null)
            return NotFound(new { message = "User not found" });

        var token = await _userManager.GeneratePasswordResetTokenAsync(user);
        var resetLink = $"http://localhost:4200/reset-password?email={dto.Email}&token={Uri.EscapeDataString(token)}";

        await _emailSender.SendEmailAsync(dto.Email, "Reset Password",
            $"Click here to reset your password: <a href='{resetLink}'>Reset</a>");

        return Ok(new { message = "Reset link sent to email" });
    }

    // ✅ Reset Password
    [HttpPost("reset-password")]
    public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordDto dto)
    {
        var user = await _userManager.FindByEmailAsync(dto.Email);
        if (user == null)
            return NotFound(new { message = "User not found" });

        var result = await _userManager.ResetPasswordAsync(user, dto.Token, dto.NewPassword);
        if (!result.Succeeded)
            return BadRequest(result.Errors.Select(e => e.Description));

        return Ok(new { message = "Password has been reset successfully" });
    }

    // ✅ Refresh token
    [HttpPost("refresh")]
    public async Task<IActionResult> Refresh([FromBody] TokenResponseDto dto)
    {
        var refresh = await _db.RefreshTokens
            .FirstOrDefaultAsync(r => r.Token == dto.RefreshToken && !r.IsRevoked);

        if (refresh == null || refresh.Expires < DateTime.UtcNow)
            return Unauthorized(new { message = "Invalid or expired refresh token" });

        var user = await _userManager.FindByIdAsync(refresh.UserId);
        if (user == null)
            return Unauthorized(new { message = "User not found" });

        try
        {
            // Revoke old token
            refresh.IsRevoked = true;

            // Generate new JWT + refresh token
            var (newAccess, newRefresh, newExpiry, permissions) = await _jwtService.GenerateTokensAsync(user);

            _db.RefreshTokens.Add(new RefreshToken
            {
                UserId = user.Id,
                Token = newRefresh,
                Expires = newExpiry,
                IsRevoked = false
            });

            await _db.SaveChangesAsync();

            return Ok(new { AccessToken = newAccess, RefreshToken = newRefresh });
        }
        catch (DbUpdateException ex)
        {
            return StatusCode(500, new { message = ex.InnerException?.Message ?? ex.Message });
        }
    }
    // ✅ Logout
    [HttpPost("logout")]
    public async Task<IActionResult> Logout([FromBody] TokenResponseDto dto)
    {
        var refresh = await _db.RefreshTokens
            .FirstOrDefaultAsync(r => r.Token == dto.RefreshToken && !r.IsRevoked);

        if (refresh == null)
            return NotFound(new { message = "Refresh token not found" });

        refresh.IsRevoked = true;
        await _db.SaveChangesAsync();

        return Ok(new { message = "Logged out successfully" });
    }

 


    [Authorize(Roles = "superadmin")]
    [HttpPost("assign-role")]
    public async Task<IActionResult> AssignRole([FromBody] AssignRoleDto dto)
    {
        try
        {
            var user = await _userManager.FindByIdAsync(dto.UserId.ToString());
            if (user == null) return NotFound(new { message = "User not found" });

            if (!await _userManager.IsInRoleAsync(user, dto.Role))
            {
                var result = await _userManager.AddToRoleAsync(user, dto.Role);
                if (!result.Succeeded)
                    return StatusCode(500, new { errors = result.Errors.Select(e => e.Description) });
            }

            return Ok(new { message = $"Role {dto.Role} assigned to {user.UserName}" });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { error = ex.Message, stackTrace = ex.StackTrace });
        }
    }

    [Authorize(Roles = "superadmin")]
    [HttpGet("users")]
    public async Task<IActionResult> GetAllUsers()
    {
        var users = await _userManager.Users
            .Select(u => new
            {
                u.Id,
                u.UserName,
                u.Email,
                u.Name,
                Roles = (from userRole in _db.UserRoles
                         join role in _db.Roles on userRole.RoleId equals role.Id
                         where userRole.UserId == u.Id
                         select role.Name).ToList()
            })
            .ToListAsync();

        return Ok(users);
    }

    [Authorize(Roles = "superadmin")]
    [HttpPut("users/{id}/roles")]
    public async Task<IActionResult> UpdateUserRoles(string id, [FromBody] List<string> roles)
    {
        var user = await _userManager.FindByIdAsync(id);
        if (user == null)
            return NotFound(new { message = "User not found" });

        // Get existing roles
        var currentRoles = await _userManager.GetRolesAsync(user);

        // Remove old roles
        var removeResult = await _userManager.RemoveFromRolesAsync(user, currentRoles);
        if (!removeResult.Succeeded)
            return BadRequest(new { errors = removeResult.Errors.Select(e => e.Description) });

        // Add new roles
        var addResult = await _userManager.AddToRolesAsync(user, roles);
        if (!addResult.Succeeded)
            return BadRequest(new { errors = addResult.Errors.Select(e => e.Description) });

        return Ok(new { message = "Roles updated successfully" });
    }

    [Authorize(Roles = "superadmin")]
    [HttpDelete("users/{id}")]
    public async Task<IActionResult> DeleteUser(string id)
    {
        var user = await _userManager.FindByIdAsync(id);
        if (user == null)
            return NotFound(new { message = "User not found" });

        var result = await _userManager.DeleteAsync(user);
        if (!result.Succeeded)
            return BadRequest(new { errors = result.Errors.Select(e => e.Description) });

        return Ok(new { message = "User deleted successfully" });
    }
        [Authorize(Roles = "superadmin")]
        [HttpGet("permissions")]
        public async Task<IActionResult> GetAllPermissions()
        {
            var permissions = await _db.Permissions.ToListAsync();
            return Ok(permissions);
        }
    [Authorize(Roles = "superadmin")]
    [HttpPost("roles/{roleName}/permissionsByName")]
    public async Task<IActionResult> AssignPermissionToRoleByName(string roleName, [FromBody] List<string> permissionIds)
    {
        var role = await _db.Roles.FirstOrDefaultAsync(r => r.Name == roleName);
        if (role == null) return NotFound("Role not found");

        foreach (var pid in permissionIds)
        {
            if (Guid.TryParse(pid, out var guid))
            {
                if (!_db.RoleAccesses.Any(ra => ra.RoleId == role.Id && ra.PermissionId == guid))
                {
                    _db.RoleAccesses.Add(new RoleAccess { RoleId = role.Id, PermissionId = guid });
                }
            }
        }

        await _db.SaveChangesAsync();
        return Ok(new { message = "Permissions assigned" });
    }


    [Authorize(Roles = "superadmin")]
    [HttpDelete("roles/{roleName}/permissions/{permissionId}")]
    public async Task<IActionResult> RevokePermission(string roleName, string permissionId)
    {
        var role = await _db.Roles.FirstOrDefaultAsync(r => r.Name == roleName);
        if (role == null)
            return NotFound(new { message = "Role not found" });

        if (!Guid.TryParse(permissionId, out var guid))
            return BadRequest(new { message = "Invalid permission id" });

        var access = await _db.RoleAccesses
            .FirstOrDefaultAsync(r => r.RoleId == role.Id && r.PermissionId == guid);

        if (access == null)
            return NotFound(new { message = "Permission not found for this role" });

        _db.RoleAccesses.Remove(access);
        await _db.SaveChangesAsync();

        return Ok(new { message = "Permission revoked successfully" });
    }




    [Authorize(Roles = "superadmin")]
        [HttpGet("users/{id}/permissions")]
        public async Task<IActionResult> GetUserPermissions(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
                return NotFound(new { message = "User not found" });

            // Get role names for the user
            var roleNames = await _userManager.GetRolesAsync(user);

            // Fetch role IDs by names
            var roleIds = await _db.Roles
                .Where(r => roleNames.Contains(r.Name))
                .Select(r => r.Id)
                .ToListAsync();

            // Fetch permissions linked to these role IDs
            var permissions = await _db.RoleAccesses
                .Where(ra => roleIds.Contains(ra.RoleId))
                .Join(_db.Permissions,
                      ra => ra.PermissionId,
                      p => p.Id,
                      (ra, p) => new { p.Id, p.Name }) // return id + name
                .Distinct()
                .ToListAsync();

            return Ok(permissions);
        }

    [Authorize(Roles = "superadmin")]
    [HttpGet("roles/{roleId}/permissions")]
    public async Task<IActionResult> GetRolePermissions(string roleId)
    {
        var permissions = await _db.RoleAccesses
            .Where(ra => ra.RoleId == roleId)
            .Join(_db.Permissions,
                  ra => ra.PermissionId,
                  p => p.Id,
                  (ra, p) => new { p.Id, p.Name })
            .ToListAsync();

        return Ok(permissions);
    }




}
