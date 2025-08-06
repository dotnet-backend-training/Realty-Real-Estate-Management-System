namespace Realty_Management_System_Domain.Entities
{
    public class Property : BaseEntity
    {
        public string Slug { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int NumberOfBathrooms { get; set; }
        public int NumberOfFloors { get; set; }
        public int NumberOfBedrooms { get; set; }
        public int NumberOfGarage { get; set; }
        public decimal Price { get; set; }
        public DateTime YearBuilt { get; set; }
        public Guid PropertyStatusId { get; set; }
        public PropertyStatus PropertyStatus { get; set; } = default!;
        public Guid CountryId { get; set; }
        public Country Country { get; set; } = default!;
        public Guid CityId { get; set; }
        public City City { get; set; } = default!;
        public Guid ZoneId { get; set; }
        public Zone Zone { get; set; } = default!;
        public Guid PriceUnitId { get; set; }
        public PriceUnit PriceUnit { get; set; } = default!;
        public ICollection<PropertyImage> PropertyImages { get; set; } = new HashSet<PropertyImage>();
        public ICollection<PropertyCategoryAssociation> PropertyCategoryAssociations { get; set; } = new HashSet<PropertyCategoryAssociation>();
        public Guid OwnerId { get; set; }
        public User Owner { get; set; } = default!;
        public ICollection<PropertyFeatureAssociation> PropertyFeatureAssociations { get; set; } = new HashSet<PropertyFeatureAssociation>();
        public ICollection<NearbyPlace> NearbyPlaces { get; set; } = new HashSet<NearbyPlace>();
    }
}
