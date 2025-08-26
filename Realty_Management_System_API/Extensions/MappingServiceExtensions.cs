using Mapster;

namespace Realty_Management_System_API.Extensions
{
    public static class MappingServiceExtensions
    {
        public static IServiceCollection AddMappings(this IServiceCollection services)
        {
            var config = TypeAdapterConfig.GlobalSettings;
            services.AddSingleton(config);

            return services;
        }
    }
}
