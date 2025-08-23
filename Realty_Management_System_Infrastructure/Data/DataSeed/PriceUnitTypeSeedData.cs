using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Infrastructure.Data.DataSeed
{
    public static class PriceUnitTypeSeedData
    {
        public static PriceUnitType[] GetPriceUnitTypes()
        {
            return
            [
                new PriceUnitType
                {
                    Id = SeedIds.PriceUnitTypePerSquareMeter,
                    Name = "Per Square Meter"
                },
                new PriceUnitType
                {
                    Id = SeedIds.PriceUnitTypePerSquareFoot,
                    Name = "Per Square Foot"
                },
                new PriceUnitType
                {
                    Id = SeedIds.PriceUnitTypePerMonth,
                    Name = "Per Month"
                },
                new PriceUnitType
                {
                    Id = SeedIds.PriceUnitTypePerYear,
                    Name = "Per Year"
                },
                new PriceUnitType
                {
                    Id = SeedIds.PriceUnitTypeTotalPrice,
                    Name = "Total Price"
                }
            ];
        }
    }
}
