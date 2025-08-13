namespace Realty_Management_System_Domain.Entities
{
    public class PropertyCategory : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public ICollection<PropertyCategoryAssociation> PropertyCategoryAssociations { get; set; } = new HashSet<PropertyCategoryAssociation>();
    }
}
