using Realty_Management_System_Domain.Entities;
using Realty_Management_System_Domain.Enums;

namespace Realty_Management_System_Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> FindUserAsync(string identifier, UserIdentifierType identifierType);
    }
}
