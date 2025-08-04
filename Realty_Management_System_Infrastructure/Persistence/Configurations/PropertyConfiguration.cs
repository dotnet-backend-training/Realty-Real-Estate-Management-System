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
        }
    }
}
