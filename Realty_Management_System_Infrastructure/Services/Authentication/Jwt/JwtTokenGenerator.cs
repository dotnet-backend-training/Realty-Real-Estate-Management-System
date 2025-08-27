using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Realty_Management_System_Application.Interfaces;
using Realty_Management_System_Application.Shared.Services;
using Realty_Management_System_Domain.Entities;
using Realty_Management_System_Domain.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace Realty_Management_System_Infrastructure.Services.Authentication.Jwt
{
    public class JwtTokenGenerator : IJwtTokenGenerator
    {
        private readonly IDateTimeProvider _dateTimeProvider;
        private readonly IUserClaimsProvider _userClaimsProvider;
        private readonly JwtSettings _jwtSettings;

        public JwtTokenGenerator(
            IOptions<JwtSettings> jwtSettingsOptions,
            IDateTimeProvider dateTimeProvider,
            IUserClaimsProvider userClaimsProvider
        )
        {
            _dateTimeProvider = dateTimeProvider;
            _userClaimsProvider = userClaimsProvider;
            _jwtSettings = jwtSettingsOptions.Value;
        }
        public async Task<string> GenerateAccessTokenAsync(
            User user
        )
        {
            var authClaims = await _userClaimsProvider.GetClaimsAsync(user);
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
