using Microsoft.AspNetCore.Identity;
using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Api.DependencyInjection
{
    public static class InfrastructureServicesExtension
    {
        public static void AddInfrastructureServices(
            this IServiceCollection services,
            IConfiguration configuration
            )
        {
            services.AddIdentity<User, IdentityRole<int>>(
                options =>
                {
                    options.Password.RequireDigit = true;
                    options.Password.RequireLowercase = true;
                    options.Password.RequireUppercase = true;
                    options.Password.RequireNonAlphanumeric = true;
                    options.Password.RequiredUniqueChars = 0;
                }
            );

        }

    }
}
