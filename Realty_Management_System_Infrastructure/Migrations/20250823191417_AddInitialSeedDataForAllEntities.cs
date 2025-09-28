using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Realty_Management_System_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddInitialSeedDataForAllEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Amenities",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("00000401-0000-0000-0000-000000000401"), new DateTime(2025, 8, 23, 19, 14, 17, 369, DateTimeKind.Utc).AddTicks(9391), "Swimming Pool", null },
                    { new Guid("00000402-0000-0000-0000-000000000402"), new DateTime(2025, 8, 23, 19, 14, 17, 369, DateTimeKind.Utc).AddTicks(9401), "Gym", null },
                    { new Guid("00000403-0000-0000-0000-000000000403"), new DateTime(2025, 8, 23, 19, 14, 17, 369, DateTimeKind.Utc).AddTicks(9402), "Parking", null },
                    { new Guid("00000404-0000-0000-0000-000000000404"), new DateTime(2025, 8, 23, 19, 14, 17, 369, DateTimeKind.Utc).AddTicks(9403), "Elevator", null },
                    { new Guid("00000405-0000-0000-0000-000000000405"), new DateTime(2025, 8, 23, 19, 14, 17, 369, DateTimeKind.Utc).AddTicks(9404), "Garden", null }
                });

            migrationBuilder.InsertData(
                table: "ContractTypes",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("00000501-0000-0000-0000-000000000501"), new DateTime(2025, 8, 23, 19, 14, 17, 375, DateTimeKind.Utc).AddTicks(4263), "Sale", null },
                    { new Guid("00000502-0000-0000-0000-000000000502"), new DateTime(2025, 8, 23, 19, 14, 17, 375, DateTimeKind.Utc).AddTicks(4265), "Rent", null },
                    { new Guid("00000503-0000-0000-0000-000000000503"), new DateTime(2025, 8, 23, 19, 14, 17, 375, DateTimeKind.Utc).AddTicks(4267), "Lease", null }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CreatedAt", "ISOCode", "Name", "UpdatedAt" },
                values: new object[] { new Guid("00000001-0000-0000-0000-000000000001"), new DateTime(2025, 8, 23, 19, 14, 17, 375, DateTimeKind.Utc).AddTicks(9148), "PS", "Palestine", null });

            migrationBuilder.InsertData(
                table: "InvoiceStatuses",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("00000901-0000-0000-0000-000000000901"), new DateTime(2025, 8, 23, 19, 14, 17, 376, DateTimeKind.Utc).AddTicks(5238), "Pending", null },
                    { new Guid("00000902-0000-0000-0000-000000000902"), new DateTime(2025, 8, 23, 19, 14, 17, 376, DateTimeKind.Utc).AddTicks(5241), "Paid", null },
                    { new Guid("00000903-0000-0000-0000-000000000903"), new DateTime(2025, 8, 23, 19, 14, 17, 376, DateTimeKind.Utc).AddTicks(5242), "Overdue", null },
                    { new Guid("00000904-0000-0000-0000-000000000904"), new DateTime(2025, 8, 23, 19, 14, 17, 376, DateTimeKind.Utc).AddTicks(5243), "Cancelled", null },
                    { new Guid("00000905-0000-0000-0000-000000000905"), new DateTime(2025, 8, 23, 19, 14, 17, 376, DateTimeKind.Utc).AddTicks(5244), "Refunded", null }
                });

            migrationBuilder.InsertData(
                table: "NearbyPlaceTypes",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("00000801-0000-0000-0000-000000000801"), new DateTime(2025, 8, 23, 19, 14, 17, 377, DateTimeKind.Utc).AddTicks(4013), "School", null },
                    { new Guid("00000802-0000-0000-0000-000000000802"), new DateTime(2025, 8, 23, 19, 14, 17, 377, DateTimeKind.Utc).AddTicks(4023), "Hospital", null },
                    { new Guid("00000803-0000-0000-0000-000000000803"), new DateTime(2025, 8, 23, 19, 14, 17, 377, DateTimeKind.Utc).AddTicks(4024), "Shopping Center", null },
                    { new Guid("00000804-0000-0000-0000-000000000804"), new DateTime(2025, 8, 23, 19, 14, 17, 377, DateTimeKind.Utc).AddTicks(4025), "Park", null },
                    { new Guid("00000805-0000-0000-0000-000000000805"), new DateTime(2025, 8, 23, 19, 14, 17, 377, DateTimeKind.Utc).AddTicks(4026), "Restaurant", null }
                });

            migrationBuilder.InsertData(
                table: "PaymentFrequencies",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("00001001-0000-0000-0000-000000001001"), new DateTime(2025, 8, 23, 19, 14, 17, 377, DateTimeKind.Utc).AddTicks(6579), "Monthly", null },
                    { new Guid("00001002-0000-0000-0000-000000001002"), new DateTime(2025, 8, 23, 19, 14, 17, 377, DateTimeKind.Utc).AddTicks(6581), "Quarterly", null },
                    { new Guid("00001003-0000-0000-0000-000000001003"), new DateTime(2025, 8, 23, 19, 14, 17, 377, DateTimeKind.Utc).AddTicks(6583), "Annually", null },
                    { new Guid("00001004-0000-0000-0000-000000001004"), new DateTime(2025, 8, 23, 19, 14, 17, 377, DateTimeKind.Utc).AddTicks(6584), "Weekly", null },
                    { new Guid("00001005-0000-0000-0000-000000001005"), new DateTime(2025, 8, 23, 19, 14, 17, 377, DateTimeKind.Utc).AddTicks(6585), "Bi-Weekly", null }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethods",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("00001101-0000-0000-0000-000000001101"), new DateTime(2025, 8, 23, 19, 14, 17, 377, DateTimeKind.Utc).AddTicks(8951), "Cash", null },
                    { new Guid("00001102-0000-0000-0000-000000001102"), new DateTime(2025, 8, 23, 19, 14, 17, 377, DateTimeKind.Utc).AddTicks(8953), "Credit Card", null },
                    { new Guid("00001103-0000-0000-0000-000000001103"), new DateTime(2025, 8, 23, 19, 14, 17, 377, DateTimeKind.Utc).AddTicks(8955), "Bank Transfer", null },
                    { new Guid("00001104-0000-0000-0000-000000001104"), new DateTime(2025, 8, 23, 19, 14, 17, 377, DateTimeKind.Utc).AddTicks(8956), "Mobile Wallet", null },
                    { new Guid("00001105-0000-0000-0000-000000001105"), new DateTime(2025, 8, 23, 19, 14, 17, 377, DateTimeKind.Utc).AddTicks(8957), "PayPal", null }
                });

            migrationBuilder.InsertData(
                table: "PriceUnitTypes",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("00001301-0000-0000-0000-000000001301"), new DateTime(2025, 8, 23, 19, 14, 17, 378, DateTimeKind.Utc).AddTicks(6751), "Per Square Meter", null },
                    { new Guid("00001302-0000-0000-0000-000000001302"), new DateTime(2025, 8, 23, 19, 14, 17, 378, DateTimeKind.Utc).AddTicks(6754), "Per Square Foot", null },
                    { new Guid("00001303-0000-0000-0000-000000001303"), new DateTime(2025, 8, 23, 19, 14, 17, 378, DateTimeKind.Utc).AddTicks(6755), "Per Month", null },
                    { new Guid("00001304-0000-0000-0000-000000001304"), new DateTime(2025, 8, 23, 19, 14, 17, 378, DateTimeKind.Utc).AddTicks(6756), "Per Year", null },
                    { new Guid("00001305-0000-0000-0000-000000001305"), new DateTime(2025, 8, 23, 19, 14, 17, 378, DateTimeKind.Utc).AddTicks(6765), "Total Price", null }
                });

            migrationBuilder.InsertData(
                table: "PropertyCategories",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("00001601-0000-0000-0000-000000001601"), new DateTime(2025, 8, 23, 19, 14, 17, 379, DateTimeKind.Utc).AddTicks(9807), "Apartment", null },
                    { new Guid("00001602-0000-0000-0000-000000001602"), new DateTime(2025, 8, 23, 19, 14, 17, 379, DateTimeKind.Utc).AddTicks(9809), "Villa", null },
                    { new Guid("00001603-0000-0000-0000-000000001603"), new DateTime(2025, 8, 23, 19, 14, 17, 379, DateTimeKind.Utc).AddTicks(9810), "Townhouse", null },
                    { new Guid("00001604-0000-0000-0000-000000001604"), new DateTime(2025, 8, 23, 19, 14, 17, 379, DateTimeKind.Utc).AddTicks(9811), "Office", null },
                    { new Guid("00001605-0000-0000-0000-000000001605"), new DateTime(2025, 8, 23, 19, 14, 17, 379, DateTimeKind.Utc).AddTicks(9812), "Retail", null }
                });

            migrationBuilder.InsertData(
                table: "PropertyFeatures",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("00001501-0000-0000-0000-000000001501"), new DateTime(2025, 8, 23, 19, 14, 17, 383, DateTimeKind.Utc).AddTicks(4646), "Swimming Pool", null },
                    { new Guid("00001502-0000-0000-0000-000000001502"), new DateTime(2025, 8, 23, 19, 14, 17, 383, DateTimeKind.Utc).AddTicks(4650), "Gym", null },
                    { new Guid("00001503-0000-0000-0000-000000001503"), new DateTime(2025, 8, 23, 19, 14, 17, 383, DateTimeKind.Utc).AddTicks(4651), "Balcony", null },
                    { new Guid("00001504-0000-0000-0000-000000001504"), new DateTime(2025, 8, 23, 19, 14, 17, 383, DateTimeKind.Utc).AddTicks(4652), "Garden", null },
                    { new Guid("00001505-0000-0000-0000-000000001505"), new DateTime(2025, 8, 23, 19, 14, 17, 383, DateTimeKind.Utc).AddTicks(4653), "Garage", null }
                });

            migrationBuilder.InsertData(
                table: "PropertyStatuses",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("00001401-0000-0000-0000-000000001401"), new DateTime(2025, 8, 23, 19, 14, 17, 385, DateTimeKind.Utc).AddTicks(8169), "Available", null },
                    { new Guid("00001402-0000-0000-0000-000000001402"), new DateTime(2025, 8, 23, 19, 14, 17, 385, DateTimeKind.Utc).AddTicks(8171), "Pending", null },
                    { new Guid("00001403-0000-0000-0000-000000001403"), new DateTime(2025, 8, 23, 19, 14, 17, 385, DateTimeKind.Utc).AddTicks(8172), "Sold", null },
                    { new Guid("00001404-0000-0000-0000-000000001404"), new DateTime(2025, 8, 23, 19, 14, 17, 385, DateTimeKind.Utc).AddTicks(8173), "Rented", null },
                    { new Guid("00001405-0000-0000-0000-000000001405"), new DateTime(2025, 8, 23, 19, 14, 17, 385, DateTimeKind.Utc).AddTicks(8174), "Under Maintenance", null }
                });

            migrationBuilder.InsertData(
                table: "PropertyTourRequestStatuses",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("00001201-0000-0000-0000-000000001201"), new DateTime(2025, 8, 23, 19, 14, 17, 386, DateTimeKind.Utc).AddTicks(3924), "Pending", null },
                    { new Guid("00001202-0000-0000-0000-000000001202"), new DateTime(2025, 8, 23, 19, 14, 17, 386, DateTimeKind.Utc).AddTicks(3926), "Confirmed", null },
                    { new Guid("00001203-0000-0000-0000-000000001203"), new DateTime(2025, 8, 23, 19, 14, 17, 386, DateTimeKind.Utc).AddTicks(3926), "Rescheduled", null },
                    { new Guid("00001204-0000-0000-0000-000000001204"), new DateTime(2025, 8, 23, 19, 14, 17, 386, DateTimeKind.Utc).AddTicks(3927), "Completed", null },
                    { new Guid("00001205-0000-0000-0000-000000001205"), new DateTime(2025, 8, 23, 19, 14, 17, 386, DateTimeKind.Utc).AddTicks(3928), "Canceled", null }
                });

            migrationBuilder.InsertData(
                table: "TransactionStatuses",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("00000701-0000-0000-0000-000000000701"), new DateTime(2025, 8, 23, 19, 14, 17, 387, DateTimeKind.Utc).AddTicks(8466), "Pending", null },
                    { new Guid("00000702-0000-0000-0000-000000000702"), new DateTime(2025, 8, 23, 19, 14, 17, 387, DateTimeKind.Utc).AddTicks(8468), "Completed", null },
                    { new Guid("00000703-0000-0000-0000-000000000703"), new DateTime(2025, 8, 23, 19, 14, 17, 387, DateTimeKind.Utc).AddTicks(8469), "Cancelled", null },
                    { new Guid("00000704-0000-0000-0000-000000000704"), new DateTime(2025, 8, 23, 19, 14, 17, 387, DateTimeKind.Utc).AddTicks(8470), "Failed", null }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "CreatedAt", "Latitude", "Longitude", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("00000101-0000-0000-0000-000000000101"), new Guid("00000001-0000-0000-0000-000000000001"), new DateTime(2025, 8, 23, 19, 14, 17, 370, DateTimeKind.Utc).AddTicks(5139), 32.2211m, 35.2544m, "Nablus", null },
                    { new Guid("00000102-0000-0000-0000-000000000102"), new Guid("00000001-0000-0000-0000-000000000001"), new DateTime(2025, 8, 23, 19, 14, 17, 370, DateTimeKind.Utc).AddTicks(5146), 31.9076m, 35.2034m, "Ramallah", null },
                    { new Guid("00000103-0000-0000-0000-000000000103"), new Guid("00000001-0000-0000-0000-000000000001"), new DateTime(2025, 8, 23, 19, 14, 17, 370, DateTimeKind.Utc).AddTicks(5149), 31.5326m, 35.0998m, "Hebron", null },
                    { new Guid("00000104-0000-0000-0000-000000000104"), new Guid("00000001-0000-0000-0000-000000000001"), new DateTime(2025, 8, 23, 19, 14, 17, 370, DateTimeKind.Utc).AddTicks(5152), 31.7054m, 35.2024m, "Bethlehem", null },
                    { new Guid("00000105-0000-0000-0000-000000000105"), new Guid("00000001-0000-0000-0000-000000000001"), new DateTime(2025, 8, 23, 19, 14, 17, 370, DateTimeKind.Utc).AddTicks(5161), 32.4576m, 35.2936m, "Jenin", null }
                });

            migrationBuilder.InsertData(
                table: "PriceUnits",
                columns: new[] { "Id", "Abbreviation", "ConversionFactor", "CreatedAt", "Name", "PriceUnitTypeId", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("00002201-0000-0000-0000-000000002201"), "m²", 1.0m, new DateTime(2025, 8, 23, 19, 14, 17, 378, DateTimeKind.Utc).AddTicks(4179), "Per Square Meter", new Guid("00001301-0000-0000-0000-000000001301"), "sqm", null },
                    { new Guid("00002202-0000-0000-0000-000000002202"), "ft²", 0.092903m, new DateTime(2025, 8, 23, 19, 14, 17, 378, DateTimeKind.Utc).AddTicks(4185), "Per Square Foot", new Guid("00001302-0000-0000-0000-000000001302"), "sqft", null },
                    { new Guid("00002203-0000-0000-0000-000000002203"), "mo", null, new DateTime(2025, 8, 23, 19, 14, 17, 378, DateTimeKind.Utc).AddTicks(4187), "Per Month", new Guid("00001303-0000-0000-0000-000000001303"), "per month", null },
                    { new Guid("00002204-0000-0000-0000-000000002204"), "yr", null, new DateTime(2025, 8, 23, 19, 14, 17, 378, DateTimeKind.Utc).AddTicks(4189), "Per Year", new Guid("00001304-0000-0000-0000-000000001304"), "per year", null },
                    { new Guid("00002205-0000-0000-0000-000000002205"), "total", null, new DateTime(2025, 8, 23, 19, 14, 17, 378, DateTimeKind.Utc).AddTicks(4191), "Total Price", new Guid("00001305-0000-0000-0000-000000001305"), "total", null }
                });

            migrationBuilder.InsertData(
                table: "Zones",
                columns: new[] { "Id", "CityId", "CountryId", "CreatedAt", "Latitude", "Longitude", "Name", "PostalCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("00000201-0000-0000-0000-000000000201"), new Guid("00000101-0000-0000-0000-000000000101"), new Guid("00000001-0000-0000-0000-000000000001"), new DateTime(2025, 8, 23, 19, 14, 17, 388, DateTimeKind.Utc).AddTicks(7772), 32.2215m, 35.2540m, "Old City", "NBL-001", null },
                    { new Guid("00000202-0000-0000-0000-000000000202"), new Guid("00000101-0000-0000-0000-000000000101"), new Guid("00000001-0000-0000-0000-000000000001"), new DateTime(2025, 8, 23, 19, 14, 17, 388, DateTimeKind.Utc).AddTicks(7779), 32.2250m, 35.2590m, "Balata", "NBL-002", null },
                    { new Guid("00000203-0000-0000-0000-000000000203"), new Guid("00000101-0000-0000-0000-000000000101"), new Guid("00000001-0000-0000-0000-000000000001"), new DateTime(2025, 8, 23, 19, 14, 17, 388, DateTimeKind.Utc).AddTicks(7786), 32.2160m, 35.2470m, "Rafidia", "NBL-003", null },
                    { new Guid("00000204-0000-0000-0000-000000000204"), new Guid("00000101-0000-0000-0000-000000000101"), new Guid("00000001-0000-0000-0000-000000000001"), new DateTime(2025, 8, 23, 19, 14, 17, 388, DateTimeKind.Utc).AddTicks(7788), 32.2300m, 35.2600m, "Askar", "NBL-004", null },
                    { new Guid("00000205-0000-0000-0000-000000000205"), new Guid("00000101-0000-0000-0000-000000000101"), new Guid("00000001-0000-0000-0000-000000000001"), new DateTime(2025, 8, 23, 19, 14, 17, 388, DateTimeKind.Utc).AddTicks(7791), 32.2400m, 35.2700m, "Beit Furiq", "NBL-005", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CityId", "ConcurrencyStamp", "CountryId", "CreatedAt", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName", "ZoneId" },
                values: new object[,]
                {
                    { new Guid("00000301-0000-0000-0000-000000000301"), 0, new Guid("00000101-0000-0000-0000-000000000101"), "ec201e1b-7fa2-4bc4-9019-0dc97a3be772", new Guid("00000001-0000-0000-0000-000000000001"), new DateTime(2025, 8, 23, 19, 14, 17, 388, DateTimeKind.Utc).AddTicks(4447), "diaa@example.com", false, "Diaa", "Sharqawi", false, null, null, null, null, null, false, "", null, false, null, "diaa.sharqawi", new Guid("00000201-0000-0000-0000-000000000201") },
                    { new Guid("00000302-0000-0000-0000-000000000302"), 0, new Guid("00000102-0000-0000-0000-000000000102"), "34141a40-c5cf-4363-a888-d59906e5e618", new Guid("00000001-0000-0000-0000-000000000001"), new DateTime(2025, 8, 23, 19, 14, 17, 388, DateTimeKind.Utc).AddTicks(4534), "sara@example.com", false, "Sara", "AbuBakr", false, null, null, null, null, null, false, "", null, false, null, "sara.abubakr", new Guid("00000202-0000-0000-0000-000000000202") },
                    { new Guid("00000303-0000-0000-0000-000000000303"), 0, new Guid("00000103-0000-0000-0000-000000000103"), "e20a09e9-7211-4739-86d0-4c2e39f53d11", new Guid("00000001-0000-0000-0000-000000000001"), new DateTime(2025, 8, 23, 19, 14, 17, 388, DateTimeKind.Utc).AddTicks(4539), "omar@example.com", false, "Omar", "Haddad", false, null, null, null, null, null, false, "", null, false, null, "omar.haddad", new Guid("00000203-0000-0000-0000-000000000203") }
                });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "Id", "CityId", "CountryId", "CreatedAt", "Description", "NumberOfBathrooms", "NumberOfBedrooms", "NumberOfFloors", "NumberOfGarage", "OwnerId", "Price", "PriceUnitId", "PropertyStatusId", "Slug", "UpdatedAt", "YearBuilt", "ZoneId" },
                values: new object[,]
                {
                    { new Guid("00001801-0000-0000-0000-000000001801"), new Guid("00000101-0000-0000-0000-000000000101"), new Guid("00000001-0000-0000-0000-000000000001"), new DateTime(2025, 8, 23, 19, 14, 17, 381, DateTimeKind.Utc).AddTicks(8877), "Modern 2-bedroom apartment in the city center", 1, 2, 1, 0, new Guid("00000301-0000-0000-0000-000000000301"), 55000m, new Guid("00002205-0000-0000-0000-000000002205"), new Guid("00001401-0000-0000-0000-000000001401"), "modern-apartment-nablus", null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000201-0000-0000-0000-000000000201") },
                    { new Guid("00001802-0000-0000-0000-000000001802"), new Guid("00000101-0000-0000-0000-000000000101"), new Guid("00000001-0000-0000-0000-000000000001"), new DateTime(2025, 8, 23, 19, 14, 17, 381, DateTimeKind.Utc).AddTicks(8898), "Spacious villa with garden and garage", 3, 4, 2, 1, new Guid("00000302-0000-0000-0000-000000000302"), 250000m, new Guid("00002205-0000-0000-0000-000000002205"), new Guid("00001401-0000-0000-0000-000000001401"), "villa-rafidia", null, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000203-0000-0000-0000-000000000203") },
                    { new Guid("00001803-0000-0000-0000-000000001803"), new Guid("00000101-0000-0000-0000-000000000101"), new Guid("00000001-0000-0000-0000-000000000001"), new DateTime(2025, 8, 23, 19, 14, 17, 381, DateTimeKind.Utc).AddTicks(8904), "Affordable family home in Balata", 2, 3, 2, 0, new Guid("00000303-0000-0000-0000-000000000303"), 80000m, new Guid("00002205-0000-0000-0000-000000002205"), new Guid("00001401-0000-0000-0000-000000001401"), "balata-house", null, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000202-0000-0000-0000-000000000202") },
                    { new Guid("00001804-0000-0000-0000-000000001804"), new Guid("00000101-0000-0000-0000-000000000101"), new Guid("00000001-0000-0000-0000-000000000001"), new DateTime(2025, 8, 23, 19, 14, 17, 381, DateTimeKind.Utc).AddTicks(8909), "Small 1-bedroom apartment near market", 1, 1, 1, 0, new Guid("00000301-0000-0000-0000-000000000301"), 30000m, new Guid("00002205-0000-0000-0000-000000002205"), new Guid("00001404-0000-0000-0000-000000001404"), "askar-apartment", null, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000204-0000-0000-0000-000000000204") },
                    { new Guid("00001805-0000-0000-0000-000000001805"), new Guid("00000101-0000-0000-0000-000000000101"), new Guid("00000001-0000-0000-0000-000000000001"), new DateTime(2025, 8, 23, 19, 14, 17, 381, DateTimeKind.Utc).AddTicks(8913), "Empty land for investment", null, null, null, null, new Guid("00000302-0000-0000-0000-000000000302"), 150000m, new Guid("00002205-0000-0000-0000-000000002205"), new Guid("00001401-0000-0000-0000-000000001401"), "beit-furiq-land", null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000205-0000-0000-0000-000000000205") }
                });

            migrationBuilder.InsertData(
                table: "Contracts",
                columns: new[] { "Id", "ContractTypeId", "CreatedAt", "CustomerId", "EndDate", "OwnerId", "PaymentFrequencyId", "PropertyId", "PropertyReviewId", "StartDate", "TotalAmount", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("00000601-0000-0000-0000-000000000601"), new Guid("00000501-0000-0000-0000-000000000501"), new DateTime(2025, 8, 23, 19, 14, 17, 375, DateTimeKind.Utc).AddTicks(2020), new Guid("00000302-0000-0000-0000-000000000302"), new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000301-0000-0000-0000-000000000301"), new Guid("00001001-0000-0000-0000-000000001001"), new Guid("00001801-0000-0000-0000-000000001801"), null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12000m, null },
                    { new Guid("00000602-0000-0000-0000-000000000602"), new Guid("00000502-0000-0000-0000-000000000502"), new DateTime(2025, 8, 23, 19, 14, 17, 375, DateTimeKind.Utc).AddTicks(2033), new Guid("00000303-0000-0000-0000-000000000303"), new DateTime(2025, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000301-0000-0000-0000-000000000301"), new Guid("00001002-0000-0000-0000-000000001002"), new Guid("00001802-0000-0000-0000-000000001802"), null, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6000m, null },
                    { new Guid("00000603-0000-0000-0000-000000000603"), new Guid("00000503-0000-0000-0000-000000000503"), new DateTime(2025, 8, 23, 19, 14, 17, 375, DateTimeKind.Utc).AddTicks(2036), new Guid("00000301-0000-0000-0000-000000000301"), new DateTime(2025, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000302-0000-0000-0000-000000000302"), new Guid("00001003-0000-0000-0000-000000001003"), new Guid("00001803-0000-0000-0000-000000001803"), null, new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9000m, null },
                    { new Guid("00000604-0000-0000-0000-000000000604"), new Guid("00000501-0000-0000-0000-000000000501"), new DateTime(2025, 8, 23, 19, 14, 17, 375, DateTimeKind.Utc).AddTicks(2038), new Guid("00000302-0000-0000-0000-000000000302"), new DateTime(2025, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000303-0000-0000-0000-000000000303"), new Guid("00001001-0000-0000-0000-000000001001"), new Guid("00001804-0000-0000-0000-000000001804"), null, new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15000m, null },
                    { new Guid("00000605-0000-0000-0000-000000000605"), new Guid("00000502-0000-0000-0000-000000000502"), new DateTime(2025, 8, 23, 19, 14, 17, 375, DateTimeKind.Utc).AddTicks(2041), new Guid("00000303-0000-0000-0000-000000000303"), new DateTime(2025, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000302-0000-0000-0000-000000000302"), new Guid("00001005-0000-0000-0000-000000001005"), new Guid("00001805-0000-0000-0000-000000001805"), null, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7500m, null }
                });

            migrationBuilder.InsertData(
                table: "NearbyPlaces",
                columns: new[] { "NearbyPlaceTypeId", "PropertyId", "CreatedAt", "DistanceInKm", "Id", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("00000801-0000-0000-0000-000000000801"), new Guid("00001801-0000-0000-0000-000000001801"), new DateTime(2025, 8, 23, 19, 14, 17, 377, DateTimeKind.Utc).AddTicks(1206), 0.5, new Guid("00000000-0000-0000-0000-000000000000"), "Central Park", null },
                    { new Guid("00000802-0000-0000-0000-000000000802"), new Guid("00001801-0000-0000-0000-000000001801"), new DateTime(2025, 8, 23, 19, 14, 17, 377, DateTimeKind.Utc).AddTicks(1209), 1.2, new Guid("00000000-0000-0000-0000-000000000000"), "Metro Station", null },
                    { new Guid("00000803-0000-0000-0000-000000000803"), new Guid("00001802-0000-0000-0000-000000001802"), new DateTime(2025, 8, 23, 19, 14, 17, 377, DateTimeKind.Utc).AddTicks(1210), 2.5, new Guid("00000000-0000-0000-0000-000000000000"), "Shopping Mall", null },
                    { new Guid("00000804-0000-0000-0000-000000000804"), new Guid("00001803-0000-0000-0000-000000001803"), new DateTime(2025, 8, 23, 19, 14, 17, 377, DateTimeKind.Utc).AddTicks(1211), 1.8, new Guid("00000000-0000-0000-0000-000000000000"), "Hospital", null },
                    { new Guid("00000805-0000-0000-0000-000000000805"), new Guid("00001804-0000-0000-0000-000000001804"), new DateTime(2025, 8, 23, 19, 14, 17, 377, DateTimeKind.Utc).AddTicks(1212), 0.80000000000000004, new Guid("00000000-0000-0000-0000-000000000000"), "School", null }
                });

            migrationBuilder.InsertData(
                table: "PropertyAmenities",
                columns: new[] { "AmenityId", "PropertyId", "CreatedAt", "Id", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("00000401-0000-0000-0000-000000000401"), new Guid("00001801-0000-0000-0000-000000001801"), new DateTime(2025, 8, 23, 19, 14, 17, 379, DateTimeKind.Utc).AddTicks(1452), new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("00000402-0000-0000-0000-000000000402"), new Guid("00001801-0000-0000-0000-000000001801"), new DateTime(2025, 8, 23, 19, 14, 17, 379, DateTimeKind.Utc).AddTicks(1454), new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("00000403-0000-0000-0000-000000000403"), new Guid("00001802-0000-0000-0000-000000001802"), new DateTime(2025, 8, 23, 19, 14, 17, 379, DateTimeKind.Utc).AddTicks(1455), new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("00000404-0000-0000-0000-000000000404"), new Guid("00001803-0000-0000-0000-000000001803"), new DateTime(2025, 8, 23, 19, 14, 17, 379, DateTimeKind.Utc).AddTicks(1455), new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("00000405-0000-0000-0000-000000000405"), new Guid("00001804-0000-0000-0000-000000001804"), new DateTime(2025, 8, 23, 19, 14, 17, 379, DateTimeKind.Utc).AddTicks(1456), new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "PropertyCategoryAssociations",
                columns: new[] { "PropertyCategoryId", "PropertyId", "CreatedAt", "Id", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("00001601-0000-0000-0000-000000001601"), new Guid("00001801-0000-0000-0000-000000001801"), new DateTime(2025, 8, 23, 19, 14, 17, 379, DateTimeKind.Utc).AddTicks(7996), new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("00001602-0000-0000-0000-000000001602"), new Guid("00001802-0000-0000-0000-000000001802"), new DateTime(2025, 8, 23, 19, 14, 17, 379, DateTimeKind.Utc).AddTicks(7998), new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("00001603-0000-0000-0000-000000001603"), new Guid("00001803-0000-0000-0000-000000001803"), new DateTime(2025, 8, 23, 19, 14, 17, 379, DateTimeKind.Utc).AddTicks(7999), new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("00001604-0000-0000-0000-000000001604"), new Guid("00001804-0000-0000-0000-000000001804"), new DateTime(2025, 8, 23, 19, 14, 17, 379, DateTimeKind.Utc).AddTicks(8000), new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("00001605-0000-0000-0000-000000001605"), new Guid("00001805-0000-0000-0000-000000001805"), new DateTime(2025, 8, 23, 19, 14, 17, 379, DateTimeKind.Utc).AddTicks(8001), new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "PropertyFeatureAssociations",
                columns: new[] { "PropertyFeatureId", "PropertyId", "CreatedAt", "Id", "UpdatedAt", "Value" },
                values: new object[,]
                {
                    { new Guid("00001501-0000-0000-0000-000000001501"), new Guid("00001801-0000-0000-0000-000000001801"), new DateTime(2025, 8, 23, 19, 14, 17, 382, DateTimeKind.Utc).AddTicks(9777), new Guid("00000000-0000-0000-0000-000000000000"), null, "" },
                    { new Guid("00001502-0000-0000-0000-000000001502"), new Guid("00001802-0000-0000-0000-000000001802"), new DateTime(2025, 8, 23, 19, 14, 17, 382, DateTimeKind.Utc).AddTicks(9785), new Guid("00000000-0000-0000-0000-000000000000"), null, "" },
                    { new Guid("00001503-0000-0000-0000-000000001503"), new Guid("00001803-0000-0000-0000-000000001803"), new DateTime(2025, 8, 23, 19, 14, 17, 382, DateTimeKind.Utc).AddTicks(9786), new Guid("00000000-0000-0000-0000-000000000000"), null, "" },
                    { new Guid("00001504-0000-0000-0000-000000001504"), new Guid("00001804-0000-0000-0000-000000001804"), new DateTime(2025, 8, 23, 19, 14, 17, 382, DateTimeKind.Utc).AddTicks(9787), new Guid("00000000-0000-0000-0000-000000000000"), null, "" },
                    { new Guid("00001505-0000-0000-0000-000000001505"), new Guid("00001805-0000-0000-0000-000000001805"), new DateTime(2025, 8, 23, 19, 14, 17, 382, DateTimeKind.Utc).AddTicks(9788), new Guid("00000000-0000-0000-0000-000000000000"), null, "" }
                });

            migrationBuilder.InsertData(
                table: "PropertyImages",
                columns: new[] { "Id", "AltText", "CreatedAt", "PropertyId", "UpdatedAt", "Url" },
                values: new object[,]
                {
                    { new Guid("00001701-0000-0000-0000-000000001701"), "Front view of the property", new DateTime(2025, 8, 23, 19, 14, 17, 383, DateTimeKind.Utc).AddTicks(7115), new Guid("00001801-0000-0000-0000-000000001801"), null, "https://example.com/images/property1-front.jpg" },
                    { new Guid("00001702-0000-0000-0000-000000001702"), "Spacious living room", new DateTime(2025, 8, 23, 19, 14, 17, 383, DateTimeKind.Utc).AddTicks(7120), new Guid("00001801-0000-0000-0000-000000001801"), null, "https://example.com/images/property1-livingroom.jpg" },
                    { new Guid("00001703-0000-0000-0000-000000001703"), "Master bedroom", new DateTime(2025, 8, 23, 19, 14, 17, 383, DateTimeKind.Utc).AddTicks(7121), new Guid("00001802-0000-0000-0000-000000001802"), null, "https://example.com/images/property2-bedroom.jpg" },
                    { new Guid("00001704-0000-0000-0000-000000001704"), "Balcony view", new DateTime(2025, 8, 23, 19, 14, 17, 383, DateTimeKind.Utc).AddTicks(7122), new Guid("00001803-0000-0000-0000-000000001803"), null, "https://example.com/images/property3-balcony.jpg" },
                    { new Guid("00001705-0000-0000-0000-000000001705"), "Modern kitchen", new DateTime(2025, 8, 23, 19, 14, 17, 383, DateTimeKind.Utc).AddTicks(7123), new Guid("00001803-0000-0000-0000-000000001803"), null, "https://example.com/images/property3-kitchen.jpg" }
                });

            migrationBuilder.InsertData(
                table: "PropertyTourRequests",
                columns: new[] { "Id", "CreatedAt", "Message", "PreferredDateTime", "PropertyId", "PropertyTourRequestStatusId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("00002001-0000-0000-0000-000000002001"), new DateTime(2025, 8, 23, 19, 14, 17, 386, DateTimeKind.Utc).AddTicks(2040), "", new DateTime(2025, 8, 26, 5, 14, 17, 386, DateTimeKind.Utc).AddTicks(2041), new Guid("00001801-0000-0000-0000-000000001801"), new Guid("00001201-0000-0000-0000-000000001201"), null, new Guid("00000301-0000-0000-0000-000000000301") },
                    { new Guid("00002002-0000-0000-0000-000000002002"), new DateTime(2025, 8, 23, 19, 14, 17, 386, DateTimeKind.Utc).AddTicks(2049), "", new DateTime(2025, 8, 27, 9, 14, 17, 386, DateTimeKind.Utc).AddTicks(2050), new Guid("00001802-0000-0000-0000-000000001802"), new Guid("00001202-0000-0000-0000-000000001202"), null, new Guid("00000302-0000-0000-0000-000000000302") },
                    { new Guid("00002003-0000-0000-0000-000000002003"), new DateTime(2025, 8, 23, 19, 14, 17, 386, DateTimeKind.Utc).AddTicks(2052), "", new DateTime(2025, 8, 25, 11, 14, 17, 386, DateTimeKind.Utc).AddTicks(2052), new Guid("00001803-0000-0000-0000-000000001803"), new Guid("00001203-0000-0000-0000-000000001203"), null, new Guid("00000303-0000-0000-0000-000000000303") },
                    { new Guid("00002004-0000-0000-0000-000000002004"), new DateTime(2025, 8, 23, 19, 14, 17, 386, DateTimeKind.Utc).AddTicks(2053), "", new DateTime(2025, 8, 29, 6, 14, 17, 386, DateTimeKind.Utc).AddTicks(2054), new Guid("00001804-0000-0000-0000-000000001804"), new Guid("00001204-0000-0000-0000-000000001204"), null, new Guid("00000301-0000-0000-0000-000000000301") },
                    { new Guid("00002005-0000-0000-0000-000000002005"), new DateTime(2025, 8, 23, 19, 14, 17, 386, DateTimeKind.Utc).AddTicks(2055), "", new DateTime(2025, 8, 28, 4, 14, 17, 386, DateTimeKind.Utc).AddTicks(2056), new Guid("00001805-0000-0000-0000-000000001805"), new Guid("00001205-0000-0000-0000-000000001205"), null, new Guid("00000302-0000-0000-0000-000000000302") }
                });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "Id", "Amount", "ContractId", "CreatedAt", "DueDate", "InvoiceStatusId", "IssueDate", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("00001901-0000-0000-0000-000000001901"), 1500.00m, new Guid("00000601-0000-0000-0000-000000000601"), new DateTime(2025, 8, 23, 19, 14, 17, 376, DateTimeKind.Utc).AddTicks(3054), new DateTime(2025, 9, 12, 19, 14, 17, 376, DateTimeKind.Utc).AddTicks(3062), new Guid("00000901-0000-0000-0000-000000000901"), new DateTime(2025, 8, 13, 19, 14, 17, 376, DateTimeKind.Utc).AddTicks(3056), null },
                    { new Guid("00001902-0000-0000-0000-000000001902"), 2500.00m, new Guid("00000602-0000-0000-0000-000000000602"), new DateTime(2025, 8, 23, 19, 14, 17, 376, DateTimeKind.Utc).AddTicks(3064), new DateTime(2025, 9, 2, 19, 14, 17, 376, DateTimeKind.Utc).AddTicks(3065), new Guid("00000902-0000-0000-0000-000000000902"), new DateTime(2025, 8, 3, 19, 14, 17, 376, DateTimeKind.Utc).AddTicks(3065), null },
                    { new Guid("00001903-0000-0000-0000-000000001903"), 3200.00m, new Guid("00000603-0000-0000-0000-000000000603"), new DateTime(2025, 8, 23, 19, 14, 17, 376, DateTimeKind.Utc).AddTicks(3067), new DateTime(2025, 8, 18, 19, 14, 17, 376, DateTimeKind.Utc).AddTicks(3068), new Guid("00000903-0000-0000-0000-000000000903"), new DateTime(2025, 7, 24, 19, 14, 17, 376, DateTimeKind.Utc).AddTicks(3068), null },
                    { new Guid("00001904-0000-0000-0000-000000001904"), 4100.00m, new Guid("00000604-0000-0000-0000-000000000604"), new DateTime(2025, 8, 23, 19, 14, 17, 376, DateTimeKind.Utc).AddTicks(3070), new DateTime(2025, 9, 7, 19, 14, 17, 376, DateTimeKind.Utc).AddTicks(3071), new Guid("00000904-0000-0000-0000-000000000904"), new DateTime(2025, 8, 8, 19, 14, 17, 376, DateTimeKind.Utc).AddTicks(3070), null },
                    { new Guid("00001905-0000-0000-0000-000000001905"), 5000.00m, new Guid("00000605-0000-0000-0000-000000000605"), new DateTime(2025, 8, 23, 19, 14, 17, 376, DateTimeKind.Utc).AddTicks(3072), new DateTime(2025, 9, 17, 19, 14, 17, 376, DateTimeKind.Utc).AddTicks(3073), new Guid("00000905-0000-0000-0000-000000000905"), new DateTime(2025, 8, 18, 19, 14, 17, 376, DateTimeKind.Utc).AddTicks(3073), null }
                });

            migrationBuilder.InsertData(
                table: "PropertyReviews",
                columns: new[] { "Id", "Comment", "ContractId", "CreatedAt", "PropertyId", "Rating", "TransactionId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("00002301-0000-0000-0000-000000002301"), "Amazing property, well-maintained and spacious.", new Guid("00000601-0000-0000-0000-000000000601"), new DateTime(2025, 8, 23, 19, 14, 17, 385, DateTimeKind.Utc).AddTicks(6266), new Guid("00001801-0000-0000-0000-000000001801"), 4.75m, new Guid("00002101-0000-0000-0000-000000002101"), null, new Guid("00000301-0000-0000-0000-000000000301") },
                    { new Guid("00002302-0000-0000-0000-000000002302"), "Beautiful villa with a lovely garden.", new Guid("00000602-0000-0000-0000-000000000602"), new DateTime(2025, 8, 23, 19, 14, 17, 385, DateTimeKind.Utc).AddTicks(6272), new Guid("00001802-0000-0000-0000-000000001802"), 4.90m, new Guid("00002102-0000-0000-0000-000000002102"), null, new Guid("00000302-0000-0000-0000-000000000302") },
                    { new Guid("00002303-0000-0000-0000-000000002303"), "Cozy townhouse, perfect for a small family.", new Guid("00000603-0000-0000-0000-000000000603"), new DateTime(2025, 8, 23, 19, 14, 17, 385, DateTimeKind.Utc).AddTicks(6274), new Guid("00001803-0000-0000-0000-000000001803"), 4.50m, new Guid("00002103-0000-0000-0000-000000002103"), null, new Guid("00000303-0000-0000-0000-000000000303") },
                    { new Guid("00002304-0000-0000-0000-000000002304"), "Spacious office space with excellent location.", new Guid("00000604-0000-0000-0000-000000000604"), new DateTime(2025, 8, 23, 19, 14, 17, 385, DateTimeKind.Utc).AddTicks(6275), new Guid("00001804-0000-0000-0000-000000001804"), 4.30m, new Guid("00002104-0000-0000-0000-000000002104"), null, new Guid("00000301-0000-0000-0000-000000000301") },
                    { new Guid("00002305-0000-0000-0000-000000002305"), "Retail space in a busy area, good investment.", new Guid("00000605-0000-0000-0000-000000000605"), new DateTime(2025, 8, 23, 19, 14, 17, 385, DateTimeKind.Utc).AddTicks(6277), new Guid("00001805-0000-0000-0000-000000001805"), 4.60m, new Guid("00002105-0000-0000-0000-000000002105"), null, new Guid("00000302-0000-0000-0000-000000000302") }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "AmountPaid", "CreatedAt", "InvoiceId", "PaymentMethodId", "PropertyReviewId", "TransactionDate", "TransactionStatusId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("00002101-0000-0000-0000-000000002101"), 1500.00m, new DateTime(2025, 8, 23, 19, 14, 17, 387, DateTimeKind.Utc).AddTicks(6629), new Guid("00001901-0000-0000-0000-000000001901"), new Guid("00001101-0000-0000-0000-000000001101"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000701-0000-0000-0000-000000000701"), null },
                    { new Guid("00002102-0000-0000-0000-000000002102"), 3000.00m, new DateTime(2025, 8, 23, 19, 14, 17, 387, DateTimeKind.Utc).AddTicks(6634), new Guid("00001902-0000-0000-0000-000000001902"), new Guid("00001102-0000-0000-0000-000000001102"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000702-0000-0000-0000-000000000702"), null },
                    { new Guid("00002103-0000-0000-0000-000000002103"), 2000.00m, new DateTime(2025, 8, 23, 19, 14, 17, 387, DateTimeKind.Utc).AddTicks(6636), new Guid("00001903-0000-0000-0000-000000001903"), new Guid("00001103-0000-0000-0000-000000001103"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000703-0000-0000-0000-000000000703"), null },
                    { new Guid("00002104-0000-0000-0000-000000002104"), 4500.00m, new DateTime(2025, 8, 23, 19, 14, 17, 387, DateTimeKind.Utc).AddTicks(6637), new Guid("00001904-0000-0000-0000-000000001904"), new Guid("00001104-0000-0000-0000-000000001104"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000704-0000-0000-0000-000000000704"), null },
                    { new Guid("00002105-0000-0000-0000-000000002105"), 5000.00m, new DateTime(2025, 8, 23, 19, 14, 17, 387, DateTimeKind.Utc).AddTicks(6638), new Guid("00001905-0000-0000-0000-000000001905"), new Guid("00001105-0000-0000-0000-000000001105"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000701-0000-0000-0000-000000000701"), null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("00000104-0000-0000-0000-000000000104"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("00000105-0000-0000-0000-000000000105"));

            migrationBuilder.DeleteData(
                table: "NearbyPlaces",
                keyColumns: new[] { "NearbyPlaceTypeId", "PropertyId" },
                keyValues: new object[] { new Guid("00000801-0000-0000-0000-000000000801"), new Guid("00001801-0000-0000-0000-000000001801") });

            migrationBuilder.DeleteData(
                table: "NearbyPlaces",
                keyColumns: new[] { "NearbyPlaceTypeId", "PropertyId" },
                keyValues: new object[] { new Guid("00000802-0000-0000-0000-000000000802"), new Guid("00001801-0000-0000-0000-000000001801") });

            migrationBuilder.DeleteData(
                table: "NearbyPlaces",
                keyColumns: new[] { "NearbyPlaceTypeId", "PropertyId" },
                keyValues: new object[] { new Guid("00000803-0000-0000-0000-000000000803"), new Guid("00001802-0000-0000-0000-000000001802") });

            migrationBuilder.DeleteData(
                table: "NearbyPlaces",
                keyColumns: new[] { "NearbyPlaceTypeId", "PropertyId" },
                keyValues: new object[] { new Guid("00000804-0000-0000-0000-000000000804"), new Guid("00001803-0000-0000-0000-000000001803") });

            migrationBuilder.DeleteData(
                table: "NearbyPlaces",
                keyColumns: new[] { "NearbyPlaceTypeId", "PropertyId" },
                keyValues: new object[] { new Guid("00000805-0000-0000-0000-000000000805"), new Guid("00001804-0000-0000-0000-000000001804") });

            migrationBuilder.DeleteData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: new Guid("00001004-0000-0000-0000-000000001004"));

            migrationBuilder.DeleteData(
                table: "PriceUnits",
                keyColumn: "Id",
                keyValue: new Guid("00002201-0000-0000-0000-000000002201"));

            migrationBuilder.DeleteData(
                table: "PriceUnits",
                keyColumn: "Id",
                keyValue: new Guid("00002202-0000-0000-0000-000000002202"));

            migrationBuilder.DeleteData(
                table: "PriceUnits",
                keyColumn: "Id",
                keyValue: new Guid("00002203-0000-0000-0000-000000002203"));

            migrationBuilder.DeleteData(
                table: "PriceUnits",
                keyColumn: "Id",
                keyValue: new Guid("00002204-0000-0000-0000-000000002204"));

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { new Guid("00000401-0000-0000-0000-000000000401"), new Guid("00001801-0000-0000-0000-000000001801") });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { new Guid("00000402-0000-0000-0000-000000000402"), new Guid("00001801-0000-0000-0000-000000001801") });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { new Guid("00000403-0000-0000-0000-000000000403"), new Guid("00001802-0000-0000-0000-000000001802") });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { new Guid("00000404-0000-0000-0000-000000000404"), new Guid("00001803-0000-0000-0000-000000001803") });

            migrationBuilder.DeleteData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { new Guid("00000405-0000-0000-0000-000000000405"), new Guid("00001804-0000-0000-0000-000000001804") });

            migrationBuilder.DeleteData(
                table: "PropertyCategoryAssociations",
                keyColumns: new[] { "PropertyCategoryId", "PropertyId" },
                keyValues: new object[] { new Guid("00001601-0000-0000-0000-000000001601"), new Guid("00001801-0000-0000-0000-000000001801") });

            migrationBuilder.DeleteData(
                table: "PropertyCategoryAssociations",
                keyColumns: new[] { "PropertyCategoryId", "PropertyId" },
                keyValues: new object[] { new Guid("00001602-0000-0000-0000-000000001602"), new Guid("00001802-0000-0000-0000-000000001802") });

            migrationBuilder.DeleteData(
                table: "PropertyCategoryAssociations",
                keyColumns: new[] { "PropertyCategoryId", "PropertyId" },
                keyValues: new object[] { new Guid("00001603-0000-0000-0000-000000001603"), new Guid("00001803-0000-0000-0000-000000001803") });

            migrationBuilder.DeleteData(
                table: "PropertyCategoryAssociations",
                keyColumns: new[] { "PropertyCategoryId", "PropertyId" },
                keyValues: new object[] { new Guid("00001604-0000-0000-0000-000000001604"), new Guid("00001804-0000-0000-0000-000000001804") });

            migrationBuilder.DeleteData(
                table: "PropertyCategoryAssociations",
                keyColumns: new[] { "PropertyCategoryId", "PropertyId" },
                keyValues: new object[] { new Guid("00001605-0000-0000-0000-000000001605"), new Guid("00001805-0000-0000-0000-000000001805") });

            migrationBuilder.DeleteData(
                table: "PropertyFeatureAssociations",
                keyColumns: new[] { "PropertyFeatureId", "PropertyId" },
                keyValues: new object[] { new Guid("00001501-0000-0000-0000-000000001501"), new Guid("00001801-0000-0000-0000-000000001801") });

            migrationBuilder.DeleteData(
                table: "PropertyFeatureAssociations",
                keyColumns: new[] { "PropertyFeatureId", "PropertyId" },
                keyValues: new object[] { new Guid("00001502-0000-0000-0000-000000001502"), new Guid("00001802-0000-0000-0000-000000001802") });

            migrationBuilder.DeleteData(
                table: "PropertyFeatureAssociations",
                keyColumns: new[] { "PropertyFeatureId", "PropertyId" },
                keyValues: new object[] { new Guid("00001503-0000-0000-0000-000000001503"), new Guid("00001803-0000-0000-0000-000000001803") });

            migrationBuilder.DeleteData(
                table: "PropertyFeatureAssociations",
                keyColumns: new[] { "PropertyFeatureId", "PropertyId" },
                keyValues: new object[] { new Guid("00001504-0000-0000-0000-000000001504"), new Guid("00001804-0000-0000-0000-000000001804") });

            migrationBuilder.DeleteData(
                table: "PropertyFeatureAssociations",
                keyColumns: new[] { "PropertyFeatureId", "PropertyId" },
                keyValues: new object[] { new Guid("00001505-0000-0000-0000-000000001505"), new Guid("00001805-0000-0000-0000-000000001805") });

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: new Guid("00001701-0000-0000-0000-000000001701"));

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: new Guid("00001702-0000-0000-0000-000000001702"));

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: new Guid("00001703-0000-0000-0000-000000001703"));

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: new Guid("00001704-0000-0000-0000-000000001704"));

            migrationBuilder.DeleteData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: new Guid("00001705-0000-0000-0000-000000001705"));

            migrationBuilder.DeleteData(
                table: "PropertyReviews",
                keyColumn: "Id",
                keyValue: new Guid("00002301-0000-0000-0000-000000002301"));

            migrationBuilder.DeleteData(
                table: "PropertyReviews",
                keyColumn: "Id",
                keyValue: new Guid("00002302-0000-0000-0000-000000002302"));

            migrationBuilder.DeleteData(
                table: "PropertyReviews",
                keyColumn: "Id",
                keyValue: new Guid("00002303-0000-0000-0000-000000002303"));

            migrationBuilder.DeleteData(
                table: "PropertyReviews",
                keyColumn: "Id",
                keyValue: new Guid("00002304-0000-0000-0000-000000002304"));

            migrationBuilder.DeleteData(
                table: "PropertyReviews",
                keyColumn: "Id",
                keyValue: new Guid("00002305-0000-0000-0000-000000002305"));

            migrationBuilder.DeleteData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00001402-0000-0000-0000-000000001402"));

            migrationBuilder.DeleteData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00001403-0000-0000-0000-000000001403"));

            migrationBuilder.DeleteData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00001405-0000-0000-0000-000000001405"));

            migrationBuilder.DeleteData(
                table: "PropertyTourRequests",
                keyColumn: "Id",
                keyValue: new Guid("00002001-0000-0000-0000-000000002001"));

            migrationBuilder.DeleteData(
                table: "PropertyTourRequests",
                keyColumn: "Id",
                keyValue: new Guid("00002002-0000-0000-0000-000000002002"));

            migrationBuilder.DeleteData(
                table: "PropertyTourRequests",
                keyColumn: "Id",
                keyValue: new Guid("00002003-0000-0000-0000-000000002003"));

            migrationBuilder.DeleteData(
                table: "PropertyTourRequests",
                keyColumn: "Id",
                keyValue: new Guid("00002004-0000-0000-0000-000000002004"));

            migrationBuilder.DeleteData(
                table: "PropertyTourRequests",
                keyColumn: "Id",
                keyValue: new Guid("00002005-0000-0000-0000-000000002005"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("00002101-0000-0000-0000-000000002101"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("00002102-0000-0000-0000-000000002102"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("00002103-0000-0000-0000-000000002103"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("00002104-0000-0000-0000-000000002104"));

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("00002105-0000-0000-0000-000000002105"));

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: new Guid("00000401-0000-0000-0000-000000000401"));

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: new Guid("00000402-0000-0000-0000-000000000402"));

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: new Guid("00000403-0000-0000-0000-000000000403"));

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: new Guid("00000404-0000-0000-0000-000000000404"));

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: new Guid("00000405-0000-0000-0000-000000000405"));

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: new Guid("00001901-0000-0000-0000-000000001901"));

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: new Guid("00001902-0000-0000-0000-000000001902"));

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: new Guid("00001903-0000-0000-0000-000000001903"));

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: new Guid("00001904-0000-0000-0000-000000001904"));

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: new Guid("00001905-0000-0000-0000-000000001905"));

            migrationBuilder.DeleteData(
                table: "NearbyPlaceTypes",
                keyColumn: "Id",
                keyValue: new Guid("00000801-0000-0000-0000-000000000801"));

            migrationBuilder.DeleteData(
                table: "NearbyPlaceTypes",
                keyColumn: "Id",
                keyValue: new Guid("00000802-0000-0000-0000-000000000802"));

            migrationBuilder.DeleteData(
                table: "NearbyPlaceTypes",
                keyColumn: "Id",
                keyValue: new Guid("00000803-0000-0000-0000-000000000803"));

            migrationBuilder.DeleteData(
                table: "NearbyPlaceTypes",
                keyColumn: "Id",
                keyValue: new Guid("00000804-0000-0000-0000-000000000804"));

            migrationBuilder.DeleteData(
                table: "NearbyPlaceTypes",
                keyColumn: "Id",
                keyValue: new Guid("00000805-0000-0000-0000-000000000805"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("00001101-0000-0000-0000-000000001101"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("00001102-0000-0000-0000-000000001102"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("00001103-0000-0000-0000-000000001103"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("00001104-0000-0000-0000-000000001104"));

            migrationBuilder.DeleteData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("00001105-0000-0000-0000-000000001105"));

            migrationBuilder.DeleteData(
                table: "PriceUnitTypes",
                keyColumn: "Id",
                keyValue: new Guid("00001301-0000-0000-0000-000000001301"));

            migrationBuilder.DeleteData(
                table: "PriceUnitTypes",
                keyColumn: "Id",
                keyValue: new Guid("00001302-0000-0000-0000-000000001302"));

            migrationBuilder.DeleteData(
                table: "PriceUnitTypes",
                keyColumn: "Id",
                keyValue: new Guid("00001303-0000-0000-0000-000000001303"));

            migrationBuilder.DeleteData(
                table: "PriceUnitTypes",
                keyColumn: "Id",
                keyValue: new Guid("00001304-0000-0000-0000-000000001304"));

            migrationBuilder.DeleteData(
                table: "PropertyCategories",
                keyColumn: "Id",
                keyValue: new Guid("00001601-0000-0000-0000-000000001601"));

            migrationBuilder.DeleteData(
                table: "PropertyCategories",
                keyColumn: "Id",
                keyValue: new Guid("00001602-0000-0000-0000-000000001602"));

            migrationBuilder.DeleteData(
                table: "PropertyCategories",
                keyColumn: "Id",
                keyValue: new Guid("00001603-0000-0000-0000-000000001603"));

            migrationBuilder.DeleteData(
                table: "PropertyCategories",
                keyColumn: "Id",
                keyValue: new Guid("00001604-0000-0000-0000-000000001604"));

            migrationBuilder.DeleteData(
                table: "PropertyCategories",
                keyColumn: "Id",
                keyValue: new Guid("00001605-0000-0000-0000-000000001605"));

            migrationBuilder.DeleteData(
                table: "PropertyFeatures",
                keyColumn: "Id",
                keyValue: new Guid("00001501-0000-0000-0000-000000001501"));

            migrationBuilder.DeleteData(
                table: "PropertyFeatures",
                keyColumn: "Id",
                keyValue: new Guid("00001502-0000-0000-0000-000000001502"));

            migrationBuilder.DeleteData(
                table: "PropertyFeatures",
                keyColumn: "Id",
                keyValue: new Guid("00001503-0000-0000-0000-000000001503"));

            migrationBuilder.DeleteData(
                table: "PropertyFeatures",
                keyColumn: "Id",
                keyValue: new Guid("00001504-0000-0000-0000-000000001504"));

            migrationBuilder.DeleteData(
                table: "PropertyFeatures",
                keyColumn: "Id",
                keyValue: new Guid("00001505-0000-0000-0000-000000001505"));

            migrationBuilder.DeleteData(
                table: "PropertyTourRequestStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00001201-0000-0000-0000-000000001201"));

            migrationBuilder.DeleteData(
                table: "PropertyTourRequestStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00001202-0000-0000-0000-000000001202"));

            migrationBuilder.DeleteData(
                table: "PropertyTourRequestStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00001203-0000-0000-0000-000000001203"));

            migrationBuilder.DeleteData(
                table: "PropertyTourRequestStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00001204-0000-0000-0000-000000001204"));

            migrationBuilder.DeleteData(
                table: "PropertyTourRequestStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00001205-0000-0000-0000-000000001205"));

            migrationBuilder.DeleteData(
                table: "TransactionStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00000701-0000-0000-0000-000000000701"));

            migrationBuilder.DeleteData(
                table: "TransactionStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00000702-0000-0000-0000-000000000702"));

            migrationBuilder.DeleteData(
                table: "TransactionStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00000703-0000-0000-0000-000000000703"));

            migrationBuilder.DeleteData(
                table: "TransactionStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00000704-0000-0000-0000-000000000704"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("00000601-0000-0000-0000-000000000601"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("00000602-0000-0000-0000-000000000602"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("00000603-0000-0000-0000-000000000603"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("00000604-0000-0000-0000-000000000604"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("00000605-0000-0000-0000-000000000605"));

            migrationBuilder.DeleteData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00000901-0000-0000-0000-000000000901"));

            migrationBuilder.DeleteData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00000902-0000-0000-0000-000000000902"));

            migrationBuilder.DeleteData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00000903-0000-0000-0000-000000000903"));

            migrationBuilder.DeleteData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00000904-0000-0000-0000-000000000904"));

            migrationBuilder.DeleteData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00000905-0000-0000-0000-000000000905"));

            migrationBuilder.DeleteData(
                table: "ContractTypes",
                keyColumn: "Id",
                keyValue: new Guid("00000501-0000-0000-0000-000000000501"));

            migrationBuilder.DeleteData(
                table: "ContractTypes",
                keyColumn: "Id",
                keyValue: new Guid("00000502-0000-0000-0000-000000000502"));

            migrationBuilder.DeleteData(
                table: "ContractTypes",
                keyColumn: "Id",
                keyValue: new Guid("00000503-0000-0000-0000-000000000503"));

            migrationBuilder.DeleteData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: new Guid("00001001-0000-0000-0000-000000001001"));

            migrationBuilder.DeleteData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: new Guid("00001002-0000-0000-0000-000000001002"));

            migrationBuilder.DeleteData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: new Guid("00001003-0000-0000-0000-000000001003"));

            migrationBuilder.DeleteData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: new Guid("00001005-0000-0000-0000-000000001005"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("00001801-0000-0000-0000-000000001801"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("00001802-0000-0000-0000-000000001802"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("00001803-0000-0000-0000-000000001803"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("00001804-0000-0000-0000-000000001804"));

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("00001805-0000-0000-0000-000000001805"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000301-0000-0000-0000-000000000301"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000302-0000-0000-0000-000000000302"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000303-0000-0000-0000-000000000303"));

            migrationBuilder.DeleteData(
                table: "PriceUnits",
                keyColumn: "Id",
                keyValue: new Guid("00002205-0000-0000-0000-000000002205"));

            migrationBuilder.DeleteData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00001401-0000-0000-0000-000000001401"));

            migrationBuilder.DeleteData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00001404-0000-0000-0000-000000001404"));

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("00000204-0000-0000-0000-000000000204"));

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("00000205-0000-0000-0000-000000000205"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("00000102-0000-0000-0000-000000000102"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("00000103-0000-0000-0000-000000000103"));

            migrationBuilder.DeleteData(
                table: "PriceUnitTypes",
                keyColumn: "Id",
                keyValue: new Guid("00001305-0000-0000-0000-000000001305"));

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("00000201-0000-0000-0000-000000000201"));

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("00000202-0000-0000-0000-000000000202"));

            migrationBuilder.DeleteData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("00000203-0000-0000-0000-000000000203"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("00000101-0000-0000-0000-000000000101"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("00000001-0000-0000-0000-000000000001"));
        }
    }
}
