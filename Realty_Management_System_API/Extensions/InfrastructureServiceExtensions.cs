using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Realty_Management_System_Domain.Entities;
using Realty_Management_System_Domain.Interfaces;
using Realty_Management_System_Domain.Interfaces.Location;
using Realty_Management_System_Domain.Repositories;
using Realty_Management_System_Infrastructure.Constants;
using Realty_Management_System_Infrastructure.Data.Contexts;
using Realty_Management_System_Infrastructure.Exceptions;
using Realty_Management_System_Infrastructure.Repositories;
using Realty_Management_System_Infrastructure.Repositories.Location;

namespace Realty_Management_System_API.Extensions
{
    public static class InfrastructureServiceExtensions
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            // Identity
            services.AddIdentity<User, IdentityRole<Guid>>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequiredUniqueChars = 0;
            }).AddEntityFrameworkStores<ApplicationDbContext>();

            // DbContext
            string? connectionString = configuration.GetConnectionString(
                AppSettingsConstants.AppSettingsKeys.ConnectionStrings.DefaultConnection);

            if (string.IsNullOrEmpty(connectionString))
                throw AppSettingException.ConnectionStrings.DefaultConnectionStringNotFound;

            services.AddDbContext<ApplicationDbContext>(
                options => options.UseSqlServer(connectionString));

            // Repositories
            services.AddScoped<IAuthRepository, AuthRepository>();
            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<ICountryRepository, CountryRepository>();
            services.AddScoped<IZoneRepository, ZoneRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
