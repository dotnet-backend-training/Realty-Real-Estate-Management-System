namespace Realty_Management_System_Domain.Entities
{
    public class PaymentFrequency : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public ICollection<Contract> Contracts { get; set; } = new HashSet<Contract>();
    }
}
