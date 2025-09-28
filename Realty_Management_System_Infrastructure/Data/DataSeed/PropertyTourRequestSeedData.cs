using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Infrastructure.Data.DataSeed
{
    public static class PropertyTourRequestSeedData
    {
        public static PropertyTourRequest[] GetPropertyTourRequests()
        {
            return
            [
                    new PropertyTourRequest
                {
                    Id = SeedIds.PropertyTourRequest1,
                    PreferredDateTime = DateTime.UtcNow.AddDays(2).AddHours(10),
                    PropertyId = SeedIds.Property1,
                    UserId = SeedIds.User1,
                    PropertyTourRequestStatusId = SeedIds.PropertyTourRequestStatusPending
                },
                new PropertyTourRequest
                {
                    Id = SeedIds.PropertyTourRequest2,
                    PreferredDateTime = DateTime.UtcNow.AddDays(3).AddHours(14),
                    PropertyId = SeedIds.Property2,
                    UserId = SeedIds.User2,
                    PropertyTourRequestStatusId = SeedIds.PropertyTourRequestStatusConfirmed
                },
                new PropertyTourRequest
                {
                    Id = SeedIds.PropertyTourRequest3,
                    PreferredDateTime = DateTime.UtcNow.AddDays(1).AddHours(16),
                    PropertyId = SeedIds.Property3,
                    UserId = SeedIds.User3,
                    PropertyTourRequestStatusId = SeedIds.PropertyTourRequestStatusRescheduled
                },
                new PropertyTourRequest
                {
                    Id = SeedIds.PropertyTourRequest4,
                    PreferredDateTime = DateTime.UtcNow.AddDays(5).AddHours(11),
                    PropertyId = SeedIds.Property4,
                    UserId = SeedIds.User1,
                    PropertyTourRequestStatusId = SeedIds.PropertyTourRequestStatusCompleted
                },
                new PropertyTourRequest
                {
                    Id = SeedIds.PropertyTourRequest5,
                    PreferredDateTime = DateTime.UtcNow.AddDays(4).AddHours(9),
                    PropertyId = SeedIds.Property5,
                    UserId = SeedIds.User2,
                    PropertyTourRequestStatusId = SeedIds.PropertyTourRequestStatusCanceled
                }
            ];
        }
    }
}