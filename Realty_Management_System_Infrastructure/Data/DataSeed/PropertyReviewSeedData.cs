using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Infrastructure.Data.DataSeed
{
    public static class PropertyReviewSeedData
    {
        public static PropertyReview[] GetPropertyReviews()
        {
            return
            [
                new PropertyReview
                {
                    Id = SeedIds.PropertyReview1,
                    Comment = "Amazing property, well-maintained and spacious.",
                    Rating = 4.75m,
                    PropertyId = SeedIds.Property1,
                    UserId = SeedIds.User1,
                    ContractId = SeedIds.Contract1,
                    TransactionId = SeedIds.Transaction1
                },
                new PropertyReview
                {
                    Id = SeedIds.PropertyReview2,
                    Comment = "Beautiful villa with a lovely garden.",
                    Rating = 4.90m,
                    PropertyId = SeedIds.Property2,
                    UserId = SeedIds.User2,
                    ContractId = SeedIds.Contract2,
                    TransactionId = SeedIds.Transaction2
                },
                new PropertyReview
                {
                    Id = SeedIds.PropertyReview3,
                    Comment = "Cozy townhouse, perfect for a small family.",
                    Rating = 4.50m,
                    PropertyId = SeedIds.Property3,
                    UserId = SeedIds.User3,
                    ContractId = SeedIds.Contract3,
                    TransactionId = SeedIds.Transaction3
                },
                new PropertyReview
                {
                    Id = SeedIds.PropertyReview4,
                    Comment = "Spacious office space with excellent location.",
                    Rating = 4.30m,
                    PropertyId = SeedIds.Property4,
                    UserId = SeedIds.User1,
                    ContractId = SeedIds.Contract4,
                    TransactionId = SeedIds.Transaction4
                },
                new PropertyReview
                {
                    Id = SeedIds.PropertyReview5,
                    Comment = "Retail space in a busy area, good investment.",
                    Rating = 4.60m,
                    PropertyId = SeedIds.Property5,
                    UserId = SeedIds.User2,
                    ContractId = SeedIds.Contract5,
                    TransactionId = SeedIds.Transaction5
                }
            ];
        }
    }
}
