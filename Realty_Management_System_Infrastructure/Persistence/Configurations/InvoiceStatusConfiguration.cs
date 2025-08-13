using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Infrastructure.Persistence.Configurations
{
    internal class InvoiceStatusConfiguration : IEntityTypeConfiguration<InvoiceStatus>
    {
        public void Configure(EntityTypeBuilder<InvoiceStatus> builder)
        {
            builder.HasKey(invoiceStatus => invoiceStatus.Id);

            builder.Property(invoiceStatus => invoiceStatus.Name)
                .IsRequired()
                .HasMaxLength(100);

            /*
            * InvoiceStatus -> Invoice
            * One InvoiceStatus can be assigned to many Invoices
            * One Invoice has one InvoiceStatus
            */
            builder.HasMany(invoiceStatus => invoiceStatus.Invoices)
                .WithOne(invoice => invoice.InvoiceStatus)
                .HasForeignKey(invoice => invoice.InvoiceStatusId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
