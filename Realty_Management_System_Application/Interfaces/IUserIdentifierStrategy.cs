using Realty_Management_System_Domain.Entities;
using Realty_Management_System_Domain.Enums;

namespace Realty_Management_System_Application.Interfaces
{
    public interface IUserIdentifierStrategy
    {
        UserIdentifierType Type { get; }
        Task<User?> FindUserAsync(string identifier);
    }
}
