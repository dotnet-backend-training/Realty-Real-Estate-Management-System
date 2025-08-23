using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Realty_Management_System_Domain.Entities;
using Realty_Management_System_Infrastructure.Data.DataSeed;

namespace Realty_Management_System_Infrastructure.Persistence.Configurations
{
    public class PropertyAmenityConfiguration : IEntityTypeConfiguration<PropertyAmenity>
    {
        public void Configure(EntityTypeBuilder<PropertyAmenity> builder)
        {
            builder.HasKey(propertyAmenity =>
                new
                {
                    propertyAmenity.PropertyId,
                    propertyAmenity.AmenityId
                }
            );

            /*
            * PropertyAmenity -> Property
            * PropertyAmenity belongs to one Property.
            * Property has many PropertyAmenities.
            */
            builder.HasOne(propertyAmenity => propertyAmenity.Property)
                .WithMany(property => property.PropertyAmenities)
                .HasForeignKey(propertyAmenity => propertyAmenity.PropertyId)
                .OnDelete(DeleteBehavior.Restrict);

            /*
            * PropertyAmenity -> Amenity
            * PropertyAmenity belongs to one Amenity.
            * Amenity has many PropertyAmenities.
            */
            builder.HasOne(propertyAmenity => propertyAmenity.Amenity)
                .WithMany(amenity => amenity.PropertyAmenities)
                .HasForeignKey(propertyAmenity => propertyAmenity.AmenityId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(PropertyAmenitySeedData.GetPropertyAmenities());
        }
    }
}
