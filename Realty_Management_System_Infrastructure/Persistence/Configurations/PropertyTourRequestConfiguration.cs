using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Infrastructure.Persistence.Configurations
{
    public class PropertyTourRequestConfiguration : IEntityTypeConfiguration<PropertyTourRequest>
    {
        public void Configure(EntityTypeBuilder<PropertyTourRequest> builder)
        {
            builder.HasKey(propertyTourRequest => propertyTourRequest.Id);

            builder.Property(propertyTourRequest => propertyTourRequest.PreferredDateTime)
                .IsRequired();

            /*
            * PropertyTourRequest -> PropertyTourRequestStatus
            * Each PropertyTourRequest has one PropertyTourRequestStatus
            * One PropertyTourRequestStatus has many PropertyTourRequest
            */
            builder.HasOne(propertyTourRequest => propertyTourRequest.PropertyTourRequestStatus)
                .WithMany(propertyTourRequestStatus => propertyTourRequestStatus.PropertyTourRequests)
                .HasForeignKey(propertyTourRequest => propertyTourRequest.PropertyTourRequestStatusId)
                .OnDelete(DeleteBehavior.Restrict);

            /*
            * PropertyTourRequest -> Property
            * PropertyTourRequest belongs to one Property
            * Property receives many PropertyTourRequests
            */
            builder.HasOne(propertyTourRequest => propertyTourRequest.Property)
                .WithMany(property => property.PropertyTourRequests)
                .HasForeignKey(propertyTourRequest => propertyTourRequest.PropertyId)
                .OnDelete(DeleteBehavior.Restrict);

            /*
            * PropertyTourRequest -> User 
            * Each PropertyTourRequest belongs to one User 
            * One User can request many PropertyTourRequest
            */
            builder.HasOne(propertyTourRequest => propertyTourRequest.User)
                .WithMany(user => user.PropertyTourRequests)
                .HasForeignKey(propertyTourRequest => propertyTourRequest.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
