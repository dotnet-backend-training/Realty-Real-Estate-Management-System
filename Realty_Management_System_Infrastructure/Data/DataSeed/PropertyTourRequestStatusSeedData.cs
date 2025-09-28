using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Infrastructure.Data.DataSeed
{
    public static class PropertyTourRequestStatusSeedData
    {
        public static PropertyTourRequestStatus[] GetStatuses()
        {
            return
            [
                new PropertyTourRequestStatus
                {
                    Id = SeedIds.PropertyTourRequestStatusPending,
                    Name = "Pending"
                },
                new PropertyTourRequestStatus
                {
                    Id = SeedIds.PropertyTourRequestStatusConfirmed,
                    Name = "Confirmed"
                },
                new PropertyTourRequestStatus
                {
                    Id = SeedIds.PropertyTourRequestStatusRescheduled,
                    Name = "Rescheduled"
                },
                new PropertyTourRequestStatus
                {
                    Id = SeedIds.PropertyTourRequestStatusCompleted,
                    Name = "Completed"
                },
                new PropertyTourRequestStatus
                {
                    Id = SeedIds.PropertyTourRequestStatusCanceled,
                    Name = "Canceled"
                }
            ];
        }
    }
}
