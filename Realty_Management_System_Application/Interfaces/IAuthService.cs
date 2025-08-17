using Realty_Management_System_Application.DTO_s.Auth;
using Realty_Management_System_Application.Shared.Result;

namespace Realty_Management_System_Application.Interfaces
{
    public interface IAuthService
    {
        public Task<Result> LoginAsync(LoginRequestDto loginRequestDto);
    }
}
