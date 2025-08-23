using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Infrastructure.Data.DataSeed
{
    public static class UserSeedData
    {
        public static User[] GetUsers()
        {
            return
            [
                new User
                {
                    Id = SeedIds.User1,
                    FirstName = "Diaa",
                    LastName = "Sharqawi",
                    Email = "diaa@example.com",
                    UserName = "diaa.sharqawi",
                    CountryId = SeedIds.Country1,
                    CityId = SeedIds.City1,
                    ZoneId = SeedIds.Zone1
                },
                new User
                {
                    Id = SeedIds.User2,
                    FirstName = "Sara",
                    LastName = "AbuBakr",
                    Email = "sara@example.com",
                    UserName = "sara.abubakr",
                    CountryId = SeedIds.Country1,
                    CityId = SeedIds.City2,
                    ZoneId = SeedIds.Zone2
                },
                new User
                {
                    Id = SeedIds.User3,
                    FirstName = "Omar",
                    LastName = "Haddad",
                    Email = "omar@example.com",
                    UserName = "omar.haddad",
                    CountryId = SeedIds.Country1,
                    CityId = SeedIds.City3,
                    ZoneId = SeedIds.Zone3
                }
            ];
        }
    }
}
