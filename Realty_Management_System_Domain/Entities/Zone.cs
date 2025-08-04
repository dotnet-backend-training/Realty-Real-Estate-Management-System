namespace Realty_Management_System_Domain.Entities
{
    public class Zone : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string? PostalCode { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public Guid CountryId { get; set; }
        public Country Country { get; set; } = default!;
        public Guid CityId { get; set; }
        public City City { get; set; } = default!;
        public ICollection<User> Users { get; set; } = new HashSet<User>();
    }
}
