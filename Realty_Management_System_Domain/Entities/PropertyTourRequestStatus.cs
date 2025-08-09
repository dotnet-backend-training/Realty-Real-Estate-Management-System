namespace Realty_Management_System_Domain.Entities
{
    public class PropertyTourRequestStatus : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public ICollection<PropertyTourRequest> PropertyTourRequests { get; set; } = default!;
    }
}
