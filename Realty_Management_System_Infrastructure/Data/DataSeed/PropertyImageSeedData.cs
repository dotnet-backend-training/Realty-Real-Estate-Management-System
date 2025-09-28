using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Infrastructure.Data.DataSeed
{
    public static class PropertyImageSeedData
    {
        public static PropertyImage[] GetPropertyImages()
        {
            return
            [
                new PropertyImage
                {
                    Id = SeedIds.PropertyImage1,
                    PropertyId = SeedIds.Property1,
                    Url = "https://example.com/images/property1-front.jpg",
                    AltText = "Front view of the property"
                },
                new PropertyImage
                {
                    Id = SeedIds.PropertyImage2,
                    PropertyId = SeedIds.Property1,
                    Url = "https://example.com/images/property1-livingroom.jpg",
                    AltText = "Spacious living room"
                },
                new PropertyImage
                {
                    Id = SeedIds.PropertyImage3,
                    PropertyId = SeedIds.Property2,
                    Url = "https://example.com/images/property2-bedroom.jpg",
                    AltText = "Master bedroom"
                },
                new PropertyImage
                {
                    Id = SeedIds.PropertyImage4,
                    PropertyId = SeedIds.Property3,
                    Url = "https://example.com/images/property3-balcony.jpg",
                    AltText = "Balcony view"
                },
                new PropertyImage
                {
                    Id = SeedIds.PropertyImage5,
                    PropertyId = SeedIds.Property3,
                    Url = "https://example.com/images/property3-kitchen.jpg",
                    AltText = "Modern kitchen"
                }
            ];
        }
    }
}
