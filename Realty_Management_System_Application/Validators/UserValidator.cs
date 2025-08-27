using Realty_Management_System_Application.Interfaces.Validators;
using Realty_Management_System_Application.Shared.Result;
using Realty_Management_System_Domain.Interfaces;
using System.Net;

namespace Realty_Management_System_Application.Validators
{
    public class UserValidator : IUserValidator
    {
        private readonly IUserRepository _userRepository;

        public UserValidator(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<Result> ValidateAllAsync(string username, string email)
        {
            var usernameResult = await ValidateUsernameAsync(username);
            if (!usernameResult.Success)
            {
                return usernameResult;
            }
            var emailResult = await ValidateEmailAsync(email);
            if (!emailResult.Success)
            {
                return emailResult;
            }
            return SuccessResult.Create(
                statusCode: (int)(HttpStatusCode.OK),
                message: "User validation successful."
            );
        }

        public async Task<Result> ValidateEmailAsync(string email)
        {
            bool emailExistence = await _userRepository.ExistsByEmailAsync(email);
            if (emailExistence)
            {
                return FailureResult.Create(
                    statusCode: (int)(HttpStatusCode.Conflict),
                    message: "Register failed",
                    error: "Username or email may already be in use."
                );
            }
            return SuccessResult.Create(
                statusCode: (int)(HttpStatusCode.OK),
                message: "Email validation successful."
            );
        }

        public async Task<Result> ValidateUsernameAsync(string username)
        {
            bool userNameExistence = await _userRepository.ExistsByUsernameAsync(username);
            if (userNameExistence)
            {
                return FailureResult.Create(
                    statusCode: (int)(HttpStatusCode.Conflict),
                    message: "Register failed",
                    error: "Username or email may already be in use."
                );
            }
            return SuccessResult.Create(
                statusCode: (int)(HttpStatusCode.OK),
                message: "Username validation successful."
            );
        }
    }
}
