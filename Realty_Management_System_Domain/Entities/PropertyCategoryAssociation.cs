namespace Realty_Management_System_Domain.Entities
{
    public class PropertyCategoryAssociation : BaseEntity
    {
        public Guid PropertyId { get; set; }
        public Property Property { get; set; } = default!;
        public Guid PropertyCategoryId { get; set; }
        public PropertyCategory PropertyCategory { get; set; } = default!;
    }
}
