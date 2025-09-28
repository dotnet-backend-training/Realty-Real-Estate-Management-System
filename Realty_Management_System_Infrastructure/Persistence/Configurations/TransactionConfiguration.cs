using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Realty_Management_System_Domain.Entities;
using Realty_Management_System_Infrastructure.Data.DataSeed;

namespace Realty_Management_System_Infrastructure.Persistence.Configurations
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {

            builder.HasKey(transaction => transaction.Id);

            builder.Property(transaction => transaction.AmountPaid)
                .IsRequired()
                .HasPrecision(18, 2);

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

            /*
            * Transaction -> TransactionStatus
            * One Transaction has one TransactionStatus.
            * One TransactionStatus has many Transactions,
            */
            builder.HasOne(transaction => transaction.TransactionStatus)
                .WithMany(transactionStatus => transactionStatus.Transactions)
                .HasForeignKey(transaction => transaction.TransactionStatusId)
                .OnDelete(DeleteBehavior.Restrict);

            /*
            * Transaction -> PropertyReview
            * One Transaction can have zero or one PropertyReview.
            * Each PropertyReview is linked to exactly one Transaction.
            */
            builder.HasOne(transaction => transaction.PropertyReview)
                .WithOne(propertyReview => propertyReview.Transaction)
                .HasForeignKey<Transaction>(transaction => transaction.PropertyReviewId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(TransactionSeedData.GetTransactions());
        }
    }
}
