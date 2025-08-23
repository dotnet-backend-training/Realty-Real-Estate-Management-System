using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Realty_Management_System_Domain.Entities;
using Realty_Management_System_Infrastructure.Data.DataSeed;

namespace Realty_Management_System_Infrastructure.Persistence.Configurations
{
    public class PropertyCategoryConfiguration : IEntityTypeConfiguration<PropertyCategory>
    {
        public void Configure(EntityTypeBuilder<PropertyCategory> builder)
        {
            builder.HasKey(propertyCategory => propertyCategory.Id);

            builder.Property(propertyCategory => propertyCategory.Name)
                .IsRequired()
                .HasMaxLength(100);

            /*
            * PropertyCategory -> PropertyCategoryAssociation
            * One  PropertyCategory has many PropertyCategoryAssociation records.
            * One PropertyCategoryAssociation belongs to one PropertyCategory.
            */
            builder.HasMany(propertyCategory => propertyCategory.PropertyCategoryAssociations)
                .WithOne(propertyCategoryAssociation => propertyCategoryAssociation.PropertyCategory)
                .HasForeignKey(propertyCategoryAssociation => propertyCategoryAssociation.PropertyCategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(PropertyCategorySeedData.GetPropertyCategories());
        }
    }
}
