using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Realty_Management_System_Domain.Entities;
using Realty_Management_System_Infrastructure.Data.DataSeed;

namespace Realty_Management_System_Infrastructure.Persistence.Configurations
{
    public class TransactionStatusConfiguration : IEntityTypeConfiguration<TransactionStatus>
    {
        public void Configure(EntityTypeBuilder<TransactionStatus> builder)
        {
            builder.HasKey(transactionStatus => transactionStatus.Id);

            builder.Property(transactionStatus => transactionStatus.Name)
                .IsRequired()
                .HasMaxLength(100);

            /*
            * TransactionStatus -> Transaction
            * One TransactionStatus has many Transactions,
            * One Transaction has one TransactionStatus.
            */
            builder.HasMany(transactionStatus => transactionStatus.Transactions)
                .WithOne(transaction => transaction.TransactionStatus)
                .HasForeignKey(transaction => transaction.TransactionStatusId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(TransactionStatusSeedData.GetTransactionStatuses());
        }
    }
}
