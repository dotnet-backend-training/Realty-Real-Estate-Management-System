using FluentValidation;
using Realty_Management_System_Application.DTO_s.Auth;

namespace Realty_Management_System_API.Validators
{
    public class RegisterRequestDtoValidator : AbstractValidator<RegisterRequestDto>
    {
        public RegisterRequestDtoValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage("Email is required.")
                .Must(ValidationHelpers.IsValidEmail)
                .WithMessage("Email is not valid.");

            RuleFor(x => x.UserName)
                .NotEmpty()
                .WithMessage("Username is required.")
                .Must(ValidationHelpers.IsValidUsername)
                .WithMessage("Username is not valid.");

            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("Password is required.")
                .MinimumLength(6)
                .WithMessage("Password must be at least 6 characters long.");

            RuleFor(x => x.FirstName)
                .NotEmpty()
                .WithMessage("First name is required.");

            RuleFor(x => x.LastName)
                .NotEmpty()
                .WithMessage("Last name is required.");

            RuleFor(x => x.CountryId)
                .NotEmpty()
                .WithMessage("Country is required.");

            RuleFor(x => x.CityId)
                .NotEmpty()
                .WithMessage("City is required.");

            RuleFor(x => x.ZoneId)
                .NotEmpty()
                .WithMessage("Zone is required.");

            RuleFor(x => x.RoleIds)
                .NotEmpty()
                .WithMessage("At least one role is required.")
                .Must(roleIds => roleIds.All(roleId => roleId != Guid.Empty))
                .WithMessage("Role Id(s) cannot be empty GUID.");
        }
    }
}
