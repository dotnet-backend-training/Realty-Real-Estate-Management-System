using Realty_Management_System_Application.Interfaces;
using Realty_Management_System_Domain.Enums;

namespace Realty_Management_System_Infrastructure.Strategies.UserIdentifier
{
    public class UserIdentifierStrategyFactory : IUserIdentifierStrategyFactory
    {
        private readonly IEnumerable<IUserIdentifierStrategy> _userIdentifierStrategies;

        public UserIdentifierStrategyFactory(
            IEnumerable<IUserIdentifierStrategy> userIdentifierStrategies
        )
        {
            _userIdentifierStrategies = userIdentifierStrategies;
        }
        public IUserIdentifierStrategy GetStrategy(UserIdentifierType userIdentifierType)
        {
            var strategy = _userIdentifierStrategies.FirstOrDefault(
                userIdentifierStrategy => userIdentifierStrategy.Type == userIdentifierType
            );
            return strategy is null ?
                throw new NotSupportedException($"No strategy defined for {userIdentifierType}")
                : strategy;
        }
    }
}
