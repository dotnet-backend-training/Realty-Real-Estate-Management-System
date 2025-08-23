using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Realty_Management_System_Domain.Entities;
using Realty_Management_System_Infrastructure.Data.DataSeed;

namespace Realty_Management_System_Infrastructure.Persistence.Configurations
{
    public class PropertyFeatureAssociationConfiguration : IEntityTypeConfiguration<PropertyFeatureAssociation>
    {
        public void Configure(EntityTypeBuilder<PropertyFeatureAssociation> builder)
        {
            builder.HasKey(propertyFeatureAssociation =>
                new
                {
                    propertyFeatureAssociation.PropertyId,
                    propertyFeatureAssociation.PropertyFeatureId
                }
            );

            /*
            * PropertyFeatureAssociation -> Property
            * A PropertyFeatureAssociation belongs to one Property.
            * A Property has many PropertyFeatureAssociation
            */
            builder.HasOne(propertyFeatureAssociation => propertyFeatureAssociation.Property)
                .WithMany(property => property.PropertyFeatureAssociations)
                .HasForeignKey(propertyFeatureAssociation => propertyFeatureAssociation.PropertyId)
                .OnDelete(DeleteBehavior.Restrict);

            /*
            * PropertyFeatureAssociation -> PropertyFeature
            * A PropertyFeatureAssociation belongs to one PropertyFeature.
            * A PropertyFeature has many PropertyFeatureAssociation
            */
            builder.HasOne(propertyFeatureAssociation => propertyFeatureAssociation.PropertyFeature)
                .WithMany(propertyFeature => propertyFeature.PropertyFeatureAssociations)
                .HasForeignKey(propertyFeatureAssociation => propertyFeatureAssociation.PropertyFeatureId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(PropertyFeatureAssociationSeedData.GetPropertyFeatureAssociations());
        }
    }
}
