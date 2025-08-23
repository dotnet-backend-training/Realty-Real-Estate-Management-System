using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Infrastructure.Data.DataSeed
{
    public static class PropertyStatusSeedData
    {
        public static PropertyStatus[] GetPropertyStatuses()
        {
            return
            [
                new PropertyStatus
                {
                    Id = SeedIds.PropertyStatusAvailable,
                    Name = "Available"
                },
                new PropertyStatus
                {
                    Id = SeedIds.PropertyStatusPending,
                    Name = "Pending"
                },
                new PropertyStatus
                {
                    Id = SeedIds.PropertyStatusSold,
                    Name = "Sold"
                },
                new PropertyStatus
                {
                    Id = SeedIds.PropertyStatusRented,
                    Name = "Rented"
                },
                new PropertyStatus
                {
                    Id = SeedIds.PropertyStatusUnderMaintenance,
                    Name = "Under Maintenance"
                }
            ];
        }
    }
}
