namespace Realty_Management_System_Domain.Interfaces.Location
{
    public interface ICountryRepository
    {
        public Task<bool> ExistsByIdAsync(Guid countryId);
    }
}
