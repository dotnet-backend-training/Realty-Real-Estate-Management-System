namespace Realty_Management_System_Domain.Entities
{
    public class Invoice : BaseEntity
    {
        public DateTime IssueDate { get; set; }
        public DateTime DueDate { get; set; }
        public decimal Amount { get; set; }
        public Guid ContractId { get; set; }
        public Contract Contract { get; set; } = default!;
        public Guid InvoiceStatusId { get; set; }
        public InvoiceStatus InvoiceStatus { get; set; } = default!;
        public ICollection<Transaction> Transactions { get; set; } = new HashSet<Transaction>();
    }
}
