using Microsoft.AspNetCore.Identity;
using Realty_Management_System_Domain.Entities;
using Realty_Management_System_Domain.Repositories;
using Realty_Management_System_Infrastructure.Data.Contexts;

namespace Realty_Management_System_Infrastructure.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManger;

        public AuthRepository(
            ApplicationDbContext applicationDbContext,
            UserManager<User> userManager,
            SignInManager<User> signInManger
        )
        {
            _applicationDbContext = applicationDbContext;
            _userManager = userManager;
            _signInManger = signInManger;
        }

        public async Task<User?> FindUserByEmailAsync(string email)
        {
            return await _userManager.FindByEmailAsync(email);
        }

        public async Task<User?> FindUserByUsernameAsync(string username)
        {
            return await _userManager.FindByNameAsync(username);
        }

        public async Task<User?> LoginAsync(
            User user,
            string password
        )
        {
            var signInResult = await _signInManger.PasswordSignInAsync(
                user,
                password,
                isPersistent: false,
                lockoutOnFailure: false
            );
            return signInResult.Succeeded ? user : null;
        }
    }
}
