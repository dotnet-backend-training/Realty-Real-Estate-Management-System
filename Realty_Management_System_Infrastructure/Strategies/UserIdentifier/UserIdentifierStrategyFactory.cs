using Realty_Management_System_Application.Interfaces;
using Realty_Management_System_Domain.Enums;

namespace Realty_Management_System_Infrastructure.Strategies.UserIdentifier
{
    public class UserIdentifierStrategyFactory : IUserIdentifierStrategyFactory
    {
        private readonly UsernameIdentifierStrategy _usernameIdentifierStrategy;
        private readonly EmailIdentifierStrategy _emailIdentifierStrategy;

        public UserIdentifierStrategyFactory(
            UsernameIdentifierStrategy usernameIdentifierStrategy,
            EmailIdentifierStrategy emailIdentifierStrategy
        )
        {
            _usernameIdentifierStrategy = usernameIdentifierStrategy;
            _emailIdentifierStrategy = emailIdentifierStrategy;
        }

        public IUserIdentifierStrategy GetStrategy(UserIdentifierType userIdentifierType)
        {
            return userIdentifierType switch
            {
                UserIdentifierType.Email => _emailIdentifierStrategy,
                UserIdentifierType.Username => _usernameIdentifierStrategy,
                _ => throw new NotSupportedException($"No strategy defined for {userIdentifierType}")
            };
        }
    }
}
