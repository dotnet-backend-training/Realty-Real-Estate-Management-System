using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Infrastructure.Persistence.Configurations
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            /*
             * Transaction -> PaymentMethod 
             * one Transaction uses one PaymentMethod.
             * One PaymentMethod is used in many Transactions,
             */
            builder.HasOne(transaction => transaction.PaymentMethod)
                .WithMany(paymentMethod => paymentMethod.Transactions)
                .HasForeignKey(transaction => transaction.PaymentMethodId)
                .OnDelete(DeleteBehavior.Restrict);

            /*
             * Transaction -> Invoice 
             * one Transaction uses one Invoice.
             * One Invoice is used in many Transactions,
             */
            builder.HasOne(transaction => transaction.Invoice)
                .WithMany(invoice => invoice.Transactions)
                .HasForeignKey(transaction => transaction.InvoiceId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
