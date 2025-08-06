namespace Realty_Management_System_Domain.Entities
{
    public class PropertyFeatureAssociation : BaseEntity
    {
        public Guid PropertyId { get; set; }
        public Property Property { get; set; } = default!;
        public Guid PropertyFeatureId { get; set; }
        public PropertyFeature PropertyFeature { get; set; } = default!;
        public string Value { get; set; } = string.Empty;
    }
}