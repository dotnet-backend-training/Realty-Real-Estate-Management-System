using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Realty_Management_System_Application.Services
{
    public class TokenService //: ITokenService
    {
        public string GenerateAccessToken(
            Guid userId,
            string userName,
            string firstName,
            string lastName
        )
        {
            var claims = new[]
            {
                new Claim(type: JwtRegisteredClaimNames.Sub, value: userName),
                new Claim(type: ClaimTypes.NameIdentifier, value: userId.ToString()),
                new Claim(type: ClaimTypes.GivenName, value: userName),
                new Claim(type: ClaimTypes.Name, value: $"{firstName}{lastName}"),
            };
            var securityToken = new JwtSecurityToken();
            return string.Empty;
        }
    }
}
