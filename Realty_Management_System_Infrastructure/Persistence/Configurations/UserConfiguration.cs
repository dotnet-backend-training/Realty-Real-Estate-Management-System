using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Realty_Management_System_Domain.Entities;

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

            builder.Property(user  => user.UserName)
                .IsRequired();

            /*
            * User -> Country
            * Each user belongs to one Country
            * A Country can have many Users
            */
            builder.HasOne(user => user.Country)
                .WithMany(country  => country.Users)
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
        }
    }
}
