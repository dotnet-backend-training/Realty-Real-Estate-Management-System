using Microsoft.AspNetCore.Identity;
using Realty_Management_System_Application.Interfaces;
using Realty_Management_System_Domain.Entities;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Realty_Management_System_Infrastructure.Services.Authentication
{
    public class UserClaimsProvider : IUserClaimsProvider
    {
        private readonly UserManager<User> _userManager;

        public UserClaimsProvider(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IEnumerable<Claim>> GetClaimsAsync(User user)
        {
            ArgumentNullException.ThrowIfNull(user);

            var authClaims = new List<Claim> {
                new(type: JwtRegisteredClaimNames.Sub, value: user.UserName ?? string.Empty),
                new(type: ClaimTypes.NameIdentifier, value: user.Id.ToString()),
                new(type: ClaimTypes.GivenName, value: $"{user.FirstName} {user.LastName}")
            };
            var userRoles = await _userManager.GetRolesAsync(user);
            authClaims.AddRange(
                userRoles.Select(
                    role => new Claim(type: ClaimTypes.Role, value: role)
                )
            );
            return authClaims;
        }
    }
}
