using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Infrastructure.Persistence.Configurations
{
    public class PropertyFeatureConfiguration : IEntityTypeConfiguration<PropertyFeature>
    {
        public void Configure(EntityTypeBuilder<PropertyFeature> builder)
        {
            builder.HasKey(propertyFeature => propertyFeature.Id);

            builder.Property(propertyFeature => propertyFeature.Name)
                .IsRequired()
                .HasMaxLength(100);

            /*
            * PropertyFeature -> PropertyFeatureAssociation
            * A PropertyFeature has many PropertyFeatureAssociation
            * A PropertyFeatureAssociation belongs to one PropertyFeature.
            */
            builder.HasMany(propertyFeature => propertyFeature.PropertyFeatureAssociations)
                .WithOne(propertyFeatureAssociation => propertyFeatureAssociation.PropertyFeature)
                .HasForeignKey(propertyFeatureAssociation => propertyFeatureAssociation.PropertyFeatureId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
