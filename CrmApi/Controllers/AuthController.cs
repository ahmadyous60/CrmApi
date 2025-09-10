using CrmApi.DTOs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CrmApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly IEmailSender _emailSender;

    public AuthController(
        UserManager<IdentityUser> userManager,
        SignInManager<IdentityUser> signInManager,
        IEmailSender emailSender)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _emailSender = emailSender;
    }

    // ✅ Signup
    [HttpPost("signup")]
    public async Task<IActionResult> Signup([FromBody] SignUpDto dto)
    {
        var user = new IdentityUser
        {
            UserName = dto.Username,
            Email = dto.Email,
            EmailConfirmed = true // skip confirmation in dev
        };

        var result = await _userManager.CreateAsync(user, dto.Password);

        if (!result.Succeeded)
            return BadRequest(result.Errors);

        return Ok(new { user.Id, user.UserName, user.Email });
    }

    // ✅ Login
    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginDto dto)
    {
        var user = await _userManager.FindByNameAsync(dto.Username);
        if (user == null)
            return NotFound(new { message = "User not found" });

        var result = await _signInManager.PasswordSignInAsync(user, dto.Password, false, false);

        if (!result.Succeeded)
            return Unauthorized(new { message = "Wrong password entered" });

        return Ok(new { user.Id, user.UserName });
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
            return BadRequest(result.Errors);

        return Ok(new { message = "Password has been reset successfully" });
    }
}
