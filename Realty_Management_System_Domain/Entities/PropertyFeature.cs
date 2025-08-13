namespace Realty_Management_System_Domain.Entities
{
    public class PropertyFeature : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public ICollection<PropertyFeatureAssociation> PropertyFeatureAssociations { get; set; } = new HashSet<PropertyFeatureAssociation>();
    }
}