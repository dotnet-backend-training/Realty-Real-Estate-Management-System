using Microsoft.AspNetCore.Identity;
using Realty_Management_System_Domain.Entities;
using Realty_Management_System_Domain.Repositories;

namespace Realty_Management_System_Infrastructure.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;

        public AuthRepository(
            SignInManager<User> signInManger,
            UserManager<User> userManager
        )
        {
            _signInManager = signInManger;
            _userManager = userManager;
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

        public async Task<IdentityResult> RegisterAsync(User user, string password)
        {
            IdentityResult registerResult = await _userManager.CreateAsync(user, password);
            return registerResult;
        }
    }
}
