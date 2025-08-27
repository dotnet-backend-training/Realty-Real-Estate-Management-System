using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Domain.Interfaces
{
    public interface IUserRoleRepository
    {
        Task<IEnumerable<string>> GetUserRolesAsync(User user);
    }
}
