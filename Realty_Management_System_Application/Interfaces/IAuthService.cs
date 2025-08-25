using Realty_Management_System_Application.Shared.Result;
using Realty_Management_System_Domain.DTO_s.Auth;

namespace Realty_Management_System_Application.Interfaces
{
    public interface IAuthService
    {
        public Task<Result> LoginAsync(LoginRequestDto loginRequestDto);
        public Task<Result> RegisterAsync(RegisterRequestDto registerRequestDto);
    }
}
