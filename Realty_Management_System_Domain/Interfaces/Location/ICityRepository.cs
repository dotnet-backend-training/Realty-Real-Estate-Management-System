namespace Realty_Management_System_Domain.Interfaces.Location
{
    public interface ICityRepository
    {
        public Task<bool> ExistsByIdAsync(Guid cityId);
    }
}
