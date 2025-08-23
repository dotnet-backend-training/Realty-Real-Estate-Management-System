using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Realty_Management_System_Domain.Entities;
using Realty_Management_System_Infrastructure.Data.DataSeed;

namespace Realty_Management_System_Infrastructure.Persistence.Configurations
{
    public class PriceUnitTypeConfiguration : IEntityTypeConfiguration<PriceUnitType>
    {
        public void Configure(EntityTypeBuilder<PriceUnitType> builder)
        {
            builder.HasKey(priceUnitType => priceUnitType.Id);

            builder.Property(priceUnitType => priceUnitType.Name)
                .IsRequired()
                .HasMaxLength(100);

            /*
            * PriceUnitType -> PriceUnit
            * One PriceUnitType can have many PriceUnits.
            * Each PriceUnit belongs to exactly one PriceUnitType.
            */
            builder.HasMany(priceUnitType => priceUnitType.PriceUnits)
                .WithOne(priceUnit => priceUnit.PriceUnitType)
                .HasForeignKey(priceUnit => priceUnit.PriceUnitTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(PriceUnitTypeSeedData.GetPriceUnitTypes());
        }
    }
}
