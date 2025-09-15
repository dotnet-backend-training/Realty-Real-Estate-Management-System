using Realty_Management_System_Application.DTO_s.Auth;
using Realty_Management_System_Application.Interfaces;
using Realty_Management_System_Application.Interfaces.Validators;
using Realty_Management_System_Application.Shared.Result;

public class LocationExistsRule : IValidationRule<RegisterRequestDto>
{
    private readonly ILocationValidator _locationValidator;
    public LocationExistsRule(ILocationValidator locationValidator)
    {
        _locationValidator = locationValidator;
    }

    public async Task<Result> ValidateAsync(RegisterRequestDto registerRequestDto)
    {
        return await _locationValidator.ValidateAllAsync(
            registerRequestDto.CountryId,
            registerRequestDto.CityId,
            registerRequestDto.ZoneId
        );
    }
}
