using Realty_Management_System_Application.DTO_s.Auth;
using Realty_Management_System_Application.Interfaces;
using Realty_Management_System_Application.Shared.Result;

public class ValidRolesRule : IValidationRule<RegisterRequestDto>
{
    private readonly IRoleValidator _roleValidator;
    public ValidRolesRule(IRoleValidator roleValidator)
    {
        _roleValidator = roleValidator;
    }

    public async Task<Result> ValidateAsync(RegisterRequestDto request)
    {
        return await _roleValidator.ValidateRolesAsync(request.RoleIds);
    }
}
