using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Infrastructure.Data.DataSeed
{
    public static class ContractSeedData
    {
        public static Contract[] GetContracts()
        {
            return
            [
                new Contract
                {
                    Id = SeedIds.Contract1,
                    StartDate = new DateTime(2025, 1, 1),
                    EndDate = new DateTime(2025, 12, 31),
                    TotalAmount = 12000m,
                    PropertyId = SeedIds.Property1,
                    ContractTypeId = SeedIds.ContractType1,
                    OwnerId = SeedIds.User1,
                    CustomerId = SeedIds.User2,
                    PaymentFrequencyId = SeedIds.PaymentFrequencyMonthly,
                    PropertyReviewId = null
                },
                new Contract
                {
                    Id = SeedIds.Contract2,
                    StartDate = new DateTime(2025, 2, 1),
                    EndDate = new DateTime(2025, 8, 31),
                    TotalAmount = 6000m,
                    PropertyId = SeedIds.Property2,
                    ContractTypeId = SeedIds.ContractType2,
                    OwnerId = SeedIds.User1,
                    CustomerId = SeedIds.User3,
                    PaymentFrequencyId = SeedIds.PaymentFrequencyQuarterly,
                    PropertyReviewId = null
                },
                new Contract
                {
                    Id = SeedIds.Contract3,
                    StartDate = new DateTime(2025, 3, 1),
                    EndDate = new DateTime(2025, 9, 30),
                    TotalAmount = 9000m,
                    PropertyId = SeedIds.Property3,
                    ContractTypeId = SeedIds.ContractType3,
                    OwnerId = SeedIds.User2,
                    CustomerId = SeedIds.User1,
                    PaymentFrequencyId = SeedIds.PaymentFrequencyAnnually,
                    PropertyReviewId = null
                },
                new Contract
                {
                    Id = SeedIds.Contract4,
                    StartDate = new DateTime(2025, 4, 1),
                    EndDate = new DateTime(2025, 10, 31),
                    TotalAmount = 15000m,
                    PropertyId = SeedIds.Property4,
                    ContractTypeId = SeedIds.ContractType1,
                    OwnerId = SeedIds.User3,
                    CustomerId = SeedIds.User2,
                    PaymentFrequencyId = SeedIds.PaymentFrequencyMonthly,
                    PropertyReviewId = null
                },
                new Contract
                {
                    Id = SeedIds.Contract5,
                    StartDate = new DateTime(2025, 5, 1),
                    EndDate = new DateTime(2025, 11, 30),
                    TotalAmount = 7500m,
                    PropertyId = SeedIds.Property5,
                    ContractTypeId = SeedIds.ContractType2,
                    OwnerId = SeedIds.User2,
                    CustomerId = SeedIds.User3,
                    PaymentFrequencyId = SeedIds.PaymentFrequencyBiWeekly,
                    PropertyReviewId = null
                }
            ];
        }
    }
}
