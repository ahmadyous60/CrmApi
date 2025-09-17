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
            var errors = ModelState.Values.SelectMany(v => v.Errors)
                .Select(e => e.ErrorMessage);
            return BadRequest(new { errors });
        }

        if (await _userManager.FindByNameAsync(dto.Username) != null)
            return BadRequest(new { message = "Username already exists" });

        if (await _userManager.FindByEmailAsync(dto.Email) != null)
            return BadRequest(new { message = "Email already exists" });

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

        // Default role = "user"
        await _userManager.AddToRoleAsync(user, "user");

        return Ok(new { user.Id, user.UserName, user.Email, user.Name });
    }
    //[HttpPost("signup")]
    //public async Task<IActionResult> Signup([FromBody] SignUpDto dto)
    //{
    //    if (!ModelState.IsValid)
    //    {
    //        var errors = ModelState.Values.SelectMany(v => v.Errors)
    //                                      .Select(e => e.ErrorMessage);
    //        return BadRequest(new { errors });
    //    }

    //    if (await _userManager.FindByNameAsync(dto.Username) != null)
    //        return BadRequest(new { message = "Username already exists" });

    //    if (await _userManager.FindByEmailAsync(dto.Email) != null)
    //        return BadRequest(new { message = "Email already exists" });

    //    var user = new ApplicationUser
    //    {
    //        UserName = dto.Username,
    //        Email = dto.Email,
    //        Name = dto.Name,   
    //        EmailConfirmed = true
    //    };

    //    var result = await _userManager.CreateAsync(user, dto.Password);
    //    if (!result.Succeeded)
    //        return BadRequest(result.Errors.Select(e => e.Description));

    //    return Ok(new { user.Id, user.UserName, user.Email, user.Name });
    //}


    // ✅ Login
    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginDto dto)
    {
        var user = await _userManager.FindByNameAsync(dto.Username);
        if (user == null)
            return NotFound(new { message = "User not found" });

        var result = await _signInManager.CheckPasswordSignInAsync(user, dto.Password, false);
        if (!result.Succeeded)
            return Unauthorized(new { message = "Wrong password entered" });

        try
        {
            // Generate JWT + refresh token + permissions
            var (accessToken, refreshToken, refreshExpiry, permissions) = await _jwtService.GenerateTokensAsync(user);

            // Save refresh token in DB
            _db.RefreshTokens.Add(new RefreshToken
            {
                UserId = user.Id,
                Token = refreshToken,
                Expires = refreshExpiry,
                IsRevoked = false
            });
            await _db.SaveChangesAsync();

            // Get roles
            var roles = await _userManager.GetRolesAsync(user);

            // Return user info, roles, and permissions
            return Ok(new
            {
                user = new
                {
                    user.Id,
                    user.UserName,
                    user.Email,
                    user.Name,
                    roles,
                    permissions
                },
                accessToken,
                refreshToken
            });
        }
        catch (DbUpdateException ex)
        {
            return StatusCode(500, new { message = ex.InnerException?.Message ?? ex.Message });
        }
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
    [HttpGet("all-users")]
    public IActionResult GetAllUsers()
    {
        var users = _userManager.Users.ToList();
        return Ok(users);
    }

    [Authorize(Roles = "user,admin,superadmin")]
    [HttpGet("profile")]
    public IActionResult GetProfile()
    {
        return Ok(new { message = "User profile data" });
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


}
