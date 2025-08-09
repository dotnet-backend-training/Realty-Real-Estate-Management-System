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

            /*
            * PropertyReview -> User 
            * PropertyReview belongs to one User
            * User can write many PropertyReview
            */
            builder.HasOne(propertyReview => propertyReview.User)
                .WithMany(user => user.PropertyReviews)
                .HasForeignKey(propertyReview => propertyReview.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            /*
            * PropertyReview -> Contract
            * Each PropertyReview is linked to exactly one Contract.
            * One Contract can have zero or one PropertyReview.
            */
            builder.HasOne(propertyReview => propertyReview.Contract)
                .WithOne(contract => contract.PropertyReview)
                .HasForeignKey<PropertyReview>(propertyReview => propertyReview.ContractId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
