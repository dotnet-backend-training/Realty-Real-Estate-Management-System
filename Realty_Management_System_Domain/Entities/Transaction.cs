namespace Realty_Management_System_Domain.Entities
{
    public class Transaction : BaseEntity
    {
        public DateTime TransactionDate { get; set; }
        public decimal AmountPaid { get; set; }
        public Guid InvoiceId { get; set; }
        public Invoice Invoice { get; set; } = default!;
        public Guid PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; } = default!;
        public Guid TransactionStatusId { get; set; }
        public TransactionStatus TransactionStatus { get; set; } = default!;
    }
}
