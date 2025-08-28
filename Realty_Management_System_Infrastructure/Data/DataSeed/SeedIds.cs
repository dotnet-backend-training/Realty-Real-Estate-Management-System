namespace Realty_Management_System_Infrastructure.Data.DataSeed
{
    public static class SeedIds
    {
        // Countries
        public static readonly Guid Country1 = Guid.Parse("00000001-0000-0000-0000-000000000001");
        public static readonly Guid Country2 = Guid.Parse("00000002-0000-0000-0000-000000000002");
        public static readonly Guid Country3 = Guid.Parse("00000003-0000-0000-0000-000000000003");
        public static readonly Guid Country4 = Guid.Parse("00000004-0000-0000-0000-000000000004");
        public static readonly Guid Country5 = Guid.Parse("00000005-0000-0000-0000-000000000005");

        // Cities
        public static readonly Guid City1 = Guid.Parse("00000101-0000-0000-0000-000000000101");
        public static readonly Guid City2 = Guid.Parse("00000102-0000-0000-0000-000000000102");
        public static readonly Guid City3 = Guid.Parse("00000103-0000-0000-0000-000000000103");
        public static readonly Guid City4 = Guid.Parse("00000104-0000-0000-0000-000000000104");
        public static readonly Guid City5 = Guid.Parse("00000105-0000-0000-0000-000000000105");

        // Zones
        public static readonly Guid Zone1 = Guid.Parse("00000201-0000-0000-0000-000000000201");
        public static readonly Guid Zone2 = Guid.Parse("00000202-0000-0000-0000-000000000202");
        public static readonly Guid Zone3 = Guid.Parse("00000203-0000-0000-0000-000000000203");
        public static readonly Guid Zone4 = Guid.Parse("00000204-0000-0000-0000-000000000204");
        public static readonly Guid Zone5 = Guid.Parse("00000205-0000-0000-0000-000000000205");

        // Users
        public static readonly Guid User1 = Guid.Parse("00000301-0000-0000-0000-000000000301");
        public static readonly Guid User2 = Guid.Parse("00000302-0000-0000-0000-000000000302");
        public static readonly Guid User3 = Guid.Parse("00000303-0000-0000-0000-000000000303");

        // Amenities
        public static readonly Guid Amenity1 = Guid.Parse("00000401-0000-0000-0000-000000000401");
        public static readonly Guid Amenity2 = Guid.Parse("00000402-0000-0000-0000-000000000402");
        public static readonly Guid Amenity3 = Guid.Parse("00000403-0000-0000-0000-000000000403");
        public static readonly Guid Amenity4 = Guid.Parse("00000404-0000-0000-0000-000000000404");
        public static readonly Guid Amenity5 = Guid.Parse("00000405-0000-0000-0000-000000000405");

        // Contract Types
        public static readonly Guid ContractType1 = Guid.Parse("00000501-0000-0000-0000-000000000501");
        public static readonly Guid ContractType2 = Guid.Parse("00000502-0000-0000-0000-000000000502");
        public static readonly Guid ContractType3 = Guid.Parse("00000503-0000-0000-0000-000000000503");

        // Contracts
        public static readonly Guid Contract1 = Guid.Parse("00000601-0000-0000-0000-000000000601");
        public static readonly Guid Contract2 = Guid.Parse("00000602-0000-0000-0000-000000000602");
        public static readonly Guid Contract3 = Guid.Parse("00000603-0000-0000-0000-000000000603");
        public static readonly Guid Contract4 = Guid.Parse("00000604-0000-0000-0000-000000000604");
        public static readonly Guid Contract5 = Guid.Parse("00000605-0000-0000-0000-000000000605");

        // Transaction Statuses
        public static readonly Guid TransactionStatus1 = Guid.Parse("00000701-0000-0000-0000-000000000701");
        public static readonly Guid TransactionStatus2 = Guid.Parse("00000702-0000-0000-0000-000000000702");
        public static readonly Guid TransactionStatus3 = Guid.Parse("00000703-0000-0000-0000-000000000703");
        public static readonly Guid TransactionStatus4 = Guid.Parse("00000704-0000-0000-0000-000000000704");

        // Nearby Place Types
        public static readonly Guid NearbyPlaceType1 = Guid.Parse("00000801-0000-0000-0000-000000000801");
        public static readonly Guid NearbyPlaceType2 = Guid.Parse("00000802-0000-0000-0000-000000000802");
        public static readonly Guid NearbyPlaceType3 = Guid.Parse("00000803-0000-0000-0000-000000000803");
        public static readonly Guid NearbyPlaceType4 = Guid.Parse("00000804-0000-0000-0000-000000000804");
        public static readonly Guid NearbyPlaceType5 = Guid.Parse("00000805-0000-0000-0000-000000000805");

        // Invoice Statuses
        public static readonly Guid InvoiceStatusPending = Guid.Parse("00000901-0000-0000-0000-000000000901");
        public static readonly Guid InvoiceStatusPaid = Guid.Parse("00000902-0000-0000-0000-000000000902");
        public static readonly Guid InvoiceStatusOverdue = Guid.Parse("00000903-0000-0000-0000-000000000903");
        public static readonly Guid InvoiceStatusCancelled = Guid.Parse("00000904-0000-0000-0000-000000000904");
        public static readonly Guid InvoiceStatusRefunded = Guid.Parse("00000905-0000-0000-0000-000000000905");

        // Payment Frequencies
        public static readonly Guid PaymentFrequencyMonthly = Guid.Parse("00001001-0000-0000-0000-000000001001");
        public static readonly Guid PaymentFrequencyQuarterly = Guid.Parse("00001002-0000-0000-0000-000000001002");
        public static readonly Guid PaymentFrequencyAnnually = Guid.Parse("00001003-0000-0000-0000-000000001003");
        public static readonly Guid PaymentFrequencyWeekly = Guid.Parse("00001004-0000-0000-0000-000000001004");
        public static readonly Guid PaymentFrequencyBiWeekly = Guid.Parse("00001005-0000-0000-0000-000000001005");

        // Payment Methods
        public static readonly Guid PaymentMethodCash = Guid.Parse("00001101-0000-0000-0000-000000001101");
        public static readonly Guid PaymentMethodCreditCard = Guid.Parse("00001102-0000-0000-0000-000000001102");
        public static readonly Guid PaymentMethodBankTransfer = Guid.Parse("00001103-0000-0000-0000-000000001103");
        public static readonly Guid PaymentMethodMobileWallet = Guid.Parse("00001104-0000-0000-0000-000000001104");
        public static readonly Guid PaymentMethodPayPal = Guid.Parse("00001105-0000-0000-0000-000000001105");

        // Property Tour Request Statuses
        public static readonly Guid PropertyTourRequestStatusPending = Guid.Parse("00001201-0000-0000-0000-000000001201");
        public static readonly Guid PropertyTourRequestStatusConfirmed = Guid.Parse("00001202-0000-0000-0000-000000001202");
        public static readonly Guid PropertyTourRequestStatusRescheduled = Guid.Parse("00001203-0000-0000-0000-000000001203");
        public static readonly Guid PropertyTourRequestStatusCompleted = Guid.Parse("00001204-0000-0000-0000-000000001204");
        public static readonly Guid PropertyTourRequestStatusCanceled = Guid.Parse("00001205-0000-0000-0000-000000001205");

        // Property Reviews
        public static readonly Guid PropertyReview1 = Guid.Parse("00002301-0000-0000-0000-000000002301");
        public static readonly Guid PropertyReview2 = Guid.Parse("00002302-0000-0000-0000-000000002302");
        public static readonly Guid PropertyReview3 = Guid.Parse("00002303-0000-0000-0000-000000002303");
        public static readonly Guid PropertyReview4 = Guid.Parse("00002304-0000-0000-0000-000000002304");
        public static readonly Guid PropertyReview5 = Guid.Parse("00002305-0000-0000-0000-000000002305");

        // Price Units
        public static readonly Guid PriceUnitPerSquareMeter = Guid.Parse("00002201-0000-0000-0000-000000002201");
        public static readonly Guid PriceUnitPerSquareFoot = Guid.Parse("00002202-0000-0000-0000-000000002202");
        public static readonly Guid PriceUnitPerMonth = Guid.Parse("00002203-0000-0000-0000-000000002203");
        public static readonly Guid PriceUnitPerYear = Guid.Parse("00002204-0000-0000-0000-000000002204");
        public static readonly Guid PriceUnitTotalPrice = Guid.Parse("00002205-0000-0000-0000-000000002205");

        // Price Unit Types
        public static readonly Guid PriceUnitTypePerSquareMeter = Guid.Parse("00001301-0000-0000-0000-000000001301");
        public static readonly Guid PriceUnitTypePerSquareFoot = Guid.Parse("00001302-0000-0000-0000-000000001302");
        public static readonly Guid PriceUnitTypePerMonth = Guid.Parse("00001303-0000-0000-0000-000000001303");
        public static readonly Guid PriceUnitTypePerYear = Guid.Parse("00001304-0000-0000-0000-000000001304");
        public static readonly Guid PriceUnitTypeTotalPrice = Guid.Parse("00001305-0000-0000-0000-000000001305");

        // Property Statuses
        public static readonly Guid PropertyStatusAvailable = Guid.Parse("00001401-0000-0000-0000-000000001401");
        public static readonly Guid PropertyStatusPending = Guid.Parse("00001402-0000-0000-0000-000000001402");
        public static readonly Guid PropertyStatusSold = Guid.Parse("00001403-0000-0000-0000-000000001403");
        public static readonly Guid PropertyStatusRented = Guid.Parse("00001404-0000-0000-0000-000000001404");
        public static readonly Guid PropertyStatusUnderMaintenance = Guid.Parse("00001405-0000-0000-0000-000000001405");

        // Property Features
        public static readonly Guid PropertyFeatureSwimmingPool = Guid.Parse("00001501-0000-0000-0000-000000001501");
        public static readonly Guid PropertyFeatureGym = Guid.Parse("00001502-0000-0000-0000-000000001502");
        public static readonly Guid PropertyFeatureBalcony = Guid.Parse("00001503-0000-0000-0000-000000001503");
        public static readonly Guid PropertyFeatureGarden = Guid.Parse("00001504-0000-0000-0000-000000001504");
        public static readonly Guid PropertyFeatureGarage = Guid.Parse("00001505-0000-0000-0000-000000001505");

        // Property Categories
        public static readonly Guid PropertyCategoryApartment = Guid.Parse("00001601-0000-0000-0000-000000001601");
        public static readonly Guid PropertyCategoryVilla = Guid.Parse("00001602-0000-0000-0000-000000001602");
        public static readonly Guid PropertyCategoryTownhouse = Guid.Parse("00001603-0000-0000-0000-000000001603");
        public static readonly Guid PropertyCategoryOffice = Guid.Parse("00001604-0000-0000-0000-000000001604");
        public static readonly Guid PropertyCategoryRetail = Guid.Parse("00001605-0000-0000-0000-000000001605");

        // Property Images
        public static readonly Guid PropertyImage1 = Guid.Parse("00001701-0000-0000-0000-000000001701");
        public static readonly Guid PropertyImage2 = Guid.Parse("00001702-0000-0000-0000-000000001702");
        public static readonly Guid PropertyImage3 = Guid.Parse("00001703-0000-0000-0000-000000001703");
        public static readonly Guid PropertyImage4 = Guid.Parse("00001704-0000-0000-0000-000000001704");
        public static readonly Guid PropertyImage5 = Guid.Parse("00001705-0000-0000-0000-000000001705");

        // Properties
        public static readonly Guid Property1 = Guid.Parse("00001801-0000-0000-0000-000000001801");
        public static readonly Guid Property2 = Guid.Parse("00001802-0000-0000-0000-000000001802");
        public static readonly Guid Property3 = Guid.Parse("00001803-0000-0000-0000-000000001803");
        public static readonly Guid Property4 = Guid.Parse("00001804-0000-0000-0000-000000001804");
        public static readonly Guid Property5 = Guid.Parse("00001805-0000-0000-0000-000000001805");

        // Invoices
        public static readonly Guid Invoice1 = Guid.Parse("00001901-0000-0000-0000-000000001901");
        public static readonly Guid Invoice2 = Guid.Parse("00001902-0000-0000-0000-000000001902");
        public static readonly Guid Invoice3 = Guid.Parse("00001903-0000-0000-0000-000000001903");
        public static readonly Guid Invoice4 = Guid.Parse("00001904-0000-0000-0000-000000001904");
        public static readonly Guid Invoice5 = Guid.Parse("00001905-0000-0000-0000-000000001905");

        // PropertyTourRequests
        public static readonly Guid PropertyTourRequest1 = Guid.Parse("00002001-0000-0000-0000-000000002001");
        public static readonly Guid PropertyTourRequest2 = Guid.Parse("00002002-0000-0000-0000-000000002002");
        public static readonly Guid PropertyTourRequest3 = Guid.Parse("00002003-0000-0000-0000-000000002003");
        public static readonly Guid PropertyTourRequest4 = Guid.Parse("00002004-0000-0000-0000-000000002004");
        public static readonly Guid PropertyTourRequest5 = Guid.Parse("00002005-0000-0000-0000-000000002005");

        // Transactions
        public static readonly Guid Transaction1 = Guid.Parse("00002101-0000-0000-0000-000000002101");
        public static readonly Guid Transaction2 = Guid.Parse("00002102-0000-0000-0000-000000002102");
        public static readonly Guid Transaction3 = Guid.Parse("00002103-0000-0000-0000-000000002103");
        public static readonly Guid Transaction4 = Guid.Parse("00002104-0000-0000-0000-000000002104");
        public static readonly Guid Transaction5 = Guid.Parse("00002105-0000-0000-0000-000000002105");

        // Roles
        public static readonly Guid RoleAdmin = Guid.Parse("00003001-0000-0000-0000-000000003001");
        public static readonly Guid RolePropertyOwner = Guid.Parse("00003002-0000-0000-0000-000000003002");
        public static readonly Guid RoleBuyerTenant = Guid.Parse("00003003-0000-0000-0000-000000003003");

    }
}
