using Mapster;
using Realty_Management_System_Application.DTO_s.Auth;
using Realty_Management_System_Application.DTO_s.Auth.Register;
using Realty_Management_System_Application.Helpers;
using Realty_Management_System_Application.Interfaces;
using Realty_Management_System_Application.Interfaces.Services;
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
        private readonly ValidationRuleSet<RegisterRequestDto> _registerRuleSet;
        private readonly IJwtTokenGenerator _tokenGenerator;
        private readonly IUserRoleRepository _userRoleRepository;
        private readonly IRoleRepository _roleRepository;

        public AuthService(
            IAuthRepository authRepository,
            IUserIdentifierStrategyFactory userIdentifierStrategyFactory,
            IJwtTokenGenerator tokenGenerator,
            IUserRoleRepository userRoleRepository,
            IRoleRepository roleRepository,
            ValidationRuleSet<RegisterRequestDto> registerRuleSet
        )
        {
            _authRepository = authRepository;
            _userIdentifierStrategyFactory = userIdentifierStrategyFactory;
            _registerRuleSet = registerRuleSet;
            _tokenGenerator = tokenGenerator;
            _userRoleRepository = userRoleRepository;
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
                    message: "Failed to login.",
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
            var validationResult = await _registerRuleSet.ValidateAllAsync(registerRequestDto);
            if (!validationResult.Success)
            {
                return validationResult;
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
            var registerResponseDto = userModel.Adapt<RegisterResponseDto>();
            var roles = await _roleRepository.GetRolesByIdsAsync(registerRequestDto.RoleIds);
            var addRolesToUserResult = await _userRoleRepository.AddToRolesAsync(
                user: userModel,
                roleNames: roles!.Select(role => role!.Name!)
            );
            if (!addRolesToUserResult.Succeeded)
            {
                return FailureResult.Create(
                    statusCode: (int)HttpStatusCode.BadRequest,
                    message: "Role assignment failed",
                    error: string.Join(", ",
                        addRolesToUserResult.Errors.Select(e => e.Description)
                    )
                );
            }
            var accessToken = await _tokenGenerator.GenerateAccessTokenAsync(userModel);
            registerResponseDto.RoleNames = roles.Select(role => role!.Name!);
            registerResponseDto.AccessToken = accessToken;
            return SuccessResult<RegisterResponseDto>.Create(
                statusCode: (int)(HttpStatusCode.Created),
                message: "Registered successfully",
                data: registerResponseDto
            );
        }
    }
}
