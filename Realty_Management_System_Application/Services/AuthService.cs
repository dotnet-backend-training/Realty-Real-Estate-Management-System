using Mapster;
using Realty_Management_System_Application.DTO_s.Auth;
using Realty_Management_System_Application.DTO_s.Auth.Register;
using Realty_Management_System_Application.Helpers;
using Realty_Management_System_Application.Interfaces;
using Realty_Management_System_Application.Interfaces.Services;
using Realty_Management_System_Application.Interfaces.Validators;
using Realty_Management_System_Application.Mapping;
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
        private readonly IJwtTokenGenerator _tokenGenerator;
        private readonly IUserRoleRepository _userRoleRepository;
        private readonly IRoleValidator _roleValidator;
        private readonly IRoleRepository _roleRepository;

        public AuthService(
            IUserIdentifierStrategyFactory userIdentifierStrategyFactory,
            ILocationValidator locationValidator,
            IUserValidator userValidator,
            IRoleValidator roleValidator,
            IJwtTokenGenerator tokenGenerator,
            IUserRoleRepository userRoleRepository,
            IAuthRepository authRepository,
            IRoleRepository roleRepository
        )
        {
            _authRepository = authRepository;
            _userIdentifierStrategyFactory = userIdentifierStrategyFactory;
            _locationValidator = locationValidator;
            _userValidator = userValidator;
            _tokenGenerator = tokenGenerator;
            _userRoleRepository = userRoleRepository;
            _roleValidator = roleValidator;
            _roleRepository = roleRepository;
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
            var accessToken = await _tokenGenerator.GenerateAccessTokenAsync(foundUser);
            var loginResponseDto = foundUser.Adapt<LoginResponseDto>();
            var userRoles = await _userRoleRepository.GetUserRolesAsync(foundUser);
            loginResponseDto.Roles = userRoles;
            loginResponseDto.AccessToken = accessToken;
            return SuccessResult<LoginResponseDto>.Create(
                statusCode: (int)HttpStatusCode.OK,
                message: "Login successful",
                data: loginResponseDto
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
            var roleValidationResult = await _roleValidator.ValidateRolesAsync(registerRequestDto.RoleIds);
            if (!roleValidationResult.Success)
            {
                return roleValidationResult;
            }
            User userModel = registerRequestDto.Adapt<User>(MappingProfile.TypeAdapterConfig);
            var registerResult = await _authRepository.RegisterAsync(
                user: userModel,
                password: registerRequestDto.Password
            );
            if (!registerResult.Succeeded)
            {
                return FailureResult.Create(
                    statusCode: (int)(HttpStatusCode.BadRequest),
                    message: "Register failed",
                    error: string.Join(", ", registerResult.Errors.Select(error => error.Description))
                );
            }
            var accessToken = await _tokenGenerator.GenerateAccessTokenAsync(userModel);
            var registerResponseDto = userModel.Adapt<RegisterResponseDto>();
            var roles = await _roleRepository.GetRolesByIdsAsync(registerRequestDto.RoleIds);
            var addRolesToUserResult = await _userRoleRepository.AddToRolesAsync(
                user: userModel,
                roleNames: roles!.Select(role => role!.Name!)
            );
            registerResponseDto.RoleNames = roles.Select(role => role!.Name!);
            registerResponseDto.AccessToken = accessToken;
            return SuccessResult<RegisterResponseDto>.Create(
                statusCode: (int)(HttpStatusCode.Created),
                message: "Register successfully",
                data: registerResponseDto
            );
        }
    }
}
