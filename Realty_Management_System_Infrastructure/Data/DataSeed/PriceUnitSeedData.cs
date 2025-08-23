using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Infrastructure.Data.DataSeed
{
    public static class PriceUnitSeedData
    {
        public static PriceUnit[] GetPriceUnits()
        {
            return
            [
                new PriceUnit
                {
                    Id = SeedIds.PriceUnitPerSquareMeter,
                    Name = "Per Square Meter",
                    Abbreviation = "m²",
                    Symbol = "sqm",
                    ConversionFactor = 1.0m,
                    PriceUnitTypeId = SeedIds.PriceUnitTypePerSquareMeter
                },
                new PriceUnit
                {
                    Id = SeedIds.PriceUnitPerSquareFoot,
                    Name = "Per Square Foot",
                    Abbreviation = "ft²",
                    Symbol = "sqft",
                    ConversionFactor = 0.092903m,
                    PriceUnitTypeId = SeedIds.PriceUnitTypePerSquareFoot
                },
                new PriceUnit
                {
                    Id = SeedIds.PriceUnitPerMonth,
                    Name = "Per Month",
                    Abbreviation = "mo",
                    Symbol = "per month",
                    ConversionFactor = null,
                    PriceUnitTypeId = SeedIds.PriceUnitTypePerMonth
                },
                new PriceUnit
                {
                    Id = SeedIds.PriceUnitPerYear,
                    Name = "Per Year",
                    Abbreviation = "yr",
                    Symbol = "per year",
                    ConversionFactor = null,
                    PriceUnitTypeId = SeedIds.PriceUnitTypePerYear
                },
                new PriceUnit
                {
                    Id = SeedIds.PriceUnitTotalPrice,
                    Name = "Total Price",
                    Abbreviation = "total",
                    Symbol = "total",
                    ConversionFactor = null,
                    PriceUnitTypeId = SeedIds.PriceUnitTypeTotalPrice
                }
            ];
        }
    }
}
