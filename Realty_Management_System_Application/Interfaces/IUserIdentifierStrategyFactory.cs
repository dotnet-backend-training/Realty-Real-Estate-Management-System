using Realty_Management_System_Domain.Enums;

namespace Realty_Management_System_Application.Interfaces
{
    public interface IUserIdentifierStrategyFactory
    {
        public IUserIdentifierStrategy GetStrategy(UserIdentifierType userIdentifierType);
    }
}
