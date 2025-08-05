namespace Realty_Management_System_Domain.Entities
{
    public class PriceUnitType : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public ICollection<PriceUnit> PriceUnits { get; set; } = new HashSet<PriceUnit>();
    }
}
