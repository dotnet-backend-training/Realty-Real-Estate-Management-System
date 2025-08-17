using Microsoft.AspNetCore.Identity;
using Realty_Management_System_Application.Interfaces;
using Realty_Management_System_Domain.Entities;
using Realty_Management_System_Domain.Enums;
using Realty_Management_System_Domain.Repositories;
using Realty_Management_System_Infrastructure.Data.Contexts;

namespace Realty_Management_System_Infrastructure.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly IUserIdentifierStrategyFactory _userIdentifierStrategyFactory;
        private readonly SignInManager<User> _signInManager;

        public AuthRepository(
            ApplicationDbContext applicationDbContext,
            IUserIdentifierStrategyFactory userIdentifierStrategyFactory,
            SignInManager<User> signInManger
        )
        {
            _applicationDbContext = applicationDbContext;
            _userIdentifierStrategyFactory = userIdentifierStrategyFactory;
            _signInManager = signInManger;
        }

        // TOOD: move it later to a separate unit.
        public async Task<User?> FindUserAsync(string identifier, UserIdentifierType identifierType)
        {
            var strategy = _userIdentifierStrategyFactory.GetStrategy(identifierType);
            return await strategy.FindUserAsync(identifier);
        }

        public async Task<SignInResult> LoginAsync(
            User user,
            string password
        )
        {
            SignInResult signInResult = await _signInManager.PasswordSignInAsync(
                user,
                password,
                isPersistent: false,
                lockoutOnFailure: false
            );
            return signInResult;
        }
    }
}
