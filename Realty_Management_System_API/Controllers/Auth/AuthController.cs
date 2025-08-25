using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Realty_Management_System_Application.Interfaces;
using Realty_Management_System_Application.Shared.Result;
using Realty_Management_System_Domain.DTO_s.Auth;

namespace Realty_Management_System_API.Controllers.Auth
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(
            IAuthService authService
        )
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> LoginAsync(
            [FromBody] LoginRequestDto loginRequestDto,
            [FromServices] IValidator<LoginRequestDto> loginRequestDtoValidator
        )
        {
            var validationResult = loginRequestDtoValidator.Validate(loginRequestDto);
            if (!validationResult.IsValid)
            {
                var modelState = new ModelStateDictionary();
                validationResult.Errors.ForEach((error) =>
                    {
                        modelState.AddModelError(error.ErrorCode, error.ErrorMessage);
                    }
                );
                return ValidationProblem(modelState);
            }
            var loginResult = await _authService.LoginAsync(loginRequestDto);
            if (loginResult is FailureResult loginFailureResult)
            {
                return Problem(
                    statusCode: loginFailureResult.StatusCode,
                    title: loginFailureResult.Message,
                    detail: string.Join(", ", loginFailureResult.Errors)
                );
            }
            else if (loginResult is SuccessResult loginSuccessResult)
            {
                return Ok(loginSuccessResult);
            }
            else
            {
                return Problem(
                    statusCode: 500,
                    title: "Unknown result type",
                    detail: "The login operation returned an unexpected result."
                );
            }
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsync(
            [FromBody] RegisterRequestDto registerRequestDto,
            [FromServices] IValidator<RegisterRequestDto> registerRequestDtoValidator
        )
        {
            var validationResult = registerRequestDtoValidator.Validate(registerRequestDto);
            if (!validationResult.IsValid)
            {
                var modelState = new ModelStateDictionary();
                validationResult.Errors.ForEach((error) =>
                {
                    modelState.AddModelError(error.ErrorCode, error.ErrorMessage);
                }
                );
                return ValidationProblem(modelState);
            }
            var registerResult = await _authService.RegisterAsync(registerRequestDto);
            if (registerResult is FailureResult registerFailureResult)
            {
                return Problem(
                    statusCode: registerFailureResult.StatusCode,
                    title: registerFailureResult.Message,
                    detail: string.Join(", ", registerFailureResult.Errors)
                );
            }
            else if (registerResult is SuccessResult registerSuccessResult)
            {
                return Ok(registerResult);
            }
            else
            {
                return Problem(
                    statusCode: 500,
                    title: "Unknown result type",
                    detail: "The register operation returned an unexpected result."
                );
            }
        }
    }
}
