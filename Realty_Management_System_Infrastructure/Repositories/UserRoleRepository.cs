using Microsoft.AspNetCore.Identity;
using Realty_Management_System_Domain.Entities;
using Realty_Management_System_Domain.Interfaces;

namespace Realty_Management_System_Infrastructure.Repositories
{
    public class UserRoleRepository : IUserRoleRepository
    {
        private readonly UserManager<User> _userManager;

        public UserRoleRepository(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IdentityResult> AddToRoleAsync(User user, string roleName)
        {
            return await _userManager.AddToRoleAsync(user, roleName);
        }

        public async Task<IdentityResult> AddToRolesAsync(User user, IEnumerable<string> roleNames)
        {
            ArgumentNullException.ThrowIfNull(user, nameof(user));
            ArgumentNullException.ThrowIfNull(roleNames, nameof(roleNames));
            return await _userManager.AddToRolesAsync(user, roleNames);
        }

        public async Task<IEnumerable<string>> GetUserRolesAsync(User user)
        {
            ArgumentNullException.ThrowIfNull(user, nameof(user));
            return await _userManager.GetRolesAsync(user);
        }
    }
}
