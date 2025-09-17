using CrmApi.Data;
using CrmApi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CrmApi.Services
{
    public class JwtService
    {
        private readonly JwtSettings _settings;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly CrmDbContext _db;

        public JwtService(IOptions<JwtSettings> settings, UserManager<ApplicationUser> userManager, CrmDbContext db)
        {
            _settings = settings.Value;
            _userManager = userManager;
            _db = db;
        }

        public async Task<(string accessToken, string refreshToken, DateTime refreshExpiry, List<string> permissions)> GenerateTokensAsync(ApplicationUser user)
        {
            var roles = await _userManager.GetRolesAsync(user);

            // Determine permissions
            List<string> permissions;
            if (roles.Contains("superadmin"))
            {
                permissions = await _db.Permissions
                    .Select(p => p.Name)
                    .ToListAsync();
            }
            else
            {
                permissions = await _db.RolePermissions
                    .Include(rp => rp.Role)
                    .Include(rp => rp.Permission)
                    .Where(rp => roles.Contains(rp.Role.Name))
                    .Select(rp => rp.Permission.Name)
                    .Distinct()
                    .ToListAsync();
            }

            // Build claims
            var authClaims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id),
                new Claim(ClaimTypes.Name, user.UserName ?? ""),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            authClaims.AddRange(roles.Select(r => new Claim(ClaimTypes.Role, r)));
            authClaims.AddRange(permissions.Select(p => new Claim("Permission", p)));

            var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_settings.Key));

            var token = new JwtSecurityToken(
                issuer: _settings.Issuer,
                audience: _settings.Audience,
                expires: DateTime.UtcNow.AddMinutes(_settings.AccessTokenExpiryMinutes),
                claims: authClaims,
                signingCredentials: new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256)
            );

            var accessToken = new JwtSecurityTokenHandler().WriteToken(token);
            var refreshToken = Convert.ToBase64String(Guid.NewGuid().ToByteArray());
            var refreshExpiry = DateTime.UtcNow.AddDays(_settings.RefreshTokenExpiryDays);

            return (accessToken, refreshToken, refreshExpiry, permissions);
        }
    }
}
