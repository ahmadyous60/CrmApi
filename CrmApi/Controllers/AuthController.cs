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
    private readonly IConfiguration _config;

    public AuthController(
        UserManager<ApplicationUser> userManager,
        SignInManager<ApplicationUser> signInManager,
        IEmailSender emailSender,
        CrmDbContext db,
        JwtService jwtService,
        IConfiguration config)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _emailSender = emailSender;
        _db = db;
        _jwtService = jwtService;
        _config = config;
    }

    //SignUp
    //[HttpPost("signup")]
    //public async Task<IActionResult> Signup([FromBody] SignUpDto dto)
    //{
    //    if (!ModelState.IsValid)
    //    {
    //        var errors = ModelState.Values
    //            .SelectMany(v => v.Errors)
    //            .Select(e => e.ErrorMessage)
    //            .ToList();
    //        return BadRequest(new { errors });
    //    }

    //    // Check if username/email already exists
    //    if (await _userManager.FindByNameAsync(dto.Username) != null)
    //        return BadRequest(new { errors = new[] { "Username already exists" } });

    //    if (await _userManager.FindByEmailAsync(dto.Email) != null)
    //        return BadRequest(new { errors = new[] { "Email already exists" } });

    //    // Create user
    //    var user = new ApplicationUser
    //    {
    //        UserName = dto.Username,
    //        Email = dto.Email,
    //        Name = dto.Name,
    //        EmailConfirmed = false
    //    };

    //    var result = await _userManager.CreateAsync(user, dto.Password);
    //    if (!result.Succeeded)
    //    {
    //        var errors = result.Errors.Select(e => e.Description).ToList();
    //        return BadRequest(new { errors });
    //    }

    //    // Assign default role = "user"
    //    await _userManager.AddToRoleAsync(user, "user");

    //    // Generate JWT + refresh token
    //    var (accessToken, refreshToken, refreshExpiry, _) = await _jwtService.GenerateTokensAsync(user);

    //    _db.RefreshTokens.Add(new RefreshToken
    //    {
    //        UserId = user.Id,
    //        Token = refreshToken,
    //        Expires = refreshExpiry,
    //        IsRevoked = false
    //    });
    //    await _db.SaveChangesAsync();

    //    return Ok(new
    //    {
    //        AccessToken = accessToken,
    //        RefreshToken = refreshToken
    //    });
    //}


    [HttpPost("signup")]
    public async Task<IActionResult> Signup([FromBody] SignUpDto dto)
    {
        if (!ModelState.IsValid)
        {
            var errors = ModelState.Values
                .SelectMany(v => v.Errors)
                .Select(e => e.ErrorMessage)
                .ToList();
            return BadRequest(new { errors });
        }

        // Check if username/email already exists
        if (await _userManager.FindByNameAsync(dto.Username) != null)
            return BadRequest(new { errors = new[] { "Username already exists" } });

        if (await _userManager.FindByEmailAsync(dto.Email) != null)
            return BadRequest(new { errors = new[] { "Email already exists" } });

        // Create user
        var user = new ApplicationUser
        {
            UserName = dto.Username,
            Email = dto.Email,
            Name = dto.Name,
            EmailConfirmed = false
        };

        var result = await _userManager.CreateAsync(user, dto.Password);
        if (!result.Succeeded)
        {
            var errors = result.Errors.Select(e => e.Description).ToList();
            return BadRequest(new { errors });
        }

        // Assign default role = "user"
        await _userManager.AddToRoleAsync(user, "user");

        // ✅ Generate email confirmation token
        var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
        var confirmationLink = $"{_config["App:FrontendUrl"]}/password-renewal?userId={user.Id}&token={Uri.EscapeDataString(token)}";

        // ✅ Send confirmation email
        await _emailSender.SendEmailAsync(
            user.Email,
            "Confirm your email",
            $"Please confirm your email by clicking <a href='{confirmationLink}'>here</a>."
        );

        // ❌ No tokens here
        return Ok(new { message = "Signup successful. Please check your email to confirm before continuing." });
    }

    [HttpPost("confirm-email")]
    public async Task<IActionResult> ConfirmEmail([FromBody] ConfirmEmailDto dto)
    {
        var user = await _userManager.FindByIdAsync(dto.UserId);
        if (user == null) return BadRequest(new { error = "User not found" });

        var result = await _userManager.ConfirmEmailAsync(user, dto.Token);
        if (!result.Succeeded)
            return BadRequest(new { errors = result.Errors.Select(e => e.Description) });

        return Ok(new { message = "Email confirmed successfully" });
    }
    [HttpPost("change-password")]
    public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordDto dto)
    {
        var user = await _userManager.FindByIdAsync(dto.UserId);
        if (user == null) return BadRequest(new { error = "User not found" });

        // Make sure email is confirmed
        if (!user.EmailConfirmed)
            return BadRequest(new { error = "Email not confirmed" });

        var result = await _userManager.ChangePasswordAsync(user, dto.OldPassword, dto.NewPassword);
        if (!result.Succeeded)
            return BadRequest(new { errors = result.Errors.Select(e => e.Description) });

        // ✅ Now generate JWT + refresh token
        var (accessToken, refreshToken, refreshExpiry, _) = await _jwtService.GenerateTokensAsync(user);

        _db.RefreshTokens.Add(new RefreshToken
        {
            UserId = user.Id,
            Token = refreshToken,
            Expires = refreshExpiry,
            IsRevoked = false
        });
        await _db.SaveChangesAsync();

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
    [HttpGet("roles/{roleName}/permissionsByName")]
    public async Task<IActionResult> GetRolePermissionsByName(string roleName)
    {
        var role = await _db.Roles.FirstOrDefaultAsync(r => r.Name == roleName);
        if (role == null) return NotFound("Role not found");

        var permissions = await _db.RoleAccesses
            .Where(rp => rp.RoleId == role.Id)
            .Select(rp => new { rp.Permission.Id, rp.Permission.Name })
            .ToListAsync();

        return Ok(permissions);
    }
    [Authorize(Roles = "superadmin")]
    [HttpDelete("roles/{roleName}/permissions/{permissionId}")]
    public async Task<IActionResult> RevokePermissionFromRole(string roleName, string permissionId)
    {
        var role = await _db.Roles.FirstOrDefaultAsync(r => r.Name == roleName);
        if (role == null) return NotFound("Role not found");

        // Convert string → Guid
        if (!Guid.TryParse(permissionId, out var permissionGuid))
        {
            return BadRequest("Invalid permission ID format.");
        }

        var access = await _db.RoleAccesses
            .FirstOrDefaultAsync(rp => rp.RoleId == role.Id && rp.PermissionId == permissionGuid);

        if (access == null) return NotFound("Permission not assigned to role");

        _db.RoleAccesses.Remove(access);
        await _db.SaveChangesAsync();

        return Ok(new { message = "Permission revoked" });
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

    [Authorize(Roles = "superadmin")]
    [HttpGet("roles")]
    public async Task<IActionResult> GetAllRoles()
    {
        var roles = await _db.Roles
            .Select(r => new { r.Id, r.Name })
            .ToListAsync();

        return Ok(roles);
    }
    [Authorize(Roles = "superadmin")]
    [HttpPost("roles/{roleName}/permissionsByName")]
    public async Task<IActionResult> AssignPermissionToRoleByName(string roleName, [FromBody] List<string> permissionIds)
    {
        var role = await _db.Roles.FirstOrDefaultAsync(r => r.Name == roleName);
        if (role == null) return NotFound("Role not found");

        foreach (var pid in permissionIds)
        {
            if (!Guid.TryParse(pid, out var permissionGuid))
            {
                return BadRequest($"Invalid permission ID: {pid}");
            }

            var exists = await _db.RoleAccesses
                .AnyAsync(rp => rp.RoleId == role.Id && rp.PermissionId == permissionGuid);

            if (!exists)
            {
                _db.RoleAccesses.Add(new RoleAccess
                {
                    RoleId = role.Id,
                    PermissionId = permissionGuid
                });
            }
        }

        await _db.SaveChangesAsync();
        return Ok(new { message = "Permissions assigned" });
    }




}
