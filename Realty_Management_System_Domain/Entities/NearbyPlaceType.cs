namespace Realty_Management_System_Domain.Entities
{
    public class NearbyPlaceType : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public ICollection<NearbyPlace> NearbyPlaces { get; set; } = new HashSet<NearbyPlace>();
    }
}