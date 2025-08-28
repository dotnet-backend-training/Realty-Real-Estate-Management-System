using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Realty_Management_System_Infrastructure.Data.DataSeed;

namespace Realty_Management_System_Infrastructure.Persistence.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole<Guid>>
    {
        public void Configure(EntityTypeBuilder<IdentityRole<Guid>> builder)
        {
            builder.HasData(
                new IdentityRole<Guid>
                {
                    Id = SeedIds.RoleAdmin,
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                },
                new IdentityRole<Guid>
                {
                    Id = SeedIds.RolePropertyOwner,
                    Name = "PropertyOwner",
                    NormalizedName = "PROPERTYOWNER",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                },
                new IdentityRole<Guid>
                {
                    Id = SeedIds.RoleBuyerTenant,
                    Name = "BuyerTenant",
                    NormalizedName = "BUYERTENANT",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                }
            );
        }
    }
}
