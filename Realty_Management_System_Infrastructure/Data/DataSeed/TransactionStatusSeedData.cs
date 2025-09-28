using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Infrastructure.Data.DataSeed
{
    public static class TransactionStatusSeedData
    {
        public static TransactionStatus[] GetTransactionStatuses()
        {
            return
            [
                new TransactionStatus
                {
                    Id = SeedIds.TransactionStatus1,
                    Name = "Pending"
                },
                new TransactionStatus
                {
                    Id = SeedIds.TransactionStatus2,
                    Name = "Completed"
                },
                new TransactionStatus
                {
                    Id = SeedIds.TransactionStatus3,
                    Name = "Cancelled"
                },
                new TransactionStatus
                {
                    Id = SeedIds.TransactionStatus4,
                    Name = "Failed"
                }
            ];
        }
    }
}
