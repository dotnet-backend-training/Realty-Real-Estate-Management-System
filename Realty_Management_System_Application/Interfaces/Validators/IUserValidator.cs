using Realty_Management_System_Application.Shared.Result;

namespace Realty_Management_System_Application.Interfaces.Validators
{
    public interface IUserValidator
    {
        Task<Result> ValidateUsernameAsync(string username);
        Task<Result> ValidateEmailAsync(string email);
        Task<Result> ValidateAllAsync(string username, string email);
    }
}
