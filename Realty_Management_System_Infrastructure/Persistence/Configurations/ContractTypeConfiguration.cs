using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Realty_Management_System_Domain.Entities;
using Realty_Management_System_Infrastructure.Data.DataSeed;

namespace Realty_Management_System_Infrastructure.Persistence.Configurations
{
    public class ContractTypeConfiguration : IEntityTypeConfiguration<ContractType>
    {
        public void Configure(EntityTypeBuilder<ContractType> builder)
        {
            builder.HasKey(contractType => contractType.Id);

            builder.Property(contractType => contractType.Name)
                .IsRequired()
                .HasMaxLength(100);

            /*
            * ContractType -> Contract
            * ContractType has many Contracts
            * Contract belongs to one ContractType
            */
            builder.HasMany(contractType => contractType.Contracts)
                .WithOne(contract => contract.ContractType)
                .HasForeignKey(contract => contract.ContractTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(ContractTypeSeedData.GetContractTypes());
        }
    }
}
