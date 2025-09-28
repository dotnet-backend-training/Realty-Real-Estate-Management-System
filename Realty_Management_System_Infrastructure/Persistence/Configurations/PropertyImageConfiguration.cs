using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Realty_Management_System_Domain.Entities;
using Realty_Management_System_Infrastructure.Data.DataSeed;

namespace Realty_Management_System_Infrastructure.Persistence.Configurations
{
    internal class PropertyImageConfiguration : IEntityTypeConfiguration<PropertyImage>
    {
        public void Configure(EntityTypeBuilder<PropertyImage> builder)
        {
            builder.HasKey(propertyImage => propertyImage.Id);

            builder.Property(propertyImage => propertyImage.Url)
                .IsRequired()
                .HasMaxLength(2048);

            builder.Property(propertyImage => propertyImage.AltText)
                .IsRequired(false)
                .HasMaxLength(255);
            /*
            * PropertyImage -> Property
            * Each PropertyImage belongs to one Property
            * One Property has many PropertyImages
            */
            builder.HasOne(propertyImage => propertyImage.Property)
                .WithMany(property => property.PropertyImages)
                .HasForeignKey(propertyImage => propertyImage.PropertyId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(PropertyImageSeedData.GetPropertyImages());
        }
    }
}
