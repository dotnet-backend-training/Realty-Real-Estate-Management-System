using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Infrastructure.Data.DataSeed
{
    public static class AmenitySeedData
    {
        public static Amenity[] GetAmenities()
        {
            return
            [
                new Amenity
                {
                    Id = SeedIds.Amenity1,
                    Name = "Swimming Pool"
                },
                new Amenity
                {
                    Id = SeedIds.Amenity2,
                    Name = "Gym"
                },
                new Amenity
                {
                    Id = SeedIds.Amenity3,
                    Name = "Parking"
                },
                new Amenity
                {
                    Id = SeedIds.Amenity4,
                    Name = "Elevator"
                },
                new Amenity
                {
                    Id = SeedIds.Amenity5,
                    Name = "Garden"
                },
                new Amenity
                {
                    Id = SeedIds.Amenity6,
                    Name = "Security"
                }
            ];
        }
    }
}
