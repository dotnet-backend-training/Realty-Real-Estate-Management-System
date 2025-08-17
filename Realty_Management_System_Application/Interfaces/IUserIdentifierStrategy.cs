using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Application.Interfaces
{
    public interface IUserIdentifierStrategy
    {
        Task<User?> FindUserAsync(string identifier);
    }
}
