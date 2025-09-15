using Realty_Management_System_Application.DTO_s.Auth;
using Realty_Management_System_Application.Interfaces;
using Realty_Management_System_Application.Interfaces.Validators;
using Realty_Management_System_Application.Shared.Result;

namespace Realty_Management_System_Application.Validators.RegisterRequestDtoValidator
{
    public class UniqueUserIdentifierRule : IValidationRule<RegisterRequestDto>
    {
        private readonly IUserValidator _userValidator;
        public UniqueUserIdentifierRule(IUserValidator userValidator)
        {
            _userValidator = userValidator;
        }

        public async Task<Result> ValidateAsync(RegisterRequestDto request)
        {
            return await _userValidator.ValidateAllAsync(
                request.UserName,
                request.Email
            );
        }
    }
}
