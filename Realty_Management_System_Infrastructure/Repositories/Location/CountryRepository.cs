using Microsoft.EntityFrameworkCore;
using Realty_Management_System_Domain.Interfaces.Location;
using Realty_Management_System_Infrastructure.Data.Contexts;

namespace Realty_Management_System_Infrastructure.Repositories.Location
{
    public class CountryRepository : ICountryRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public CountryRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task<bool> ExistsByIdAsync(Guid countryId)
        {
            return await _applicationDbContext.Countries.AnyAsync(
                country => country.Id == countryId
            );
        }
    }
}
