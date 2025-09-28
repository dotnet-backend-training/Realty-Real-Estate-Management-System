using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Infrastructure.Data.DataSeed
{
    public static class NearbyPlaceSeedData
    {
        public static NearbyPlace[] GetNearbyPlaces()
        {
            return
            [
                new NearbyPlace
                {
                    NearbyPlaceTypeId = SeedIds.NearbyPlaceType1,
                    PropertyId = SeedIds.Property1,
                    Name = "Central Park",
                    DistanceInKm = 0.50
                },
                new NearbyPlace
                {
                    NearbyPlaceTypeId = SeedIds.NearbyPlaceType2,
                    PropertyId = SeedIds.Property1,
                    Name = "Metro Station",
                    DistanceInKm = 1.20
                },
                new NearbyPlace
                {
                    NearbyPlaceTypeId = SeedIds.NearbyPlaceType3,
                    PropertyId = SeedIds.Property2,
                    Name = "Shopping Mall",
                    DistanceInKm = 2.50
                },
                new NearbyPlace
                {
                    NearbyPlaceTypeId = SeedIds.NearbyPlaceType4,
                    PropertyId = SeedIds.Property3,
                    Name = "Hospital",
                    DistanceInKm = 1.80
                },
                new NearbyPlace
                {
                    NearbyPlaceTypeId = SeedIds.NearbyPlaceType5,
                    PropertyId = SeedIds.Property4,
                    Name = "School",
                    DistanceInKm = 0.80
                }
            ];
        }
    }
}
