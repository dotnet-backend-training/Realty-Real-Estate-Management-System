using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Infrastructure.Persistence.Configurations
{
    public class PaymentMethodConfiguration : IEntityTypeConfiguration<PaymentMethod>
    {
        public void Configure(EntityTypeBuilder<PaymentMethod> builder)
        {
            builder.HasKey(paymentMethod => paymentMethod.Id);

            /*
             * PaymentMethod -> Transaction 
             * One PaymentMethod is used in many Transactions,
             * one Transaction uses one PaymentMethod.
             */
            builder.HasMany(paymentMethod => paymentMethod.Transactions)
                .WithOne(transaction => transaction.PaymentMethod)
                .HasForeignKey(transaction => transaction.PaymentMethodId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
