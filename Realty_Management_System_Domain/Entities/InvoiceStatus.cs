namespace Realty_Management_System_Domain.Entities
{
    public class InvoiceStatus : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public ICollection<Invoice> Invoices { get; set; } = new HashSet<Invoice>();
    }
}
