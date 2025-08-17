using Microsoft.AspNetCore.Identity;
using Realty_Management_System_Application.Interfaces;
using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Infrastructure.Strategies.UserIdentifier
{
    public class UsernameIdentifierStrategy : IUserIdentifierStrategy
    {
        private readonly UserManager<User> _userManager;

        public UsernameIdentifierStrategy(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        public async Task<User?> FindUserAsync(string identifier)
        {
            return await _userManager.FindByNameAsync(identifier);
        }
    }
}
