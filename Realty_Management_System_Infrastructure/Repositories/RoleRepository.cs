using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Realty_Management_System_Domain.Interfaces;

namespace Realty_Management_System_Infrastructure.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly RoleManager<IdentityRole<Guid>> _roleManager;

        public RoleRepository(
            RoleManager<IdentityRole<Guid>> roleManager
        )
        {
            _roleManager = roleManager;
        }

        public async Task<bool> ExistsByIdAsync(Guid roleId)
        {
            return await _roleManager.Roles.AnyAsync(role => role.Id == roleId);
        }

        public async Task<IdentityRole<Guid>?> GetRoleByIdAsync(Guid roleId)
        {
            return await _roleManager.FindByIdAsync(roleId.ToString());
        }

        public async Task<IEnumerable<IdentityRole<Guid>?>> GetRolesByIdsAsync(IEnumerable<Guid> roleIds)
        {
            if (roleIds == null || !roleIds.Any())
            {
                return [];
            }
            return await _roleManager.Roles
                .Where(r => roleIds.Contains(r.Id))
                .ToListAsync();
        }
    }
}
