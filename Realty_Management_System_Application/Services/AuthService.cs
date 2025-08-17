using FluentValidation;
using FluentValidation.Results;
using Realty_Management_System_Application.DTO_s.Auth;
using Realty_Management_System_Application.Helpers;
using Realty_Management_System_Application.Interfaces;
using Realty_Management_System_Application.Shared;
using Realty_Management_System_Application.Shared.Result;
using Realty_Management_System_Domain.Repositories;

namespace Realty_Management_System_Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _authRepository;
        private readonly IValidator<LoginRequestDto> _loginRequestDtoValidator;

        public AuthService(
        IAuthRepository authRepository,
        IValidator<LoginRequestDto> loginRequestDtoValidator
        )
        {
            _authRepository = authRepository;
            _loginRequestDtoValidator = loginRequestDtoValidator;
        }
        public async Task<Result> LoginAsync(LoginRequestDto loginRequestDto)
        {
            ValidationResult validationResult = _loginRequestDtoValidator.Validate(loginRequestDto);
            if (!validationResult.IsValid)
            {
                return FailResult.Create(
                        code: ErrorCode.ValidationFailed,
                        message: "Validation failed for one or more fields.",
                        errors: [.. validationResult.Errors.Select(
                            error => error.ErrorMessage
                        )]
                );
            }
            var userIdentifier = UserIdentifierHelper.DetectIdentifierType(loginRequestDto.Identifier);
            var foundUser = await _authRepository.FindUserAsync(
                loginRequestDto.Identifier,
                userIdentifier
            );
            if (foundUser is null)
            {
                return FailResult.Create(
                    code: ErrorCode.UserNotFound,
                    message: "Failed to login.",
                    error: "User not found."
                );
            }
            var loginResult = await _authRepository.LoginAsync(
                user: foundUser,
                password: loginRequestDto.Password
            );
            if (!loginResult.Succeeded)
            {
                return FailResult.Create(
                    code: ErrorCode.LoginFailed,
                    message: "Login failed",
                    error: "Invalid credentials, please try again."
                );
            }
            return SuccessResult.Create(
                successCode: SuccessCode.SuccessfulLogin,
                message: "Login successful"
            );
        }
    }
}
