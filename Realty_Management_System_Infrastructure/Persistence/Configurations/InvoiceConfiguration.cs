using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Realty_Management_System_Domain.Entities;
using Realty_Management_System_Infrastructure.Data.DataSeed;

namespace Realty_Management_System_Infrastructure.Persistence.Configurations
{
    public class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.Property(invoice => invoice.IssueDate)
                .IsRequired();

            builder.Property(invoice => invoice.DueDate)
                .IsRequired();

            builder.Property(invoice => invoice.Amount)
                .IsRequired()
                .HasPrecision(18, 2);

            /*
            * Invoice -> InvoiceStatus
            * One Invoice has one InvoiceStatus
            * One InvoiceStatus can be assigned to many Invoices
            */
            builder.HasOne(invoice => invoice.InvoiceStatus)
                .WithMany(invoiceStatus => invoiceStatus.Invoices)
                .HasForeignKey(invoice => invoice.InvoiceStatusId)
                .OnDelete(DeleteBehavior.Restrict);

            /*
            * Invoice -> Contract
            * One Invoice belongs to one Contract
            * One Contract can have many Invoices
            */
            builder.HasOne(invoice => invoice.Contract)
                .WithMany(contract => contract.Invoices)
                .HasForeignKey(invoice => invoice.ContractId)
                .OnDelete(DeleteBehavior.Restrict);

            /*
            * Invoice -> Transaction
            * One Invoice is used in many Transactions,
            * one Transaction uses one Invoice.
            */
            builder.HasMany(invoice => invoice.Transactions)
                .WithOne(transaction => transaction.Invoice)
                .HasForeignKey(transaction => transaction.InvoiceId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(InvoiceSeedData.GetInvoices());
        }
    }
}
