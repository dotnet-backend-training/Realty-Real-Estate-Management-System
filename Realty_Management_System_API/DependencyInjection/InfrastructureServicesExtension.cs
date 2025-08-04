using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Realty_Management_System_Domain.Entities;
using Realty_Management_System_Domain.Interfaces;
using Realty_Management_System_Infrastructure.Data.Contexts;
using Realty_Management_System_Infrastructure.Repositories;

namespace Realty_Management_System_Api.DependencyInjection
{
    public static class InfrastructureServicesExtension
    {
        public static void AddInfrastructureServices(
            this IServiceCollection services,
            IAppsettingsRepository appsettingsRepository
            )
        {
            // Singleton appSetting configuration
            services.AddSingleton<IAppsettingsRepository, AppsettingsRepository>();

            // Identity configuration
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

            // ApplicationDbContext configuration
            string connectionStrings = appsettingsRepository.GetDefaultConnection();

            services.AddDbContext<ApplicationDbContext>(
                options =>
                {
                    options.UseSqlServer(connectionStrings);
                }
            );
        }

    }
}
