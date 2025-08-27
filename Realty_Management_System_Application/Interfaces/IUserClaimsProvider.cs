using Realty_Management_System_Domain.Entities;
using System.Security.Claims;

namespace Realty_Management_System_Application.Interfaces
{
    public interface IUserClaimsProvider
    {
        Task<IEnumerable<Claim>> GetClaimsAsync(User user);
    }
}
