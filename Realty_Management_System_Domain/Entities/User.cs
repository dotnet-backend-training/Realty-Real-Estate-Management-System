using Microsoft.AspNetCore.Identity;

namespace Realty_Management_System_Domain.Entities
{
    public class User : IdentityUser<int>
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public Guid CountryId { get; set; }
        public Country Country { get; set; } = default!;
        public Guid CityId { get; set; }
        public City City { get; set; } = default!;
        public Guid ZoneId { get; set; }
        public Zone Zone { get; set; } = default!;
        public ICollection<Property> Properties { get; set; } = new HashSet<Property>();
        public ICollection<Contract> OwnedContracts { get; set; } = new HashSet<Contract>();
        public ICollection<Contract> CustomerContracts { get; set; } = new HashSet<Contract>();
    }
}
