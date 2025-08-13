namespace Realty_Management_System_Domain.Entities
{
    public class PaymentMethod : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public ICollection<Transaction> Transactions { get; set; } = new HashSet<Transaction>();
    }
}
