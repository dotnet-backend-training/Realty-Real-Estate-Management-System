using Realty_Management_System_Application.Interfaces;
using Realty_Management_System_Application.Shared.Result;
using Realty_Management_System_Domain.Interfaces;
using System.Net;

namespace Realty_Management_System_Application.Validators
{
    public class RoleValidator : IRoleValidator
    {
        private readonly IRoleRepository _roleRepository;

        public RoleValidator(
            IRoleRepository roleRepository
        )
        {
            _roleRepository = roleRepository;
        }
        public async Task<Result> ValidateRoleAsync(Guid roleId)
        {
            bool roleExistence = await _roleRepository.ExistsByIdAsync(roleId);
            if (roleExistence)
            {
                return FailureResult.Create(
                    statusCode: (int)(HttpStatusCode.Conflict),
                    message: "Invalid role",
                    error: "The specified role does not exist."
                );
            }
            return SuccessResult.Create(
                statusCode: (int)(HttpStatusCode.OK),
                message: "Role validation successful."
            );
        }

        public async Task<Result> ValidateRolesAsync(IEnumerable<Guid> roleIds)
        {
            foreach (var roleId in roleIds)
            {
                bool roleExistence = await _roleRepository.ExistsByIdAsync(roleId);
                if (!roleExistence)
                {
                    return FailureResult.Create(
                        statusCode: (int)(HttpStatusCode.BadRequest),
                        message: "Invalid role(s)",
                        error: $"Role with Id '{roleId}' does not exist."
                    );
                }
            }
            return SuccessResult.Create(
                statusCode: (int)(HttpStatusCode.OK),
                message: "All roles validation successful."
            );
        }
    }
}
