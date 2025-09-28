using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Infrastructure.Data.DataSeed
{
    public static class PropertyAmenitySeedData
    {
        public static PropertyAmenity[] GetPropertyAmenities()
        {
            return
            [
                new PropertyAmenity
                {
                    PropertyId = SeedIds.Property1,
                    AmenityId = SeedIds.Amenity1
                },
                new PropertyAmenity
                {
                    PropertyId = SeedIds.Property1,
                    AmenityId = SeedIds.Amenity2
                },
                new PropertyAmenity
                {
                    PropertyId = SeedIds.Property2,
                    AmenityId = SeedIds.Amenity3
                },
                new PropertyAmenity
                {
                    PropertyId = SeedIds.Property3,
                    AmenityId = SeedIds.Amenity4
                },
                new PropertyAmenity
                {
                    PropertyId = SeedIds.Property4,
                    AmenityId = SeedIds.Amenity5
                }
            ];
        }
    }
}
