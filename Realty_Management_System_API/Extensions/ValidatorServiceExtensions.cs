using FluentValidation;
using Realty_Management_System_Application.Interfaces;
using Realty_Management_System_Application.Validators;
using System.Reflection;

namespace Realty_Management_System_API.Extensions
{
    public static class ValidatorServiceExtensions
    {
        public static IServiceCollection AddValidators(this IServiceCollection services)
        {
            services.AddScoped<ILocationValidator, LocationValidator>();
            services.AddScoped<IUserValidator, UserValidator>();

            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
