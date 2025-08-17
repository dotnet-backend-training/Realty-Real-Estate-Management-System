using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Domain.Repositories
{
    public interface IAuthRepository
    {
        public Task<User?> FindUserByEmailAsync(string email);
        public Task<User?> FindUserByUsernameAsync(string username);
        public Task<User?> LoginAsync(User user, string password);
    }
}
