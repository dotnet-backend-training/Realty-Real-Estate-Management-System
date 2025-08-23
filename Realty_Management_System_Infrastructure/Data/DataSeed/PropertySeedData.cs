using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Infrastructure.Data.DataSeed
{
    public static class PropertySeedData
    {
        public static Property[] GetProperties()
        {
            return
            [
                new Property
                {
                    Id = SeedIds.Property1,
                    Slug = "modern-apartment-nablus",
                    Description = "Modern 2-bedroom apartment in the city center",
                    NumberOfBedrooms = 2,
                    NumberOfBathrooms = 1,
                    NumberOfFloors = 1,
                    NumberOfGarage = 0,
                    Price = 55000m,
                    YearBuilt = new DateTime(2020, 1, 1),
                    PropertyStatusId = SeedIds.PropertyStatusAvailable,
                    CountryId = SeedIds.Country1,
                    CityId = SeedIds.City1,
                    ZoneId = SeedIds.Zone1,
                    PriceUnitId = SeedIds.PriceUnitTotalPrice,
                    OwnerId = SeedIds.User1
                },
                new Property
                {
                    Id = SeedIds.Property2,
                    Slug = "villa-rafidia",
                    Description = "Spacious villa with garden and garage",
                    NumberOfBedrooms = 4,
                    NumberOfBathrooms = 3,
                    NumberOfFloors = 2,
                    NumberOfGarage = 1,
                    Price = 250000m,
                    YearBuilt = new DateTime(2015, 1, 1),
                    PropertyStatusId = SeedIds.PropertyStatusAvailable,
                    CountryId = SeedIds.Country1,
                    CityId = SeedIds.City1,
                    ZoneId = SeedIds.Zone3,
                    PriceUnitId = SeedIds.PriceUnitTotalPrice,
                    OwnerId = SeedIds.User2
                },
                new Property
                {
                    Id = SeedIds.Property3,
                    Slug = "balata-house",
                    Description = "Affordable family home in Balata",
                    NumberOfBedrooms = 3,
                    NumberOfBathrooms = 2,
                    NumberOfFloors = 2,
                    NumberOfGarage = 0,
                    Price = 80000m,
                    YearBuilt = new DateTime(2010, 1, 1),
                    PropertyStatusId = SeedIds.PropertyStatusAvailable,
                    CountryId = SeedIds.Country1,
                    CityId = SeedIds.City1,
                    ZoneId = SeedIds.Zone2,
                    PriceUnitId = SeedIds.PriceUnitTotalPrice,
                    OwnerId = SeedIds.User3
                },
                new Property
                {
                    Id = SeedIds.Property4,
                    Slug = "askar-apartment",
                    Description = "Small 1-bedroom apartment near market",
                    NumberOfBedrooms = 1,
                    NumberOfBathrooms = 1,
                    NumberOfFloors = 1,
                    NumberOfGarage = 0,
                    Price = 30000m,
                    YearBuilt = new DateTime(2018, 1, 1),
                    PropertyStatusId = SeedIds.PropertyStatusRented,
                    CountryId = SeedIds.Country1,
                    CityId = SeedIds.City1,
                    ZoneId = SeedIds.Zone4,
                    PriceUnitId = SeedIds.PriceUnitTotalPrice,
                    OwnerId = SeedIds.User1
                },
                new Property
                {
                    Id = SeedIds.Property5,
                    Slug = "beit-furiq-land",
                    Description = "Empty land for investment",
                    NumberOfBedrooms = null,
                    NumberOfBathrooms = null,
                    NumberOfFloors = null,
                    NumberOfGarage = null,
                    Price = 150000m,
                    YearBuilt = new DateTime(2025, 1, 1),
                    PropertyStatusId = SeedIds.PropertyStatusAvailable,
                    CountryId = SeedIds.Country1,
                    CityId = SeedIds.City1,
                    ZoneId = SeedIds.Zone5,
                    PriceUnitId = SeedIds.PriceUnitTotalPrice,
                    OwnerId = SeedIds.User2
                }
            ];
        }
    }
}
