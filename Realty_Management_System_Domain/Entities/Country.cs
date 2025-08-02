namespace Realty_Management_System_Domain.Entities
{
    public class Country : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string? ISOCode { get; set; } 
        public ICollection<City> Cities { get; set; } = new HashSet<City>();
    }
}