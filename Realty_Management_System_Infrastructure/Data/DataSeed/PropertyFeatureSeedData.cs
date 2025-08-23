using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Infrastructure.Data.DataSeed
{
    public static class PropertyFeatureSeedData
    {
        public static PropertyFeature[] GetPropertyFeatures()
        {
            return
            [
                new PropertyFeature
                {
                    Id = SeedIds.PropertyFeatureSwimmingPool,
                    Name = "Swimming Pool"
                },
                new PropertyFeature
                {
                    Id = SeedIds.PropertyFeatureGym,
                    Name = "Gym"
                },
                new PropertyFeature
                {
                    Id = SeedIds.PropertyFeatureBalcony,
                    Name = "Balcony"
                },
                new PropertyFeature
                {
                    Id = SeedIds.PropertyFeatureGarden,
                    Name = "Garden"
                },
                new PropertyFeature
                {
                    Id = SeedIds.PropertyFeatureGarage,
                    Name = "Garage"
                }
            ];
        }
    }
}
