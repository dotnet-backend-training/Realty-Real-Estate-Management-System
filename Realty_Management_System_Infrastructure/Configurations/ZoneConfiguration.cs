using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Infrastructure.Configurations
{
    public class ZoneConfiguration : IEntityTypeConfiguration<Zone>
    {
        public void Configure(EntityTypeBuilder<Zone> builder)
        {
            builder.HasKey(zone => zone.Id);

            builder.Property(zone => zone.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(zone => zone.PostalCode)
                .IsRequired(false)
                .HasMaxLength(20);

            builder.Property(zone => zone.Latitude)
                .IsRequired(false)
                .HasColumnType("decimal(9,6)");

            builder.Property(zone => zone.Longitude)
                .IsRequired(false)
                .HasColumnType("decimal(9,6)");
            /*
             * Zone -> City
             * Each Zone belongs to one City.
             * Each City has many Zones
             */
            builder.HasOne(zone => zone.City)
                .WithMany(city => city.Zones)
                .HasForeignKey(zone => zone.CityId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
