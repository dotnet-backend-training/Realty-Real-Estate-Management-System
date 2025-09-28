using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Infrastructure.Data.DataSeed
{
    public static class CitySeedData
    {
        public static City[] GetCities()
        {
            return
            [
                new City
                {
                    Id = SeedIds.City1,
                    Name = "Nablus",
                    Latitude = 32.2211m,
                    Longitude = 35.2544m,
                    CountryId = SeedIds.Country1
                },
                new City
                {
                    Id = SeedIds.City2,
                    Name = "Ramallah",
                    Latitude = 31.9076m,
                    Longitude = 35.2034m,
                    CountryId = SeedIds.Country1
                },
                new City
                {
                    Id = SeedIds.City3,
                    Name = "Hebron",
                    Latitude = 31.5326m,
                    Longitude = 35.0998m,
                    CountryId = SeedIds.Country1
                },
                new City
                {
                    Id = SeedIds.City4,
                    Name = "Bethlehem",
                    Latitude = 31.7054m,
                    Longitude = 35.2024m,
                    CountryId = SeedIds.Country1
                },
                new City
                {
                    Id = SeedIds.City5,
                    Name = "Jenin",
                    Latitude = 32.4576m,
                    Longitude = 35.2936m,
                    CountryId = SeedIds.Country1
                },
            ];
        }
    }
}
