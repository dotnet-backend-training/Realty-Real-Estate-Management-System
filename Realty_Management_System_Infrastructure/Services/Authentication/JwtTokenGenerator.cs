using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Realty_Management_System_Application.Shared.Services;
using Realty_Management_System_Domain.Entities;
using Realty_Management_System_Domain.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Realty_Management_System_Infrastructure.Services.Authentication
{
    public class JwtTokenGenerator : IJwtTokenGenerator
    {
        private readonly UserManager<User> _userManager;
        private readonly IDateTimeProvider _dateTimeProvider;
        private readonly JwtSettings _jwtSettings;

        public JwtTokenGenerator(
            UserManager<User> userManager,
            IOptions<JwtSettings> jwtSettingsOptions,
            IDateTimeProvider dateTimeProvider
        )
        {
            _userManager = userManager;
            _dateTimeProvider = dateTimeProvider;
            _jwtSettings = jwtSettingsOptions.Value;
        }
        public async Task<string> GenerateAccessTokenAsync(
            User user
        )
        {
            var authClaims = new List<Claim> {
                new(type: JwtRegisteredClaimNames.Sub, value: user.UserName ?? string.Empty),
                new(type: ClaimTypes.NameIdentifier, value: user.Id.ToString()),
                new(type: ClaimTypes.GivenName, value: $"{user.FirstName} {user.LastName}")
            };
            var userRoles = await _userManager.GetRolesAsync(user);
            foreach (var role in userRoles)
            {
                authClaims.Add(new Claim(type: ClaimTypes.Role, value: role));
            }
            var secretKeyBytes = Encoding.UTF8.GetBytes(_jwtSettings.SecretKey);
            var authSymmetricSecurityKey = new SymmetricSecurityKey(
                key: secretKeyBytes
            );
            var token = new JwtSecurityToken(
                claims: authClaims,
                signingCredentials: new SigningCredentials(
                    key: authSymmetricSecurityKey,
                    algorithm: SecurityAlgorithms.HmacSha256Signature
                ),
                issuer: _jwtSettings.Issuer,
                audience: _jwtSettings.Audience,
                expires: _dateTimeProvider.UtcNow.AddMinutes(_jwtSettings.ExpiryMinutes)
            );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
