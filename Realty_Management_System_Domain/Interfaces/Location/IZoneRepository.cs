namespace Realty_Management_System_Domain.Interfaces.Location
{
    public interface IZoneRepository
    {
        public Task<bool> ExistsByIdAsync(Guid zoneId);
    }
}
