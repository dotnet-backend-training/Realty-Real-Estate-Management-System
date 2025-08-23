using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Infrastructure.Data.DataSeed
{
    public static class PropertyFeatureAssociationSeedData
    {
        public static PropertyFeatureAssociation[] GetPropertyFeatureAssociations()
        {
            return
            [
                new PropertyFeatureAssociation
                {
                    PropertyId = SeedIds.Property1,
                    PropertyFeatureId = SeedIds.PropertyFeatureSwimmingPool
                },
                new PropertyFeatureAssociation
                {
                    PropertyId = SeedIds.Property2,
                    PropertyFeatureId = SeedIds.PropertyFeatureGym
                },
                new PropertyFeatureAssociation
                {
                    PropertyId = SeedIds.Property3,
                    PropertyFeatureId = SeedIds.PropertyFeatureBalcony
                },
                new PropertyFeatureAssociation
                {
                    PropertyId = SeedIds.Property4,
                    PropertyFeatureId = SeedIds.PropertyFeatureGarden
                },
                new PropertyFeatureAssociation
                {
                    PropertyId = SeedIds.Property5,
                    PropertyFeatureId = SeedIds.PropertyFeatureGarage
                }
            ];
        }
    }
}
