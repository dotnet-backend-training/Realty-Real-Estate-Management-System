using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Infrastructure.Data.DataSeed
{
    public static class InvoiceStatusSeedData
    {
        public static InvoiceStatus[] GetInvoiceStatuses()
        {
            return
            [
                new InvoiceStatus
                {
                    Id = SeedIds.InvoiceStatusPending,
                    Name = "Pending"
                },
                new InvoiceStatus
                {
                    Id = SeedIds.InvoiceStatusPaid,
                    Name = "Paid"
                },
                new InvoiceStatus
                {
                    Id = SeedIds.InvoiceStatusOverdue,
                    Name = "Overdue"
                },
                new InvoiceStatus
                {
                    Id = SeedIds.InvoiceStatusCancelled,
                    Name = "Cancelled"
                },
                new InvoiceStatus
                {
                    Id = SeedIds.InvoiceStatusRefunded,
                    Name = "Refunded"
                }
            ];
        }
    }
}
