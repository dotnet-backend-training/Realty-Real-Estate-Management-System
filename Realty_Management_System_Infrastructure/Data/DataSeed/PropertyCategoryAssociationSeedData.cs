using Realty_Management_System_Domain.Entities;

namespace Realty_Management_System_Infrastructure.Data.DataSeed
{
    public static class PropertyCategoryAssociationSeedData
    {
        public static PropertyCategoryAssociation[] GetPropertyCategoryAssociations()
        {
            return
            [
                new PropertyCategoryAssociation
                {
                    PropertyId = SeedIds.Property1,
                    PropertyCategoryId = SeedIds.PropertyCategoryApartment
                },
                new PropertyCategoryAssociation
                {
                    PropertyId = SeedIds.Property2,
                    PropertyCategoryId = SeedIds.PropertyCategoryVilla
                },
                new PropertyCategoryAssociation
                {
                    PropertyId = SeedIds.Property3,
                    PropertyCategoryId = SeedIds.PropertyCategoryTownhouse
                },
                new PropertyCategoryAssociation
                {
                    PropertyId = SeedIds.Property4,
                    PropertyCategoryId = SeedIds.PropertyCategoryOffice
                },
                new PropertyCategoryAssociation
                {
                    PropertyId = SeedIds.Property5,
                    PropertyCategoryId = SeedIds.PropertyCategoryRetail
                }
            ];
        }
    }
}
