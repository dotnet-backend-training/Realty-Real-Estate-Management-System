using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Infrastructure.Data.DataSeed
{
    public static class CountrySeedData
    {
        public static Country[] GetCountries()
        {
            return
            [
                new ()
                {
                    Id = SeedIds.Country1,
                    Name = "Palestine",
                    ISOCode = "PS"
                }
            ];
        }
    }
}
