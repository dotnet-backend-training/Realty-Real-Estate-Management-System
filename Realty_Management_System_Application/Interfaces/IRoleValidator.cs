using Realty_Management_System_Application.Shared.Result;

namespace Realty_Management_System_Application.Interfaces
{
    public interface IRoleValidator
    {
        Task<Result> ValidateRoleAsync(Guid roleId);
        Task<Result> ValidateRolesAsync(IEnumerable<Guid> roleIds);
    }
}
