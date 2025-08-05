using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Infrastructure.Persistence.Configurations
{
    public class PropertyCategoryAssociationConfiguration : IEntityTypeConfiguration<PropertyCategoryAssociation>
    {
        public void Configure(EntityTypeBuilder<PropertyCategoryAssociation> builder)
        {
            builder.HasKey(propertyCategoryAssociation =>
                new
                {
                    propertyCategoryAssociation.PropertyId,
                    propertyCategoryAssociation.PropertyCategoryId
                }
            );

            /*
            * PropertyCategoryAssociation -> Property
            * One PropertyCategoryAssociation belongs to one Property.
            * One Property has many PropertyCategoryAssociation records.
            */
            builder.HasOne(propertyCategoryAssociation => propertyCategoryAssociation.Property)
                .WithMany(property => property.PropertyCategoryAssociations)
                .HasForeignKey(propertyCategoryAssociation => propertyCategoryAssociation.PropertyId)
                .OnDelete(DeleteBehavior.Restrict);

            /*
            * PropertyCategoryAssociation -> PropertyCategory 
            * One PropertyCategoryAssociation belongs to one PropertyCategory.
            * One PropertyCategory has many PropertyCategoryAssociation records.
            */
            builder.HasOne(propertyCategoryAssociation => propertyCategoryAssociation.PropertyCategory)
                .WithMany(propertyCategory => propertyCategory.PropertyCategoryAssociations)
                .HasForeignKey(propertyCategoryAssociation => propertyCategoryAssociation.PropertyCategoryId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
