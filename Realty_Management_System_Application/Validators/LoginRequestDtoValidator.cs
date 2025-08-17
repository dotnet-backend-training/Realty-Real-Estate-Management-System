using FluentValidation;
using Realty_Management_System_Application.DTO_s.Auth;
using Realty_Management_System_Application.Helpers;
using System.ComponentModel.DataAnnotations;

namespace Realty_Management_System_Application.Validators
{
    public class LoginRequestDtoValidator : AbstractValidator<LoginRequestDto>
    {
        public LoginRequestDtoValidator()
        {
            RuleFor(loginRequestDto => loginRequestDto.Identifier)
                .NotEmpty()
                .Must(identifier => IsValidEmail(identifier) || IsValidUsername(identifier))
                .WithMessage("Identifier must be a valid email or username.");
        }
        private static bool IsValidEmail(string email)
        {
            var emailValidation = new EmailAddressAttribute();
            return emailValidation.IsValid(email);
        }
        private static bool IsValidUsername(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                return false;
            }
            return RegexPatterns.UsernameRegex().IsMatch(username);
        }
    }
}

