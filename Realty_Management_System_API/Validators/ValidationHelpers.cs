using Realty_Management_System_Application.Helpers;
using System.ComponentModel.DataAnnotations;

namespace Realty_Management_System_API.Validators
{
    internal static class ValidationHelpers
    {
        public static bool IsValidEmail(string email)
        {
            var emailValidation = new EmailAddressAttribute();
            return emailValidation.IsValid(email);
        }
        public static bool IsValidUsername(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                return false;
            }
            return RegexPatterns.UsernameRegex().IsMatch(username);
        }
    }
}