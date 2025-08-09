namespace Realty_Management_System_Domain.Entities
{
    public class PropertyTourRequest : BaseEntity
    {
        public DateTime PreferredDateTime { get; set; }
        public string Message { get; set; } = string.Empty;
        public Guid PropertyTourRequestStatusId { get; set; }
        public PropertyTourRequestStatus PropertyTourRequestStatus { get; set; } = default!;
        public Guid PropertyId { get; set; }
        public Property Property { get; set; } = default!;
        public Guid UserId { get; set; }
        public User User { get; set; } = default!;
    }
}
