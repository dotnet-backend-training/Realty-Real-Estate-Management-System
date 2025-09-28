using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Realty_Management_System_Domain.Entities;
using Realty_Management_System_Domain.Interfaces;

namespace Realty_Management_System_Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<User> _userManager;

        public UserRepository(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<bool> ExistsByEmailAsync(string email)
        {
            return await _userManager.Users.AnyAsync(user => user.Email == email);
        }

        public async Task<bool> ExistsByUsernameAsync(string username)
        {
            return await _userManager.Users.AnyAsync(user => user.UserName == username);
        }

        public async Task<User?> FindByEmailAsync(string email)
        {
            return await _userManager.FindByEmailAsync(email);
        }

        public async Task<User?> FindByUsernameAsync(string username)
        {
            return await _userManager.FindByNameAsync(username);
        }
    }
}
