using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Realty_Management_System_Domain.Entities;
using Realty_Management_System_Infrastructure.Data.DataSeed;

namespace Realty_Management_System_Infrastructure.Persistence.Configurations
{
    internal class NearbyPlaceTypeConfiguration : IEntityTypeConfiguration<NearbyPlaceType>
    {
        public void Configure(EntityTypeBuilder<NearbyPlaceType> builder)
        {
            builder.HasKey(nearbyPlaceType => nearbyPlaceType.Id);

            builder.Property(nearbyPlaceType => nearbyPlaceType.Name)
                .IsRequired()
                .HasMaxLength(100);

            /*
            * NearbyPlaceType -> NearbyPlace
            * NearbyPlaceType has many NearbyPlaces
            * NearbyPlace has one NearbyPlaceType
            */
            builder.HasMany(nearbyPlaceType => nearbyPlaceType.NearbyPlaces)
                .WithOne(nearbyPlace => nearbyPlace.NearbyPlaceType)
                .HasForeignKey(nearbyPlace => nearbyPlace.NearbyPlaceTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(NearbyPlaceTypeSeedData.GetNearbyPlaceTypes());
        }
    }
}
