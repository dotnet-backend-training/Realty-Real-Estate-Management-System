using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Infrastructure.Persistence.Configurations
{
    public class PaymentFrequencyConfiguration : IEntityTypeConfiguration<PaymentFrequency>
    {
        public void Configure(EntityTypeBuilder<PaymentFrequency> builder)
        {
            builder.HasKey(paymentFrequency => paymentFrequency.Id);

            builder.Property(paymentFrequency => paymentFrequency.Name)
                .IsRequired()
                .HasMaxLength(100);

            /*
            * PaymentFrequency -> Contract
            * One PaymentFrequency can be used by many Contracts
            * One Contract has one PaymentFrequency
            */
            builder.HasMany(paymentFrequency => paymentFrequency.Contracts)
                .WithOne(contract => contract.PaymentFrequency)
                .HasForeignKey(contract => contract.PaymentFrequencyId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
