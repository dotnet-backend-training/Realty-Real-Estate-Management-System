namespace Realty_Management_System_Domain.Entities
{
    public class NearbyPlace : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public double DistanceInKm { get; set; }
        public Guid NearbyPlaceTypeId { get; set; }
        public NearbyPlaceType NearbyPlaceType { get; set; } = default!;
        public Guid PropertyId { get; set; }
        public Property Property { get; set; } = default!;
    }
}