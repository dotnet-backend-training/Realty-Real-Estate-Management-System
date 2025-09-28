using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Infrastructure.Data.DataSeed
{
    public static class PropertyCategorySeedData
    {
        public static PropertyCategory[] GetPropertyCategories()
        {
            return
            [
                new PropertyCategory
                {
                    Id = SeedIds.PropertyCategoryApartment,
                    Name = "Apartment"
                },
                new PropertyCategory
                {
                    Id = SeedIds.PropertyCategoryVilla,
                    Name = "Villa"
                },
                new PropertyCategory
                {
                    Id = SeedIds.PropertyCategoryTownhouse,
                    Name = "Townhouse"
                },
                new PropertyCategory
                {
                    Id = SeedIds.PropertyCategoryOffice,
                    Name = "Office"
                },
                new PropertyCategory
                {
                    Id = SeedIds.PropertyCategoryRetail,
                    Name = "Retail"
                }
            ];
        }
    }
}
