using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Infrastructure.Persistence.Configurations
{
    public class NearbyPlaceConfiguration : IEntityTypeConfiguration<NearbyPlace>
    {
        public void Configure(EntityTypeBuilder<NearbyPlace> builder)
        {
            builder.HasKey(nearbyPlace =>
                new
                {
                    nearbyPlace.NearbyPlaceTypeId,
                    nearbyPlace.PropertyId
                }
            );

            builder.Property(nearbyPlace => nearbyPlace.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(nearbyPlace => nearbyPlace.DistanceInKm)
                .IsRequired()
                .HasPrecision(6, 2);


            /*
            * NearbyPlace -> NearbyPlaceType
            * NearbyPlace has one NearbyPlaceType
            * NearbyPlaceType has many NearbyPlaces
            */
            builder.HasOne(nearbyPlace => nearbyPlace.NearbyPlaceType)
                .WithMany(nearbyPlaceType => nearbyPlaceType.NearbyPlaces)
                .HasForeignKey(nearbyPlace => nearbyPlace.NearbyPlaceTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            /*
            * NearbyPlace -> Property
            * NearbyPlace belongs to one Property
            * Property has many NearbyPlaces
            */
            builder.HasOne(nearbyPlace => nearbyPlace.Property)
                .WithMany(property => property.NearbyPlaces)
                .HasForeignKey(nearbyPlace => nearbyPlace.PropertyId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
