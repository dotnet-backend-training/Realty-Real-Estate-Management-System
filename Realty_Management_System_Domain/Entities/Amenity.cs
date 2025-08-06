namespace Realty_Management_System_Domain.Entities
{
    public class Amenity : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public ICollection<PropertyAmenity> PropertyAmenities { get; set; } = new HashSet<PropertyAmenity>();
    }
}
