using Microsoft.AspNetCore.Identity;

namespace Realty_Management_System_Domain.Interfaces
{
    public interface IRoleRepository
    {
        Task<IdentityRole<Guid>?> GetRoleByIdAsync(Guid roleId);
        Task<IEnumerable<IdentityRole<Guid>?>> GetRolesByIdsAsync(IEnumerable<Guid> roleIds);
        Task<bool> ExistsByIdAsync(Guid roleId);
    }
}
