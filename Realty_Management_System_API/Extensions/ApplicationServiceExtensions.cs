using Realty_Management_System_Application.Interfaces;
using Realty_Management_System_Application.Services;
using Realty_Management_System_Infrastructure.Strategies.UserIdentifier;

namespace Realty_Management_System_API.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IAuthService, AuthService>();

            // User Identifier Strategies
            services.AddScoped<IUserIdentifierStrategyFactory, UserIdentifierStrategyFactory>();
            services.AddScoped<IUserIdentifierStrategy, EmailIdentifierStrategy>();
            services.AddScoped<IUserIdentifierStrategy, UsernameIdentifierStrategy>();

            return services;
        }
    }
}
