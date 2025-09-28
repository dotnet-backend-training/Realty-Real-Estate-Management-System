using Realty_Management_System_Application.Interfaces;
using Realty_Management_System_Domain.Entities;
using Realty_Management_System_Domain.Enums;
using Realty_Management_System_Domain.Interfaces;

namespace Realty_Management_System_Infrastructure.Strategies.UserIdentifier
{
    public class UsernameIdentifierStrategy : IUserIdentifierStrategy
    {
        private readonly IUserRepository _userRepository;
        public UserIdentifierType Type => UserIdentifierType.Username;

        public UsernameIdentifierStrategy(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<User?> FindUserAsync(string identifier)
        {
            return await _userRepository.FindByUsernameAsync(identifier);
        }
    }
}
