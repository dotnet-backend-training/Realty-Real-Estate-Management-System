namespace Realty_Management_System_Domain.Entities
{
    public class PropertyReview : BaseEntity
    {
        public string Comment { get; set; } = string.Empty;
        public decimal Rating { get; set; }
        public Guid PropertyId { get; set; }
        public Property Property { get; set; } = default!;
        public Guid UserId { get; set; }
        public User User { get; set; } = default!;
    }
}
