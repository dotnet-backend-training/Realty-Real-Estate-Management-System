using Microsoft.EntityFrameworkCore;
using Realty_Management_System_Domain.Interfaces.Location;
using Realty_Management_System_Infrastructure.Data.Contexts;

namespace Realty_Management_System_Infrastructure.Repositories.Location
{
    public class ZoneRepository : IZoneRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public ZoneRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task<bool> ExistsByIdAsync(Guid zoneId)
        {
            return await _applicationDbContext.Zones.AnyAsync(
                zone => zone.Id == zoneId
            );
        }
    }
}
