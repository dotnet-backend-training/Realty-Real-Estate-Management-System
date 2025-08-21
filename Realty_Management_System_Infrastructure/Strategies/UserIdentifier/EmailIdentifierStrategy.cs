using Microsoft.AspNetCore.Identity;
using Realty_Management_System_Application.Interfaces;
using Realty_Management_System_Domain.Entities;
using Realty_Management_System_Domain.Enums;

namespace Realty_Management_System_Infrastructure.Strategies.UserIdentifier
{
    public class EmailIdentifierStrategy : IUserIdentifierStrategy
    {
        private readonly UserManager<User> _userManager;
        public UserIdentifierType Type => UserIdentifierType.Email;
        public EmailIdentifierStrategy(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        public async Task<User?> FindUserAsync(string identifier)
        {
            return await _userManager.FindByEmailAsync(identifier);
        }
    }
}
