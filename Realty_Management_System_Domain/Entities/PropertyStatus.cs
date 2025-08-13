namespace Realty_Management_System_Domain.Entities
{
    public class PropertyStatus : BaseEntity
    {
        public string Name { get; set; } =  string.Empty;
        public ICollection<Property> Properties { get; set; } = new HashSet<Property>();
    }
}
