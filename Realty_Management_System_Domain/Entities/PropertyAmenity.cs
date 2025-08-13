namespace Realty_Management_System_Domain.Entities
{
    public class PropertyAmenity : BaseEntity
    {
        public Guid PropertyId { get; set; }
        public Property Property { get; set; } = default!;
        public Guid AmenityId { get; set; }
        public Amenity Amenity { get; set; } = default!;
    }
}
