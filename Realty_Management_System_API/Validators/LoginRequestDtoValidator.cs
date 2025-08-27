using FluentValidation;
using Realty_Management_System_Application.DTO_s.Auth;

namespace Realty_Management_System_API.Validators
{
    public class LoginRequestDtoValidator : AbstractValidator<LoginRequestDto>
    {
        public LoginRequestDtoValidator()
        {
            RuleFor(loginRequestDto => loginRequestDto.Identifier)
                .NotEmpty()
                .Must(identifier => ValidationHelpers.IsValidEmail(identifier) || ValidationHelpers.IsValidUsername(identifier))
                .WithMessage("Identifier must be a valid email or username.");
        }
    }
}

