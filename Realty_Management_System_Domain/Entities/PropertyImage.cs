namespace Realty_Management_System_Domain.Entities
{
    public class PropertyImage : BaseEntity
    {
        public string Url { get; set; } = string.Empty;
        public string AltText { get; set; } = string.Empty;
        public Guid PropertyId { get; set; }
        public Property Property { get; set; } = default!;
    }
}
