using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Infrastructure.Persistence.Configurations
{
    public class PropertyTourRequestStatusConfiguration : IEntityTypeConfiguration<PropertyTourRequestStatus>
    {
        public void Configure(EntityTypeBuilder<PropertyTourRequestStatus> builder)
        {
            builder.HasKey(tourRequestStatus => tourRequestStatus.Id);

            builder.Property(tourRequestStatus => tourRequestStatus.Name)
                .IsRequired()
                .HasMaxLength(100);

            /*
            * PropertyTourRequestStatus -> PropertyTourRequest
            * One PropertyTourRequestStatus has many PropertyTourRequest
            * Each PropertyTourRequest has one PropertyTourRequestStatus
            */
            builder.HasMany(propertyTourRequestStatus => propertyTourRequestStatus.PropertyTourRequests)
                .WithOne(propertyTourRequest => propertyTourRequest.PropertyTourRequestStatus)
                .HasForeignKey(propertyTourRequest => propertyTourRequest.PropertyTourRequestStatusId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
