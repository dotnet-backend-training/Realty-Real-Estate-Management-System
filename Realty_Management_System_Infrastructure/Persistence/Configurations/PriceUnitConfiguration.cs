using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Infrastructure.Persistence.Configurations
{
    public class PriceUnitConfiguration : IEntityTypeConfiguration<PriceUnit>
    {
        public void Configure(EntityTypeBuilder<PriceUnit> builder)
        {
            builder.HasKey(priceUnit => priceUnit.Id);

            builder.Property(priceUnit => priceUnit.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasIndex(priceUnit => priceUnit.Name).IsUnique();

            builder.Property(priceUnit => priceUnit.Abbreviation)
                .IsRequired()
                .HasMaxLength(20);

            builder.HasIndex(priceUnit => priceUnit.Abbreviation).IsUnique();

            builder.Property(priceUnit => priceUnit.Symbol)
                .IsRequired()
                .HasMaxLength(15);

            builder.Property(priceUnit => priceUnit.ConversionFactor)
                .IsRequired(false)
                .HasPrecision(18, 6);

            /*
            * PriceUnit -> PriceUnitType
            * Each PriceUnit belongs to exactly one PriceUnitType.
            * One PriceUnitType can have many PriceUnits.
            */
            builder.HasOne(priceUnit => priceUnit.PriceUnitType)
                .WithMany(priceUnitType => priceUnitType.PriceUnits)
                .HasForeignKey(priceUnit => priceUnit.PriceUnitTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            /*
            * PriceUnit -> Property
            * One PriceUnit can be used by many Properties.
            * Each Property has exactly one PriceUnit
            */
            builder.HasMany(priceUnit => priceUnit.Properties)
                .WithOne(property => property.PriceUnit)
                .HasForeignKey(property => property.PriceUnitId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
