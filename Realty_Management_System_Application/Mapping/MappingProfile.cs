using Mapster;
using Realty_Management_System_Application.Constants;
using Realty_Management_System_Application.DTO_s.Auth;
using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Application.Mapping
{
    public static class MappingProfile
    {
        private static readonly TypeAdapterConfig _config = new();
        public static TypeAdapterConfig TypeAdapterConfig => _config;

        static MappingProfile()
        {
            // RegisterRequestDto → User.
            _config.NewConfig<RegisterRequestDto, User>().Map(
                member: userModelDest => userModelDest.ProfileImageUrl,
                source: registerRequestDtoSource =>
                registerRequestDtoSource.ProfileImageUrl ?? DefaultImages.ProfileImageUrl
            );
        }
    }
}
