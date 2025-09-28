using Microsoft.AspNetCore.Identity;
using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Domain.Repositories
{
    public interface IAuthRepository
    {
        public Task<SignInResult> LoginAsync(User user, string password);
        public Task<IdentityResult> RegisterAsync(User user, string password);
    }
}
