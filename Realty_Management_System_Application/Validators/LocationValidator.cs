using Realty_Management_System_Application.Interfaces.Validators;
using Realty_Management_System_Application.Shared.Result;
using Realty_Management_System_Domain.Interfaces.Location;
using System.Net;

namespace Realty_Management_System_Application.Validators
{
    public class LocationValidator : ILocationValidator
    {
        private readonly ICountryRepository _countryRepository;
        private readonly ICityRepository _cityRepository;
        private readonly IZoneRepository _zoneRepository;

        public LocationValidator(
            ICountryRepository countryRepository,
            ICityRepository cityRepository,
            IZoneRepository zoneRepository)
        {
            _countryRepository = countryRepository;
            _cityRepository = cityRepository;
            _zoneRepository = zoneRepository;
        }
        public async Task<Result> ValidateAllAsync(Guid countryId, Guid cityId, Guid zoneId)
        {
            var countryResult = await ValidateCountryAsync(countryId);
            if (!countryResult.Success) return countryResult;

            var cityResult = await ValidateCityAsync(cityId);
            if (!cityResult.Success) return cityResult;

            var zoneResult = await ValidateZoneAsync(zoneId);
            if (!zoneResult.Success) return zoneResult;

            return SuccessResult.Create(
                statusCode: (int)(HttpStatusCode.OK),
                message: "Location validation successful."
            );
        }

        public async Task<Result> ValidateCityAsync(Guid cityId)
        {
            bool cityExistence = await _cityRepository.ExistsByIdAsync(cityId);
            if (!cityExistence)
            {
                return FailureResult.Create(
                    statusCode: (int)(HttpStatusCode.BadRequest),
                    message: "Invalid city",
                    error: "The selected city is not valid. Please choose a valid city and try again."
                );
            }
            return SuccessResult.Create(
                statusCode: (int)(HttpStatusCode.OK),
                message: "City validation successful."
            );
        }

        public async Task<Result> ValidateCountryAsync(Guid countryId)
        {
            bool countryExistence = await _countryRepository.ExistsByIdAsync(countryId);
            if (!countryExistence)
            {
                return FailureResult.Create(
                    statusCode: (int)(HttpStatusCode.BadRequest),
                    message: "Invalid country",
                    error: "The selected country is not valid. Please choose a valid country and try again."
                );
            }
            return SuccessResult.Create(
                statusCode: (int)(HttpStatusCode.OK),
                message: "Country validation successful."
            );
        }

        public async Task<Result> ValidateZoneAsync(Guid zoneId)
        {
            bool zoneExistence = await _zoneRepository.ExistsByIdAsync(zoneId);
            if (!zoneExistence)
            {
                return FailureResult.Create(
                    statusCode: (int)(HttpStatusCode.BadRequest),
                    message: "Invalid zone",
                    error: "The selected zone is not valid. Please choose a valid zone and try again."
                );
            }
            return SuccessResult.Create(
                statusCode: (int)(HttpStatusCode.OK),
                message: "Zone validation successful."
            );
        }
    }
}
