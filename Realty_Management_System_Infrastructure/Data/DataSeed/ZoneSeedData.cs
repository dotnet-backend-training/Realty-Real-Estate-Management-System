using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Infrastructure.Data.DataSeed
{
    public static class ZoneSeedData
    {
        public static Zone[] GetZones()
        {
            return
            [
                new Zone
                {
                    Id = SeedIds.Zone1,
                    Name = "Old City",
                    CityId = SeedIds.City1,
                    CountryId = SeedIds.Country1,
                    PostalCode = "NBL-001",
                    Latitude = 32.2215m,
                    Longitude = 35.2540m
                },
                new Zone
                {
                    Id = SeedIds.Zone2,
                    Name = "Balata",
                    CityId = SeedIds.City1,
                    CountryId = SeedIds.Country1,
                    PostalCode = "NBL-002",
                    Latitude = 32.2250m,
                    Longitude = 35.2590m
                },
                new Zone
                {
                    Id = SeedIds.Zone3,
                    Name = "Rafidia",
                    CityId = SeedIds.City1,
                    CountryId = SeedIds.Country1,
                    PostalCode = "NBL-003",
                    Latitude = 32.2160m,
                    Longitude = 35.2470m
                },
                new Zone
                {
                    Id = SeedIds.Zone4,
                    Name = "Askar",
                    CityId = SeedIds.City1,
                    CountryId = SeedIds.Country1,
                    PostalCode = "NBL-004",
                    Latitude = 32.2300m,
                    Longitude = 35.2600m
                },
                new Zone
                {
                    Id = SeedIds.Zone5,
                    Name = "Beit Furiq",
                    CityId = SeedIds.City1,
                    CountryId = SeedIds.Country1,
                    PostalCode = "NBL-005",
                    Latitude = 32.2400m,
                    Longitude = 35.2700m
                },
            ];
        }
    }
}
