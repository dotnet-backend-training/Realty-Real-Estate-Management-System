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
        public async Task<IEnumerable<string>> GetUserRolesAsync(User user)
        {
            ArgumentNullException.ThrowIfNull(user, nameof(user));
            return await _userManager.GetRolesAsync(user);
        }
    }
}
