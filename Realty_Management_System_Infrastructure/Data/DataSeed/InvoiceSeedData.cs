using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Infrastructure.Data.DataSeed
{
    public static class InvoiceSeedData
    {
        public static Invoice[] GetInvoices()
        {
            return
            [
                new Invoice
                {
                    Id = SeedIds.Invoice1,
                    IssueDate = DateTime.UtcNow.AddDays(-10),
                    DueDate = DateTime.UtcNow.AddDays(20),
                    Amount = 1500.00m,
                    ContractId = SeedIds.Contract1,
                    InvoiceStatusId = SeedIds.InvoiceStatusPending
                },
                new Invoice
                {
                    Id = SeedIds.Invoice2,
                    IssueDate = DateTime.UtcNow.AddDays(-20),
                    DueDate = DateTime.UtcNow.AddDays(10),
                    Amount = 2500.00m,
                    ContractId = SeedIds.Contract2,
                    InvoiceStatusId = SeedIds.InvoiceStatusPaid
                },
                new Invoice
                {
                    Id = SeedIds.Invoice3,
                    IssueDate = DateTime.UtcNow.AddDays(-30),
                    DueDate = DateTime.UtcNow.AddDays(-5),
                    Amount = 3200.00m,
                    ContractId = SeedIds.Contract3,
                    InvoiceStatusId = SeedIds.InvoiceStatusOverdue
                },
                new Invoice
                {
                    Id = SeedIds.Invoice4,
                    IssueDate = DateTime.UtcNow.AddDays(-15),
                    DueDate = DateTime.UtcNow.AddDays(15),
                    Amount = 4100.00m,
                    ContractId = SeedIds.Contract4,
                    InvoiceStatusId = SeedIds.InvoiceStatusCancelled
                },
                new Invoice
                {
                    Id = SeedIds.Invoice5,
                    IssueDate = DateTime.UtcNow.AddDays(-5),
                    DueDate = DateTime.UtcNow.AddDays(25),
                    Amount = 5000.00m,
                    ContractId = SeedIds.Contract5,
                    InvoiceStatusId = SeedIds.InvoiceStatusRefunded
                }
            ];
        }
    }
}
