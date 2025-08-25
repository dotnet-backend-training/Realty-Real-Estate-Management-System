using Realty_Management_System_Application.Constants;
using Realty_Management_System_Application.DTO_s.Auth;
using Realty_Management_System_Application.Helpers;
using Realty_Management_System_Application.Interfaces;
using Realty_Management_System_Application.Shared.Result;
using Realty_Management_System_Domain.Entities;
using Realty_Management_System_Domain.Enums;
using Realty_Management_System_Domain.Interfaces;
using Realty_Management_System_Domain.Repositories;
using System.Net;

namespace Realty_Management_System_Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _authRepository;
        private readonly IUserIdentifierStrategyFactory _userIdentifierStrategyFactory;
        private readonly ILocationValidator _locationValidator;
        private readonly IUserValidator _userValidator;

        public AuthService(
            IAuthRepository authRepository,
            IUserRepository userRepository,
            IUserIdentifierStrategyFactory userIdentifierStrategyFactory,
            ILocationValidator locationValidator,
            IUserValidator userValidator
        )
        {
            _authRepository = authRepository;
            _userIdentifierStrategyFactory = userIdentifierStrategyFactory;
            _locationValidator = locationValidator;
            _userValidator = userValidator;
        }

        public async Task<Result> LoginAsync(LoginRequestDto loginRequestDto)
        {
            UserIdentifierType userIdentifier = UserIdentifierHelper.DetectIdentifierType(loginRequestDto.Identifier);
            var loginStrategy = _userIdentifierStrategyFactory.GetStrategy(userIdentifier);
            var foundUser = await loginStrategy.FindUserAsync(
                loginRequestDto.Identifier
            );
            if (foundUser is null)
            {
                return FailureResult.Create(
                    statusCode: (int)(HttpStatusCode.NotFound),
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
                return FailureResult.Create(
                    statusCode: (int)(HttpStatusCode.BadRequest),
                    message: "Login failed",
                    error: "Invalid credentials, please try again."
                );
            }
            return SuccessResult.Create(
                statusCode: (int)HttpStatusCode.OK,
                message: "Login successful"
            );
        }

        public async Task<Result> RegisterAsync(RegisterRequestDto registerRequestDto)
        {

            var userValidationResult = await _userValidator.ValidateAllAsync(
                username: registerRequestDto.UserName,
                email: registerRequestDto.Email
            );
            if (!userValidationResult.Success)
            {
                return userValidationResult;
            }
            var locationValidationResult = await _locationValidator.ValidateAllAsync(
                countryId: registerRequestDto.CountryId,
                cityId: registerRequestDto.CityId,
                zoneId: registerRequestDto.ZoneId
            );
            if (!locationValidationResult.Success)
            {
                return locationValidationResult;
            }
            var useModel = new User()
            {
                Email = registerRequestDto.Email,
                UserName = registerRequestDto.UserName,
                FirstName = registerRequestDto.FirstName,
                LastName = registerRequestDto.LastName,
                ProfileImageUrl = registerRequestDto.ProfileImageUrl ?? DefaultImages.ProfileImageUrl,
                CountryId = registerRequestDto.CountryId,
                CityId = registerRequestDto.CityId,
                ZoneId = registerRequestDto.ZoneId
            };
            var registerResult = await _authRepository.RegisterAsync(
                useModel,
                registerRequestDto.Password
            );
            if (!registerResult.Succeeded)
            {
                return FailureResult.Create(
                    statusCode: (int)(HttpStatusCode.BadRequest),
                    message: "Register failed",
                    error: string.Join(", ", registerResult.Errors.Select(error => error.Description))
                );
            }
            return SuccessResult.Create(
                statusCode: (int)(HttpStatusCode.Created),
                message: "Register successfully"
            );
        }
    }
}
