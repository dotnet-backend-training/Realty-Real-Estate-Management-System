using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Realty_Management_System_Domain.Entities;
using System.Diagnostics.Metrics;

namespace Realty_Management_System_Infrastructure.Persistence.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasKey(country => country.Id);

            builder.Property(country => country.Name)
                .IsRequired().HasMaxLength(100);

            builder.Property(country => country.ISOCode)
                .IsRequired(false)
                .HasMaxLength(5);

            /*
             * Country -> City
             * Each Country has many Cities.
             * Each City belongs to one Country.
             */
            builder.HasMany(country => country.Cities)
                .WithOne(city => city.Country)
                .HasForeignKey(city => city.CountryId)
                .OnDelete(DeleteBehavior.Restrict);

            /*
             * Country -> Zone
             * Each Country has many Zones.
             * Each Zone belongs to one Country.
             */
            builder.HasMany(country => country.Zones)
                .WithOne(zone => zone.Country)
                .HasForeignKey(zone => zone.CountryId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
