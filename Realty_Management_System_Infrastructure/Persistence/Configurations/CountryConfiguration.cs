using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Realty_Management_System_Domain.Entities;

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
        }
    }
}
