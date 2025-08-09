using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Infrastructure.Persistence.Configurations
{
    public class PropertyReviewConfiguration : IEntityTypeConfiguration<PropertyReview>
    {
        public void Configure(EntityTypeBuilder<PropertyReview> builder)
        {
            builder.HasKey(propertyReview => propertyReview.Id);

            builder.Property(propertyReview => propertyReview.Comment)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(propertyReview => propertyReview.Rating)
                .IsRequired()
                .HasPrecision(3, 2);

            /*
            * PropertyReview -> Property 
            * PropertyReview belongs to one Property
            * Property has many PropertyReview
            */
            builder.HasOne(propertyReview => propertyReview.Property)
                .WithMany(property => property.PropertyReviews)
                .HasForeignKey(propertyReview => propertyReview.PropertyId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
