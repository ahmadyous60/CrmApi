using CrmApi.Data;
using CrmApi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
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

        public async Task<(string accessToken, string refreshToken, DateTime refreshExpiry, List<string> userPermissions)>
            GenerateTokensAsync(ApplicationUser user)
        {
            // Get user roles
            var roles = await _userManager.GetRolesAsync(user);

            // Determine permissions
            var userPermissions = await _db.RoleAccesses
               .Include(ra => ra.Permission)
               .Include(ra => ra.Role)
               .Where(ra => roles.Contains(ra.Role.Name))
               .Select(ra => ra.Permission.Name)
               .Distinct()
               .ToListAsync();

            // Build JWT claims
            var authClaims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id),
                new Claim(ClaimTypes.Name, user.UserName ?? string.Empty),
                new Claim("FullName", user.Name ?? string.Empty),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            
            if (!string.IsNullOrEmpty(user.Email))
            {
                authClaims.Add(new Claim(ClaimTypes.Email, user.Email));
            }

            // Add role claims
            authClaims.AddRange(roles.Select(r => new Claim(ClaimTypes.Role, r)));

            // Add permission claims
            authClaims.AddRange(userPermissions.Select(p => new Claim("Permission", p)));

            // Signing credentials
            var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_settings.Key));

            var token = new JwtSecurityToken(
                issuer: _settings.Issuer,
                audience: _settings.Audience,
                expires: DateTime.UtcNow.AddMinutes(_settings.AccessTokenExpiryMinutes),
                claims: authClaims,
                signingCredentials: new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256)
            );

            var accessToken = new JwtSecurityTokenHandler().WriteToken(token);

            // Generate refresh token
            var refreshToken = GenerateSecureRefreshToken();
            var refreshExpiry = DateTime.UtcNow.AddDays(_settings.RefreshTokenExpiryDays);

            return (accessToken, refreshToken, refreshExpiry, userPermissions);
        }

        private string GenerateSecureRefreshToken()
        {
            var randomNumber = new byte[64];
            using var rng = RandomNumberGenerator.Create();
            rng.GetBytes(randomNumber);
            return Convert.ToBase64String(randomNumber);
        }
    }
}
