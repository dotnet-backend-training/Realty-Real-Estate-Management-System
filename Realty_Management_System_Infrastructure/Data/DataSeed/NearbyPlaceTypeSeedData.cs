using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Infrastructure.Data.DataSeed
{
    public static class NearbyPlaceTypeSeedData
    {
        public static NearbyPlaceType[] GetNearbyPlaceTypes()
        {
            return
            [
                new NearbyPlaceType
                {
                    Id = SeedIds.NearbyPlaceType1,
                    Name = "School"
                },
                new NearbyPlaceType
                {
                    Id = SeedIds.NearbyPlaceType2,
                    Name = "Hospital"
                },
                new NearbyPlaceType
                {
                    Id = SeedIds.NearbyPlaceType3,
                    Name = "Shopping Center"
                },
                new NearbyPlaceType
                {
                    Id = SeedIds.NearbyPlaceType4,
                    Name = "Park"
                },
                new NearbyPlaceType
                {
                    Id = SeedIds.NearbyPlaceType5,
                    Name = "Restaurant"
                }
            ];
        }
    }
}
