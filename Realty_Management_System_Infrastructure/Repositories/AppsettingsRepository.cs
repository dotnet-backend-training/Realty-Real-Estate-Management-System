using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Realty_Management_System_Domain.Interfaces;
using Realty_Management_System_Infrastructure.Constants;
using Realty_Management_System_Infrastructure.Exceptions;

namespace Realty_Management_System_Infrastructure.Repositories
{
    public class AppsettingsRepository : IAppsettingsRepository
    {
        private readonly IConfiguration _configuration;
        public AppsettingsRepository(
            IConfiguration configuration
        )
        {
            this._configuration = configuration;
        }

        public string GetDefaultConnection()
        {
            string? connectionString = _configuration[
                AppSettingsConstants.AppSettingsKeys.ConnectionStrings.DefaultConnection
            ];
            if (connectionString.IsNullOrEmpty())
            {
                throw AppSettingException.ConnectionStrings.DefaultConnectionStringNotFound;
            }
            return connectionString!;
        }
    }
}
