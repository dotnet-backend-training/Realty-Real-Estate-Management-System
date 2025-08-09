using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Infrastructure.Persistence.Configurations
{
    public class ContractConfiguration : IEntityTypeConfiguration<Contract>
    {
        public void Configure(EntityTypeBuilder<Contract> builder)
        {
            builder.HasKey(
                contract =>
                    new
                    {
                        contract.OwnerId,
                        contract.CustomerId,
                        contract.PropertyId,
                        contract.ContractTypeId,
                        contract.StartDate,
                    }
            );

            builder.Property(contract => contract.StartDate)
                .IsRequired();

            builder.Property(contract => contract.EndDate)
                .IsRequired();

            /*
            * Contract -> Property
            * Contract belongs to one Property
            * Property has many Contracts
            */
            builder.HasOne(contract => contract.Property)
                .WithMany(property => property.Contracts)
                .HasForeignKey(contract => contract.PropertyId)
                .OnDelete(DeleteBehavior.Restrict);

            /*
            * Contract -> ContractType
            * Contract belongs to one ContractType
            * ContractType has many Contracts
            */
            builder.HasOne(contract => contract.ContractType)
                .WithMany(contractType => contractType.Contracts)
                .HasForeignKey(contract => contract.ContractTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            /*
            * Contract -> User
            * Each Contract is owned by one user 
            * One User can own many Contract
            */
            builder.HasOne(contract => contract.Owner)
                .WithMany(user => user.OwnedContracts)
                .HasForeignKey(contract => contract.OwnerId)
                .OnDelete(DeleteBehavior.Restrict);

            /*
            * Contract -> User
            * Each CustomerContract is owned by one User 
            * One User can own many CustomerContract
            */
            builder.HasOne(contract => contract.Customer)
                .WithMany(user => user.CustomerContracts)
                .HasForeignKey(contract => contract.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            /*
            * Contract -> PaymentFrequency
            * One Contract has one PaymentFrequency
            * One PaymentFrequency can be used by many Contracts
            */
            builder.HasOne(contract => contract.PaymentFrequency)
                .WithMany(paymentFrequency => paymentFrequency.Contracts)
                .HasForeignKey(contract => contract.PaymentFrequencyId)
                .OnDelete(DeleteBehavior.Restrict);

            /*
            * Contract -> Invoice 
            * One Contract can have many Invoices
            * One Invoice belongs to one Contract
            */
            builder.HasMany(contract => contract.Invoices)
                .WithOne(invoice => invoice.Contract)
                .HasForeignKey(invoice => invoice.ContractId)
                .OnDelete(DeleteBehavior.Restrict);

            /*
            * Contract -> PropertyReview
            * One Contract can have zero or one PropertyReview.
            * Each PropertyReview is linked to exactly one Contract.
            */
            builder.HasOne(contract => contract.PropertyReview)
                .WithOne(propertyReview => propertyReview.Contract)
                .HasForeignKey<Contract>(contract => contract.PropertyReviewId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
