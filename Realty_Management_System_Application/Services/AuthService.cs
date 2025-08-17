using Realty_Management_System_Application.Helpers;
using Realty_Management_System_Application.Interfaces;
using Realty_Management_System_Domain.Repositories;

namespace Realty_Management_System_Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _authRepository;
        private readonly IUserIdentifierStrategyFactory _userIdentifierStrategyFactory;

        public AuthService(
        IAuthRepository authRepository,
        IUserIdentifierStrategyFactory userIdentifierStrategyFactory
        )
        {
            _authRepository = authRepository;
            _userIdentifierStrategyFactory = userIdentifierStrategyFactory;
        }
        public async Task LoginAsync(string identifier, string password)
        {
            var userIdentifierType = UserIdentifierHelper.DetectIdentifierType(identifier);
            var userIdentifierStrategy = _userIdentifierStrategyFactory.GetStrategy(userIdentifierType);
            var loginResult = await userIdentifierStrategy.FindUserAsync(identifier);
            if (loginResult == null) { }
        }
    }
}
