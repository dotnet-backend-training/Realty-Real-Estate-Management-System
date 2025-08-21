using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Realty_Management_System_Application.DTO_s.Auth;
using Realty_Management_System_Application.Interfaces;

namespace Realty_Management_System_API.Controllers
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

        [HttpPost]
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
            var result = await _authService.LoginAsync(loginRequestDto);
            return Ok(result);
        }
    }
}
