using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Realty_Management_System_Domain.Entities;
using Realty_Management_System_Infrastructure.Data.DataSeed;

namespace Realty_Management_System_Infrastructure.Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(user => user.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(user => user.LastName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(user => user.Email)
                .IsRequired();

            builder.Property(user => user.UserName)
                .IsRequired();

            /*
            * User -> Country
            * Each user belongs to one Country
            * A Country can have many Users
            */
            builder.HasOne(user => user.Country)
                .WithMany(country => country.Users)
                .HasForeignKey(user => user.CountryId)
                .OnDelete(DeleteBehavior.Restrict);

            /*
            * User -> City
            * Each User belongs to one City
            * A City can have many Users
            */
            builder.HasOne(user => user.City)
                .WithMany(city => city.Users)
                .HasForeignKey(user => user.CityId)
                .OnDelete(DeleteBehavior.Restrict);

            /*
            * User -> Zone
            * Each User belongs to one Zone
            * A Zone can have many Users
            */
            builder.HasOne(user => user.Zone)
                .WithMany(zone => zone.Users)
                .HasForeignKey(user => user.ZoneId)
                .OnDelete(DeleteBehavior.Restrict);

            /*
            * User -> Property
            * One user can own many properties
            * Each Property is owned by one user 
            */
            builder.HasMany(user => user.Properties)
                .WithOne(property => property.Owner)
                .HasForeignKey(property => property.OwnerId)
                .OnDelete(DeleteBehavior.Restrict);

            /*
            * User -> Contract
            * One User can own many Contract
            * Each Contract is owned by one user 
            */
            builder.HasMany(user => user.OwnedContracts)
                .WithOne(contract => contract.Owner)
                .HasForeignKey(contract => contract.OwnerId)
                .OnDelete(DeleteBehavior.Restrict);

            /*
            * User -> Contract
            * One User can own many CustomerContract
            * Each CustomerContract is owned by one User 
            */
            builder.HasMany(user => user.CustomerContracts)
                .WithOne(contract => contract.Customer)
                .HasForeignKey(contract => contract.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            /*
            * User -> PropertyTourRequest
            * One User can request many PropertyTourRequest
            * Each PropertyTourRequest belongs to one User 
            */
            builder.HasMany(user => user.PropertyTourRequests)
                .WithOne(propertyTourRequest => propertyTourRequest.User)
                .HasForeignKey(propertyTourRequest => propertyTourRequest.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            /*
            * User -> PropertyReview 
            * User can write many PropertyReview
            * PropertyReview belongs to one User
            */
            builder.HasMany(user => user.PropertyReviews)
                .WithOne(propertyReview => propertyReview.User)
                .HasForeignKey(propertyReview => propertyReview.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(UserSeedData.GetUsers());
        }
    }
}
