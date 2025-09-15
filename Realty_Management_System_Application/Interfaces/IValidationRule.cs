using Realty_Management_System_Application.Shared.Result;

namespace Realty_Management_System_Application.Interfaces
{
    public interface IValidationRule<TContext>
    {
        Task<Result> ValidateAsync(TContext context);
    }
}