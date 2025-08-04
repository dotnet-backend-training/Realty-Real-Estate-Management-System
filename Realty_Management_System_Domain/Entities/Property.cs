namespace Realty_Management_System_Domain.Entities
{
    public class Property : BaseEntity
    {
        public string Slug { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int NumberOfBathrooms { get; set; }
        public int NumberOfFloors { get; set; }
        public int NumberOfBedrooms { get; set; }
        public decimal Price { get; set; }
        public int NumberOfGarage { get; set; }
        public DateTime YearBuilt { get; set; }
        public Guid PropertyStatusId { get; set; }
        public PropertyStatus PropertyStatus { get; set; } = default!;
    }
}
