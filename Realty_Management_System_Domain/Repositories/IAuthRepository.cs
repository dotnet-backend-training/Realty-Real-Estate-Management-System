using Microsoft.AspNetCore.Identity;
using Realty_Management_System_Domain.Entities;
using Realty_Management_System_Domain.Enums;

namespace Realty_Management_System_Domain.Repositories
{
    public interface IAuthRepository
    {
        public Task<User?> FindUserAsync(string identifier, UserIdentifierType identifierType);
        public Task<SignInResult> LoginAsync(User user, string password);
    }
}
