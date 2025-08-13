namespace Realty_Management_System_Domain.Entities
{
    public class City : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public Guid CountryId { get; set; }
        public Country Country { get; set; } = default!;
        public ICollection<Zone> Zones { get; set; } = new HashSet<Zone>();
        public ICollection<User> Users { get; set; } = new HashSet<User>();
        public ICollection<Property> Properties { get; set; } = new HashSet<Property>();
    }
}
