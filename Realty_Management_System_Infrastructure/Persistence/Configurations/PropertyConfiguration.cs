using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Infrastructure.Persistence.Configurations
{
    public class PropertyConfiguration : IEntityTypeConfiguration<Property>
    {
        public void Configure(EntityTypeBuilder<Property> builder)
        {
            builder.HasKey(property => property.Id);

            builder.Property(property => property.Slug)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(property => property.Description)
                .IsRequired(false)
                .HasMaxLength(100);

            builder.Property(property => property.NumberOfBathrooms)
                .IsRequired(false);

            builder.Property(property => property.NumberOfFloors)
                .IsRequired(false);

            builder.Property(property => property.NumberOfBedrooms)
                .IsRequired(false);

            builder.Property(property => property.NumberOfGarage)
                .IsRequired(false);

            builder.Property(property => property.Price)
                .IsRequired()
                .HasPrecision(18, 2);

            builder.Property(property => property.YearBuilt)
                .IsRequired(false);

            /*
            * Property -> PropertyStatus
            * Each property has one PropertyStatus.
            * Each PropertyStatus can be assigned to many Properties.
            */
            builder.HasOne(property => property.PropertyStatus)
                .WithMany(propertyStatus => propertyStatus.Properties)
                .HasForeignKey(property => property.PropertyStatusId)
                .OnDelete(DeleteBehavior.Restrict);
            /*
            * Property -> Country
            * Each property belongs to one Country .
            * Each Country has many Properties
            */
            builder.HasOne(property => property.Country)
                .WithMany(country => country.Properties)
                .HasForeignKey(property => property.CountryId)
                .OnDelete(DeleteBehavior.Restrict);
            /*
            * Property -> City
            * Each property belongs to one City.
            * Each City has many Properties
            */
            builder.HasOne(property => property.City)
                .WithMany(city => city.Properties)
                .HasForeignKey(property => property.CityId)
                .OnDelete(DeleteBehavior.Restrict);

            /*
            * Property -> Zone
            * Each property belongs to one Zone.
            * Each Zone has many Properties
            */
            builder.HasOne(property => property.Zone)
                .WithMany(zone => zone.Properties)
                .HasForeignKey(property => property.ZoneId)
                .OnDelete(DeleteBehavior.Restrict);

            /*
            * Property -> PropertyImage
            * One Property has many PropertyImages
            * Each PropertyImage belongs to one Property 
            */
            builder.HasMany(property => property.PropertyImages)
                .WithOne(propertyImage => propertyImage.Property)
                .HasForeignKey(propertyImage => propertyImage.PropertyId)
                .OnDelete(DeleteBehavior.Restrict);

            /*
            * Property -> PriceUnit
            * Each Property has exactly one PriceUnit
            * One PriceUnit can be used by many Properties.
            */
            builder.HasOne(property => property.PriceUnit)
                .WithMany(priceUnit => priceUnit.Properties)
                .HasForeignKey(property => property.PriceUnitId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
