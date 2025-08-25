using Realty_Management_System_Application.DTO_s.Auth;
using Realty_Management_System_Application.Helpers;
using Realty_Management_System_Application.Interfaces;
using Realty_Management_System_Application.Shared.Result;
using Realty_Management_System_Domain.Entities;
using Realty_Management_System_Domain.Enums;
using Realty_Management_System_Domain.Interfaces;
using Realty_Management_System_Domain.Interfaces.Location;
using Realty_Management_System_Domain.Repositories;
using System.Net;

namespace Realty_Management_System_Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _authRepository;
        private readonly IUserRepository _userRepository;
        private readonly IUserIdentifierStrategyFactory _userIdentifierStrategyFactory;
        private readonly ICountryRepository _countryRepository;
        private readonly ICityRepository _cityRepository;
        private readonly IZoneRepository _zoneRepository;

        public AuthService(
            IAuthRepository authRepository,
            IUserRepository userRepository,
            IUserIdentifierStrategyFactory userIdentifierStrategyFactory,
            ICountryRepository countryRepository,
            ICityRepository cityRepository,
            IZoneRepository zoneRepository
        )
        {
            _authRepository = authRepository;
            _userRepository = userRepository;
            _userIdentifierStrategyFactory = userIdentifierStrategyFactory;
            _countryRepository = countryRepository;
            _cityRepository = cityRepository;
            _zoneRepository = zoneRepository;
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
            bool userNameExistence = await _userRepository.ExistsByUsernameAsync(registerRequestDto.UserName);
            if (userNameExistence)
            {
                return FailureResult.Create(
                    statusCode: (int)(HttpStatusCode.Conflict),
                    message: "Register failed",
                    error: "Username or email may already be in use."
                );
            }
            bool emailExistence = await _userRepository.ExistsByEmailAsync(registerRequestDto.Email);
            if (emailExistence)
            {
                return FailureResult.Create(
                    statusCode: (int)(HttpStatusCode.Conflict),
                    message: "Register failed",
                    error: "Username or email may already be in use."
                );
            }
            bool countryExistence = await _countryRepository.ExistsByIdAsync(registerRequestDto.CountryId);
            if (!countryExistence)
            {
                return FailureResult.Create(
                    statusCode: (int)(HttpStatusCode.BadRequest),
                    message: "Register failed",
                    error: "The selected country is not valid. Please choose a valid country and try again."
                );
            }
            bool cityExistence = await _cityRepository.ExistsByIdAsync(registerRequestDto.CityId);
            if (!cityExistence)
            {
                return FailureResult.Create(
                    statusCode: (int)(HttpStatusCode.BadRequest),
                    message: "Register failed",
                    error: "The selected city is not valid. Please choose a valid city and try again."
                );
            }
            bool zoneExistence = await _zoneRepository.ExistsByIdAsync(registerRequestDto.ZoneId);
            if (!zoneExistence)
            {
                return FailureResult.Create(
                    statusCode: (int)(HttpStatusCode.BadRequest),
                    message: "Register failed",
                    error: "The selected zone is not valid. Please choose a valid zone and try again."
                );
            }
            var useModel = new User()
            {
                Email = registerRequestDto.Email,
                UserName = registerRequestDto.UserName,
                FirstName = registerRequestDto.FirstName,
                LastName = registerRequestDto.LastName,
                ProfileImageUrl = registerRequestDto.ProfileImageUrl ?? "https://upload.wikimedia.org/wikipedia/commons/9/99/Sample_User_Icon.png",
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
