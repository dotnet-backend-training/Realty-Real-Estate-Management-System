using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Infrastructure.Persistence.Configurations
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(city => city.Id);

            builder.Property(city => city.Name)
                .IsRequired().HasMaxLength(100);

            builder.Property(city => city.Latitude)
                .IsRequired(false)
                .HasColumnType("decimal(9,6)");

            builder.Property(city => city.Longitude)
                .IsRequired(false)
                .HasColumnType("decimal(9,6)");

            /*
             * City -> Country
             * Each City belongs to one Country.
             * Each Country has many Cities
             */
            builder.HasOne(city => city.Country)
                .WithMany(country => country.Cities)
                .HasForeignKey(city => city.CountryId)
                .OnDelete(DeleteBehavior.Restrict);
            /*
             * City -> Zone
             * Each City has many Zones.
             * Each Zone belongs to one City.
             */
            builder.HasMany(city => city.Zones)
                .WithOne(zone => zone.City)
                .HasForeignKey(zone => zone.CityId)
                .OnDelete(DeleteBehavior.Restrict);
            /*
            * City -> Property
            * Each City has many Properties
            * Each Property belongs to one City.
            */
            builder.HasMany(city => city.Properties)
                .WithOne(property => property.City)
                .HasForeignKey(property => property.CityId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
