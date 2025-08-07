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
                        contract.PropertyId,
                        contract.ContractTypeId
                    }
            );

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
        }
    }
}
