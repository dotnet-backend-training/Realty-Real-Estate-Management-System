using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Infrastructure.Persistence.Configurations
{
    public class PropertyStatusConfiguration : IEntityTypeConfiguration<PropertyStatus>
    {
        public void Configure(EntityTypeBuilder<PropertyStatus> builder)
        {
            builder.HasKey(propertyStatus => propertyStatus.Id);

            builder.Property(propertyStatus => propertyStatus.Name)
                .IsRequired()
                .HasMaxLength(100);

            /*
            * PropertyStatus -> Property
            * Each PropertyStatus can be assigned to many Properties.
            * Each property has one PropertyStatus.
            */
            builder.HasMany(propertyStatus => propertyStatus.Properties)
                .WithOne(property => property.PropertyStatus)
                .HasForeignKey(property => property.PropertyStatusId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
