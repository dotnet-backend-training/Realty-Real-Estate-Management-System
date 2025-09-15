using Realty_Management_System_Application.DTO_s.Auth;
using Realty_Management_System_Application.Interfaces;
using Realty_Management_System_Application.Interfaces.Services;
using Realty_Management_System_Application.Services;
using Realty_Management_System_Application.Validators.RegisterRequestDtoValidator;
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

            services.AddScoped<IValidationRule<RegisterRequestDto>, UniqueUserIdentifierRule>();
            services.AddScoped<IValidationRule<RegisterRequestDto>, LocationExistsRule>();
            services.AddScoped<IValidationRule<RegisterRequestDto>, ValidRolesRule>();
            services.AddScoped<ValidationRuleSet<RegisterRequestDto>>();


            return services;
        }
    }
}
