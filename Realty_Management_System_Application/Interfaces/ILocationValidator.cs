using Realty_Management_System_Application.Shared.Result;

namespace Realty_Management_System_Application.Interfaces
{
    public interface ILocationValidator
    {
        Task<Result> ValidateCountryAsync(Guid countryId);
        Task<Result> ValidateCityAsync(Guid cityId);
        Task<Result> ValidateZoneAsync(Guid zoneId);
        Task<Result> ValidateAllAsync(Guid countryId, Guid cityId, Guid zoneId);
    }
}
