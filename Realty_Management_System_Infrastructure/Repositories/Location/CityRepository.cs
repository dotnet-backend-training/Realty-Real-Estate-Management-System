using Microsoft.EntityFrameworkCore;
using Realty_Management_System_Domain.Interfaces.Location;
using Realty_Management_System_Infrastructure.Data.Contexts;

namespace Realty_Management_System_Infrastructure.Repositories.Location
{
    public class CityRepository : ICityRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public CityRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task<bool> ExistsByIdAsync(Guid cityId)
        {
            return await _applicationDbContext.Cities.AnyAsync(
                city => city.Id == cityId
            );
        }
    }
}
