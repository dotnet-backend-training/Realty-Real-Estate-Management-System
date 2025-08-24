using Realty_Management_System_Application.Interfaces;
using Realty_Management_System_Domain.Entities;
using Realty_Management_System_Domain.Enums;
using Realty_Management_System_Domain.Interfaces;

namespace Realty_Management_System_Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IUserIdentifierStrategyFactory _userIdentifierStrategyFactory;

        public UserRepository(IUserIdentifierStrategyFactory userIdentifierStrategyFactory)
        {
            _userIdentifierStrategyFactory = userIdentifierStrategyFactory;
        }
        public async Task<User?> FindUserAsync(string identifier, UserIdentifierType identifierType)
        {
            var strategy = _userIdentifierStrategyFactory.GetStrategy(identifierType);
            return await strategy.FindUserAsync(identifier);
        }
    }
}
