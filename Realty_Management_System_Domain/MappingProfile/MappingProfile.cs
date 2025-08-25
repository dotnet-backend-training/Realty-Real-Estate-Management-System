using Mapster;
using Realty_Management_System_Application.Constants;
using Realty_Management_System_Domain.DTO_s.Auth;
using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Domain.MappingProfile
{
    public class MappingProfile
    {
        private static readonly TypeAdapterConfig _config = new();
        public static TypeAdapterConfig TypeAdapterConfig => _config;

        static MappingProfile()
        {
            _config.NewConfig<RegisterRequestDto, User>().Map(
                member: userMdoelDest => userMdoelDest.ProfileImageUrl,
                source: registerRequestDtoSource =>
                registerRequestDtoSource.ProfileImageUrl ?? DefaultImages.ProfileImageUrl
            );
        }
    }
}
