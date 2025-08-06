using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Infrastructure.Persistence.Configurations
{
    public class AmenityConfiguration : IEntityTypeConfiguration<Amenity>
    {
        public void Configure(EntityTypeBuilder<Amenity> builder)
        {
            builder.HasKey(amenity => amenity.Id);

            /*
            * Amenity -> PropertyAmenity
            * Amenity has many PropertyAmenities.
            * PropertyAmenity belongs to one Amenity.
            */
            builder.HasMany(amenity => amenity.PropertyAmenities)
                .WithOne(propertyAmenity => propertyAmenity.Amenity)
                .HasForeignKey(propertyAmenity => propertyAmenity.AmenityId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
