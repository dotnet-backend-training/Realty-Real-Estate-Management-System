namespace Realty_Management_System_Domain.Entities
{
    public class PriceUnit : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Abbreviation { get; set; } = string.Empty;
        public string Symbol { get; set; } = string.Empty;
        public decimal? ConversionFactor { get; set; }
        public Guid PriceUnitTypeId { get; set; }
        public PriceUnitType PriceUnitType { get; set; } = default!;
        public ICollection<Property> Properties { get; set; } = new HashSet<Property>();
    }
}
