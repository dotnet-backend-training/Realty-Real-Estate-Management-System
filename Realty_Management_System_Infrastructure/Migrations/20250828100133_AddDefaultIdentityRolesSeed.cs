using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Realty_Management_System_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddDefaultIdentityRolesSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: new Guid("00000401-0000-0000-0000-000000000401"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 485, DateTimeKind.Utc).AddTicks(5699));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: new Guid("00000402-0000-0000-0000-000000000402"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 485, DateTimeKind.Utc).AddTicks(5703));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: new Guid("00000403-0000-0000-0000-000000000403"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 485, DateTimeKind.Utc).AddTicks(5704));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: new Guid("00000404-0000-0000-0000-000000000404"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 485, DateTimeKind.Utc).AddTicks(5705));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: new Guid("00000405-0000-0000-0000-000000000405"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 485, DateTimeKind.Utc).AddTicks(5706));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("00003001-0000-0000-0000-000000003001"), "b04c1030-6504-45d3-a54a-fa8935d1015a", "Admin", "ADMIN" },
                    { new Guid("00003002-0000-0000-0000-000000003002"), "efe5f642-bccf-4f75-9c26-eaf8f58f94b1", "PropertyOwner", "PROPERTYOWNER" },
                    { new Guid("00003003-0000-0000-0000-000000003003"), "884876ea-aa8e-49a3-a3aa-263d4e40078a", "BuyerTenant", "BUYERTENANT" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000301-0000-0000-0000-000000000301"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "d0396134-d32b-4231-a086-e7a57c3358df", new DateTime(2025, 8, 28, 10, 1, 32, 502, DateTimeKind.Utc).AddTicks(6615) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000302-0000-0000-0000-000000000302"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "51fb9701-b5f2-4f41-b8c2-a806e2094a18", new DateTime(2025, 8, 28, 10, 1, 32, 502, DateTimeKind.Utc).AddTicks(6641) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000303-0000-0000-0000-000000000303"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "70e4927a-b94e-41c3-99f2-2a941efc6617", new DateTime(2025, 8, 28, 10, 1, 32, 502, DateTimeKind.Utc).AddTicks(6645) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("00000101-0000-0000-0000-000000000101"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 486, DateTimeKind.Utc).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("00000102-0000-0000-0000-000000000102"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 486, DateTimeKind.Utc).AddTicks(982));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("00000103-0000-0000-0000-000000000103"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 486, DateTimeKind.Utc).AddTicks(985));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("00000104-0000-0000-0000-000000000104"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 486, DateTimeKind.Utc).AddTicks(987));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("00000105-0000-0000-0000-000000000105"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 486, DateTimeKind.Utc).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "ContractTypes",
                keyColumn: "Id",
                keyValue: new Guid("00000501-0000-0000-0000-000000000501"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 491, DateTimeKind.Utc).AddTicks(3451));

            migrationBuilder.UpdateData(
                table: "ContractTypes",
                keyColumn: "Id",
                keyValue: new Guid("00000502-0000-0000-0000-000000000502"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 491, DateTimeKind.Utc).AddTicks(3454));

            migrationBuilder.UpdateData(
                table: "ContractTypes",
                keyColumn: "Id",
                keyValue: new Guid("00000503-0000-0000-0000-000000000503"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 491, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("00000601-0000-0000-0000-000000000601"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 490, DateTimeKind.Utc).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("00000602-0000-0000-0000-000000000602"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 490, DateTimeKind.Utc).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("00000603-0000-0000-0000-000000000603"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 490, DateTimeKind.Utc).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("00000604-0000-0000-0000-000000000604"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 490, DateTimeKind.Utc).AddTicks(8676));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("00000605-0000-0000-0000-000000000605"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 490, DateTimeKind.Utc).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("00000001-0000-0000-0000-000000000001"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 491, DateTimeKind.Utc).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00000901-0000-0000-0000-000000000901"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 492, DateTimeKind.Utc).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00000902-0000-0000-0000-000000000902"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 492, DateTimeKind.Utc).AddTicks(3744));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00000903-0000-0000-0000-000000000903"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 492, DateTimeKind.Utc).AddTicks(3746));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00000904-0000-0000-0000-000000000904"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 492, DateTimeKind.Utc).AddTicks(3747));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00000905-0000-0000-0000-000000000905"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 492, DateTimeKind.Utc).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: new Guid("00001901-0000-0000-0000-000000001901"),
                columns: new[] { "CreatedAt", "DueDate", "IssueDate" },
                values: new object[] { new DateTime(2025, 8, 28, 10, 1, 32, 492, DateTimeKind.Utc).AddTicks(1960), new DateTime(2025, 9, 17, 10, 1, 32, 492, DateTimeKind.Utc).AddTicks(1968), new DateTime(2025, 8, 18, 10, 1, 32, 492, DateTimeKind.Utc).AddTicks(1962) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: new Guid("00001902-0000-0000-0000-000000001902"),
                columns: new[] { "CreatedAt", "DueDate", "IssueDate" },
                values: new object[] { new DateTime(2025, 8, 28, 10, 1, 32, 492, DateTimeKind.Utc).AddTicks(1973), new DateTime(2025, 9, 7, 10, 1, 32, 492, DateTimeKind.Utc).AddTicks(1974), new DateTime(2025, 8, 8, 10, 1, 32, 492, DateTimeKind.Utc).AddTicks(1973) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: new Guid("00001903-0000-0000-0000-000000001903"),
                columns: new[] { "CreatedAt", "DueDate", "IssueDate" },
                values: new object[] { new DateTime(2025, 8, 28, 10, 1, 32, 492, DateTimeKind.Utc).AddTicks(1975), new DateTime(2025, 8, 23, 10, 1, 32, 492, DateTimeKind.Utc).AddTicks(1976), new DateTime(2025, 7, 29, 10, 1, 32, 492, DateTimeKind.Utc).AddTicks(1976) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: new Guid("00001904-0000-0000-0000-000000001904"),
                columns: new[] { "CreatedAt", "DueDate", "IssueDate" },
                values: new object[] { new DateTime(2025, 8, 28, 10, 1, 32, 492, DateTimeKind.Utc).AddTicks(1978), new DateTime(2025, 9, 12, 10, 1, 32, 492, DateTimeKind.Utc).AddTicks(1982), new DateTime(2025, 8, 13, 10, 1, 32, 492, DateTimeKind.Utc).AddTicks(1982) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: new Guid("00001905-0000-0000-0000-000000001905"),
                columns: new[] { "CreatedAt", "DueDate", "IssueDate" },
                values: new object[] { new DateTime(2025, 8, 28, 10, 1, 32, 492, DateTimeKind.Utc).AddTicks(1984), new DateTime(2025, 9, 22, 10, 1, 32, 492, DateTimeKind.Utc).AddTicks(1985), new DateTime(2025, 8, 23, 10, 1, 32, 492, DateTimeKind.Utc).AddTicks(1984) });

            migrationBuilder.UpdateData(
                table: "NearbyPlaceTypes",
                keyColumn: "Id",
                keyValue: new Guid("00000801-0000-0000-0000-000000000801"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 493, DateTimeKind.Utc).AddTicks(1861));

            migrationBuilder.UpdateData(
                table: "NearbyPlaceTypes",
                keyColumn: "Id",
                keyValue: new Guid("00000802-0000-0000-0000-000000000802"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 493, DateTimeKind.Utc).AddTicks(1863));

            migrationBuilder.UpdateData(
                table: "NearbyPlaceTypes",
                keyColumn: "Id",
                keyValue: new Guid("00000803-0000-0000-0000-000000000803"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 493, DateTimeKind.Utc).AddTicks(1864));

            migrationBuilder.UpdateData(
                table: "NearbyPlaceTypes",
                keyColumn: "Id",
                keyValue: new Guid("00000804-0000-0000-0000-000000000804"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 493, DateTimeKind.Utc).AddTicks(1865));

            migrationBuilder.UpdateData(
                table: "NearbyPlaceTypes",
                keyColumn: "Id",
                keyValue: new Guid("00000805-0000-0000-0000-000000000805"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 493, DateTimeKind.Utc).AddTicks(1866));

            migrationBuilder.UpdateData(
                table: "NearbyPlaces",
                keyColumns: new[] { "NearbyPlaceTypeId", "PropertyId" },
                keyValues: new object[] { new Guid("00000801-0000-0000-0000-000000000801"), new Guid("00001801-0000-0000-0000-000000001801") },
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 492, DateTimeKind.Utc).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "NearbyPlaces",
                keyColumns: new[] { "NearbyPlaceTypeId", "PropertyId" },
                keyValues: new object[] { new Guid("00000802-0000-0000-0000-000000000802"), new Guid("00001801-0000-0000-0000-000000001801") },
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 492, DateTimeKind.Utc).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "NearbyPlaces",
                keyColumns: new[] { "NearbyPlaceTypeId", "PropertyId" },
                keyValues: new object[] { new Guid("00000803-0000-0000-0000-000000000803"), new Guid("00001802-0000-0000-0000-000000001802") },
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 492, DateTimeKind.Utc).AddTicks(9835));

            migrationBuilder.UpdateData(
                table: "NearbyPlaces",
                keyColumns: new[] { "NearbyPlaceTypeId", "PropertyId" },
                keyValues: new object[] { new Guid("00000804-0000-0000-0000-000000000804"), new Guid("00001803-0000-0000-0000-000000001803") },
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 492, DateTimeKind.Utc).AddTicks(9836));

            migrationBuilder.UpdateData(
                table: "NearbyPlaces",
                keyColumns: new[] { "NearbyPlaceTypeId", "PropertyId" },
                keyValues: new object[] { new Guid("00000805-0000-0000-0000-000000000805"), new Guid("00001804-0000-0000-0000-000000001804") },
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 492, DateTimeKind.Utc).AddTicks(9837));

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: new Guid("00001001-0000-0000-0000-000000001001"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 493, DateTimeKind.Utc).AddTicks(3619));

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: new Guid("00001002-0000-0000-0000-000000001002"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 493, DateTimeKind.Utc).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: new Guid("00001003-0000-0000-0000-000000001003"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 493, DateTimeKind.Utc).AddTicks(3622));

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: new Guid("00001004-0000-0000-0000-000000001004"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 493, DateTimeKind.Utc).AddTicks(3623));

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: new Guid("00001005-0000-0000-0000-000000001005"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 493, DateTimeKind.Utc).AddTicks(3625));

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("00001101-0000-0000-0000-000000001101"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 493, DateTimeKind.Utc).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("00001102-0000-0000-0000-000000001102"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 493, DateTimeKind.Utc).AddTicks(5809));

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("00001103-0000-0000-0000-000000001103"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 493, DateTimeKind.Utc).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("00001104-0000-0000-0000-000000001104"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 493, DateTimeKind.Utc).AddTicks(5811));

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("00001105-0000-0000-0000-000000001105"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 493, DateTimeKind.Utc).AddTicks(5812));

            migrationBuilder.UpdateData(
                table: "PriceUnitTypes",
                keyColumn: "Id",
                keyValue: new Guid("00001301-0000-0000-0000-000000001301"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 494, DateTimeKind.Utc).AddTicks(2553));

            migrationBuilder.UpdateData(
                table: "PriceUnitTypes",
                keyColumn: "Id",
                keyValue: new Guid("00001302-0000-0000-0000-000000001302"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 494, DateTimeKind.Utc).AddTicks(2555));

            migrationBuilder.UpdateData(
                table: "PriceUnitTypes",
                keyColumn: "Id",
                keyValue: new Guid("00001303-0000-0000-0000-000000001303"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 494, DateTimeKind.Utc).AddTicks(2557));

            migrationBuilder.UpdateData(
                table: "PriceUnitTypes",
                keyColumn: "Id",
                keyValue: new Guid("00001304-0000-0000-0000-000000001304"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 494, DateTimeKind.Utc).AddTicks(2558));

            migrationBuilder.UpdateData(
                table: "PriceUnitTypes",
                keyColumn: "Id",
                keyValue: new Guid("00001305-0000-0000-0000-000000001305"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 494, DateTimeKind.Utc).AddTicks(2559));

            migrationBuilder.UpdateData(
                table: "PriceUnits",
                keyColumn: "Id",
                keyValue: new Guid("00002201-0000-0000-0000-000000002201"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 494, DateTimeKind.Utc).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "PriceUnits",
                keyColumn: "Id",
                keyValue: new Guid("00002202-0000-0000-0000-000000002202"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 494, DateTimeKind.Utc).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "PriceUnits",
                keyColumn: "Id",
                keyValue: new Guid("00002203-0000-0000-0000-000000002203"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 494, DateTimeKind.Utc).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "PriceUnits",
                keyColumn: "Id",
                keyValue: new Guid("00002204-0000-0000-0000-000000002204"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 494, DateTimeKind.Utc).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "PriceUnits",
                keyColumn: "Id",
                keyValue: new Guid("00002205-0000-0000-0000-000000002205"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 494, DateTimeKind.Utc).AddTicks(879));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("00001801-0000-0000-0000-000000001801"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 496, DateTimeKind.Utc).AddTicks(9308));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("00001802-0000-0000-0000-000000001802"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 496, DateTimeKind.Utc).AddTicks(9324));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("00001803-0000-0000-0000-000000001803"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 496, DateTimeKind.Utc).AddTicks(9328));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("00001804-0000-0000-0000-000000001804"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 496, DateTimeKind.Utc).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("00001805-0000-0000-0000-000000001805"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 496, DateTimeKind.Utc).AddTicks(9336));

            migrationBuilder.UpdateData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { new Guid("00000401-0000-0000-0000-000000000401"), new Guid("00001801-0000-0000-0000-000000001801") },
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 494, DateTimeKind.Utc).AddTicks(6949));

            migrationBuilder.UpdateData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { new Guid("00000402-0000-0000-0000-000000000402"), new Guid("00001801-0000-0000-0000-000000001801") },
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 494, DateTimeKind.Utc).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { new Guid("00000403-0000-0000-0000-000000000403"), new Guid("00001802-0000-0000-0000-000000001802") },
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 494, DateTimeKind.Utc).AddTicks(6952));

            migrationBuilder.UpdateData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { new Guid("00000404-0000-0000-0000-000000000404"), new Guid("00001803-0000-0000-0000-000000001803") },
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 494, DateTimeKind.Utc).AddTicks(6953));

            migrationBuilder.UpdateData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { new Guid("00000405-0000-0000-0000-000000000405"), new Guid("00001804-0000-0000-0000-000000001804") },
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 494, DateTimeKind.Utc).AddTicks(6953));

            migrationBuilder.UpdateData(
                table: "PropertyCategories",
                keyColumn: "Id",
                keyValue: new Guid("00001601-0000-0000-0000-000000001601"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 495, DateTimeKind.Utc).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "PropertyCategories",
                keyColumn: "Id",
                keyValue: new Guid("00001602-0000-0000-0000-000000001602"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 495, DateTimeKind.Utc).AddTicks(7583));

            migrationBuilder.UpdateData(
                table: "PropertyCategories",
                keyColumn: "Id",
                keyValue: new Guid("00001603-0000-0000-0000-000000001603"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 495, DateTimeKind.Utc).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "PropertyCategories",
                keyColumn: "Id",
                keyValue: new Guid("00001604-0000-0000-0000-000000001604"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 495, DateTimeKind.Utc).AddTicks(7585));

            migrationBuilder.UpdateData(
                table: "PropertyCategories",
                keyColumn: "Id",
                keyValue: new Guid("00001605-0000-0000-0000-000000001605"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 495, DateTimeKind.Utc).AddTicks(7586));

            migrationBuilder.UpdateData(
                table: "PropertyCategoryAssociations",
                keyColumns: new[] { "PropertyCategoryId", "PropertyId" },
                keyValues: new object[] { new Guid("00001601-0000-0000-0000-000000001601"), new Guid("00001801-0000-0000-0000-000000001801") },
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 495, DateTimeKind.Utc).AddTicks(5535));

            migrationBuilder.UpdateData(
                table: "PropertyCategoryAssociations",
                keyColumns: new[] { "PropertyCategoryId", "PropertyId" },
                keyValues: new object[] { new Guid("00001602-0000-0000-0000-000000001602"), new Guid("00001802-0000-0000-0000-000000001802") },
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 495, DateTimeKind.Utc).AddTicks(5538));

            migrationBuilder.UpdateData(
                table: "PropertyCategoryAssociations",
                keyColumns: new[] { "PropertyCategoryId", "PropertyId" },
                keyValues: new object[] { new Guid("00001603-0000-0000-0000-000000001603"), new Guid("00001803-0000-0000-0000-000000001803") },
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 495, DateTimeKind.Utc).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "PropertyCategoryAssociations",
                keyColumns: new[] { "PropertyCategoryId", "PropertyId" },
                keyValues: new object[] { new Guid("00001604-0000-0000-0000-000000001604"), new Guid("00001804-0000-0000-0000-000000001804") },
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 495, DateTimeKind.Utc).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "PropertyCategoryAssociations",
                keyColumns: new[] { "PropertyCategoryId", "PropertyId" },
                keyValues: new object[] { new Guid("00001605-0000-0000-0000-000000001605"), new Guid("00001805-0000-0000-0000-000000001805") },
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 495, DateTimeKind.Utc).AddTicks(5540));

            migrationBuilder.UpdateData(
                table: "PropertyFeatureAssociations",
                keyColumns: new[] { "PropertyFeatureId", "PropertyId" },
                keyValues: new object[] { new Guid("00001501-0000-0000-0000-000000001501"), new Guid("00001801-0000-0000-0000-000000001801") },
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 497, DateTimeKind.Utc).AddTicks(4314));

            migrationBuilder.UpdateData(
                table: "PropertyFeatureAssociations",
                keyColumns: new[] { "PropertyFeatureId", "PropertyId" },
                keyValues: new object[] { new Guid("00001502-0000-0000-0000-000000001502"), new Guid("00001802-0000-0000-0000-000000001802") },
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 497, DateTimeKind.Utc).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "PropertyFeatureAssociations",
                keyColumns: new[] { "PropertyFeatureId", "PropertyId" },
                keyValues: new object[] { new Guid("00001503-0000-0000-0000-000000001503"), new Guid("00001803-0000-0000-0000-000000001803") },
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 497, DateTimeKind.Utc).AddTicks(4318));

            migrationBuilder.UpdateData(
                table: "PropertyFeatureAssociations",
                keyColumns: new[] { "PropertyFeatureId", "PropertyId" },
                keyValues: new object[] { new Guid("00001504-0000-0000-0000-000000001504"), new Guid("00001804-0000-0000-0000-000000001804") },
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 497, DateTimeKind.Utc).AddTicks(4318));

            migrationBuilder.UpdateData(
                table: "PropertyFeatureAssociations",
                keyColumns: new[] { "PropertyFeatureId", "PropertyId" },
                keyValues: new object[] { new Guid("00001505-0000-0000-0000-000000001505"), new Guid("00001805-0000-0000-0000-000000001805") },
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 497, DateTimeKind.Utc).AddTicks(4319));

            migrationBuilder.UpdateData(
                table: "PropertyFeatures",
                keyColumn: "Id",
                keyValue: new Guid("00001501-0000-0000-0000-000000001501"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 497, DateTimeKind.Utc).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "PropertyFeatures",
                keyColumn: "Id",
                keyValue: new Guid("00001502-0000-0000-0000-000000001502"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 497, DateTimeKind.Utc).AddTicks(6122));

            migrationBuilder.UpdateData(
                table: "PropertyFeatures",
                keyColumn: "Id",
                keyValue: new Guid("00001503-0000-0000-0000-000000001503"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 497, DateTimeKind.Utc).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "PropertyFeatures",
                keyColumn: "Id",
                keyValue: new Guid("00001504-0000-0000-0000-000000001504"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 497, DateTimeKind.Utc).AddTicks(6124));

            migrationBuilder.UpdateData(
                table: "PropertyFeatures",
                keyColumn: "Id",
                keyValue: new Guid("00001505-0000-0000-0000-000000001505"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 497, DateTimeKind.Utc).AddTicks(6125));

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: new Guid("00001701-0000-0000-0000-000000001701"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 497, DateTimeKind.Utc).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: new Guid("00001702-0000-0000-0000-000000001702"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 497, DateTimeKind.Utc).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: new Guid("00001703-0000-0000-0000-000000001703"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 497, DateTimeKind.Utc).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: new Guid("00001704-0000-0000-0000-000000001704"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 497, DateTimeKind.Utc).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: new Guid("00001705-0000-0000-0000-000000001705"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 497, DateTimeKind.Utc).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "PropertyReviews",
                keyColumn: "Id",
                keyValue: new Guid("00002301-0000-0000-0000-000000002301"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 499, DateTimeKind.Utc).AddTicks(4887));

            migrationBuilder.UpdateData(
                table: "PropertyReviews",
                keyColumn: "Id",
                keyValue: new Guid("00002302-0000-0000-0000-000000002302"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 499, DateTimeKind.Utc).AddTicks(4892));

            migrationBuilder.UpdateData(
                table: "PropertyReviews",
                keyColumn: "Id",
                keyValue: new Guid("00002303-0000-0000-0000-000000002303"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 499, DateTimeKind.Utc).AddTicks(4894));

            migrationBuilder.UpdateData(
                table: "PropertyReviews",
                keyColumn: "Id",
                keyValue: new Guid("00002304-0000-0000-0000-000000002304"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 499, DateTimeKind.Utc).AddTicks(4895));

            migrationBuilder.UpdateData(
                table: "PropertyReviews",
                keyColumn: "Id",
                keyValue: new Guid("00002305-0000-0000-0000-000000002305"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 499, DateTimeKind.Utc).AddTicks(4896));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00001401-0000-0000-0000-000000001401"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 499, DateTimeKind.Utc).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00001402-0000-0000-0000-000000001402"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 499, DateTimeKind.Utc).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00001403-0000-0000-0000-000000001403"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 499, DateTimeKind.Utc).AddTicks(7266));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00001404-0000-0000-0000-000000001404"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 499, DateTimeKind.Utc).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00001405-0000-0000-0000-000000001405"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 499, DateTimeKind.Utc).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "PropertyTourRequestStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00001201-0000-0000-0000-000000001201"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 500, DateTimeKind.Utc).AddTicks(3401));

            migrationBuilder.UpdateData(
                table: "PropertyTourRequestStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00001202-0000-0000-0000-000000001202"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 500, DateTimeKind.Utc).AddTicks(3403));

            migrationBuilder.UpdateData(
                table: "PropertyTourRequestStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00001203-0000-0000-0000-000000001203"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 500, DateTimeKind.Utc).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "PropertyTourRequestStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00001204-0000-0000-0000-000000001204"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 500, DateTimeKind.Utc).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "PropertyTourRequestStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00001205-0000-0000-0000-000000001205"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 500, DateTimeKind.Utc).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "PropertyTourRequests",
                keyColumn: "Id",
                keyValue: new Guid("00002001-0000-0000-0000-000000002001"),
                columns: new[] { "CreatedAt", "PreferredDateTime" },
                values: new object[] { new DateTime(2025, 8, 28, 10, 1, 32, 500, DateTimeKind.Utc).AddTicks(1353), new DateTime(2025, 8, 30, 20, 1, 32, 500, DateTimeKind.Utc).AddTicks(1354) });

            migrationBuilder.UpdateData(
                table: "PropertyTourRequests",
                keyColumn: "Id",
                keyValue: new Guid("00002002-0000-0000-0000-000000002002"),
                columns: new[] { "CreatedAt", "PreferredDateTime" },
                values: new object[] { new DateTime(2025, 8, 28, 10, 1, 32, 500, DateTimeKind.Utc).AddTicks(1362), new DateTime(2025, 9, 1, 0, 1, 32, 500, DateTimeKind.Utc).AddTicks(1363) });

            migrationBuilder.UpdateData(
                table: "PropertyTourRequests",
                keyColumn: "Id",
                keyValue: new Guid("00002003-0000-0000-0000-000000002003"),
                columns: new[] { "CreatedAt", "PreferredDateTime" },
                values: new object[] { new DateTime(2025, 8, 28, 10, 1, 32, 500, DateTimeKind.Utc).AddTicks(1364), new DateTime(2025, 8, 30, 2, 1, 32, 500, DateTimeKind.Utc).AddTicks(1364) });

            migrationBuilder.UpdateData(
                table: "PropertyTourRequests",
                keyColumn: "Id",
                keyValue: new Guid("00002004-0000-0000-0000-000000002004"),
                columns: new[] { "CreatedAt", "PreferredDateTime" },
                values: new object[] { new DateTime(2025, 8, 28, 10, 1, 32, 500, DateTimeKind.Utc).AddTicks(1365), new DateTime(2025, 9, 2, 21, 1, 32, 500, DateTimeKind.Utc).AddTicks(1366) });

            migrationBuilder.UpdateData(
                table: "PropertyTourRequests",
                keyColumn: "Id",
                keyValue: new Guid("00002005-0000-0000-0000-000000002005"),
                columns: new[] { "CreatedAt", "PreferredDateTime" },
                values: new object[] { new DateTime(2025, 8, 28, 10, 1, 32, 500, DateTimeKind.Utc).AddTicks(1367), new DateTime(2025, 9, 1, 19, 1, 32, 500, DateTimeKind.Utc).AddTicks(1367) });

            migrationBuilder.UpdateData(
                table: "TransactionStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00000701-0000-0000-0000-000000000701"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 502, DateTimeKind.Utc).AddTicks(478));

            migrationBuilder.UpdateData(
                table: "TransactionStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00000702-0000-0000-0000-000000000702"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 502, DateTimeKind.Utc).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "TransactionStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00000703-0000-0000-0000-000000000703"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 502, DateTimeKind.Utc).AddTicks(481));

            migrationBuilder.UpdateData(
                table: "TransactionStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00000704-0000-0000-0000-000000000704"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 502, DateTimeKind.Utc).AddTicks(482));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("00002101-0000-0000-0000-000000002101"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 501, DateTimeKind.Utc).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("00002102-0000-0000-0000-000000002102"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 501, DateTimeKind.Utc).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("00002103-0000-0000-0000-000000002103"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 501, DateTimeKind.Utc).AddTicks(8489));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("00002104-0000-0000-0000-000000002104"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 501, DateTimeKind.Utc).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("00002105-0000-0000-0000-000000002105"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 501, DateTimeKind.Utc).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("00000201-0000-0000-0000-000000000201"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 502, DateTimeKind.Utc).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("00000202-0000-0000-0000-000000000202"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 502, DateTimeKind.Utc).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("00000203-0000-0000-0000-000000000203"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 502, DateTimeKind.Utc).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("00000204-0000-0000-0000-000000000204"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 502, DateTimeKind.Utc).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("00000205-0000-0000-0000-000000000205"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 28, 10, 1, 32, 502, DateTimeKind.Utc).AddTicks(9093));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("00003001-0000-0000-0000-000000003001"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("00003002-0000-0000-0000-000000003002"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("00003003-0000-0000-0000-000000003003"));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: new Guid("00000401-0000-0000-0000-000000000401"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 369, DateTimeKind.Utc).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: new Guid("00000402-0000-0000-0000-000000000402"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 369, DateTimeKind.Utc).AddTicks(9401));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: new Guid("00000403-0000-0000-0000-000000000403"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 369, DateTimeKind.Utc).AddTicks(9402));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: new Guid("00000404-0000-0000-0000-000000000404"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 369, DateTimeKind.Utc).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: new Guid("00000405-0000-0000-0000-000000000405"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 369, DateTimeKind.Utc).AddTicks(9404));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000301-0000-0000-0000-000000000301"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "ec201e1b-7fa2-4bc4-9019-0dc97a3be772", new DateTime(2025, 8, 23, 19, 14, 17, 388, DateTimeKind.Utc).AddTicks(4447) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000302-0000-0000-0000-000000000302"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "34141a40-c5cf-4363-a888-d59906e5e618", new DateTime(2025, 8, 23, 19, 14, 17, 388, DateTimeKind.Utc).AddTicks(4534) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("00000303-0000-0000-0000-000000000303"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt" },
                values: new object[] { "e20a09e9-7211-4739-86d0-4c2e39f53d11", new DateTime(2025, 8, 23, 19, 14, 17, 388, DateTimeKind.Utc).AddTicks(4539) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("00000101-0000-0000-0000-000000000101"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 370, DateTimeKind.Utc).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("00000102-0000-0000-0000-000000000102"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 370, DateTimeKind.Utc).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("00000103-0000-0000-0000-000000000103"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 370, DateTimeKind.Utc).AddTicks(5149));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("00000104-0000-0000-0000-000000000104"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 370, DateTimeKind.Utc).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: new Guid("00000105-0000-0000-0000-000000000105"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 370, DateTimeKind.Utc).AddTicks(5161));

            migrationBuilder.UpdateData(
                table: "ContractTypes",
                keyColumn: "Id",
                keyValue: new Guid("00000501-0000-0000-0000-000000000501"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 375, DateTimeKind.Utc).AddTicks(4263));

            migrationBuilder.UpdateData(
                table: "ContractTypes",
                keyColumn: "Id",
                keyValue: new Guid("00000502-0000-0000-0000-000000000502"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 375, DateTimeKind.Utc).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "ContractTypes",
                keyColumn: "Id",
                keyValue: new Guid("00000503-0000-0000-0000-000000000503"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 375, DateTimeKind.Utc).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("00000601-0000-0000-0000-000000000601"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 375, DateTimeKind.Utc).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("00000602-0000-0000-0000-000000000602"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 375, DateTimeKind.Utc).AddTicks(2033));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("00000603-0000-0000-0000-000000000603"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 375, DateTimeKind.Utc).AddTicks(2036));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("00000604-0000-0000-0000-000000000604"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 375, DateTimeKind.Utc).AddTicks(2038));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("00000605-0000-0000-0000-000000000605"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 375, DateTimeKind.Utc).AddTicks(2041));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("00000001-0000-0000-0000-000000000001"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 375, DateTimeKind.Utc).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00000901-0000-0000-0000-000000000901"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 376, DateTimeKind.Utc).AddTicks(5238));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00000902-0000-0000-0000-000000000902"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 376, DateTimeKind.Utc).AddTicks(5241));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00000903-0000-0000-0000-000000000903"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 376, DateTimeKind.Utc).AddTicks(5242));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00000904-0000-0000-0000-000000000904"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 376, DateTimeKind.Utc).AddTicks(5243));

            migrationBuilder.UpdateData(
                table: "InvoiceStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00000905-0000-0000-0000-000000000905"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 376, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: new Guid("00001901-0000-0000-0000-000000001901"),
                columns: new[] { "CreatedAt", "DueDate", "IssueDate" },
                values: new object[] { new DateTime(2025, 8, 23, 19, 14, 17, 376, DateTimeKind.Utc).AddTicks(3054), new DateTime(2025, 9, 12, 19, 14, 17, 376, DateTimeKind.Utc).AddTicks(3062), new DateTime(2025, 8, 13, 19, 14, 17, 376, DateTimeKind.Utc).AddTicks(3056) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: new Guid("00001902-0000-0000-0000-000000001902"),
                columns: new[] { "CreatedAt", "DueDate", "IssueDate" },
                values: new object[] { new DateTime(2025, 8, 23, 19, 14, 17, 376, DateTimeKind.Utc).AddTicks(3064), new DateTime(2025, 9, 2, 19, 14, 17, 376, DateTimeKind.Utc).AddTicks(3065), new DateTime(2025, 8, 3, 19, 14, 17, 376, DateTimeKind.Utc).AddTicks(3065) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: new Guid("00001903-0000-0000-0000-000000001903"),
                columns: new[] { "CreatedAt", "DueDate", "IssueDate" },
                values: new object[] { new DateTime(2025, 8, 23, 19, 14, 17, 376, DateTimeKind.Utc).AddTicks(3067), new DateTime(2025, 8, 18, 19, 14, 17, 376, DateTimeKind.Utc).AddTicks(3068), new DateTime(2025, 7, 24, 19, 14, 17, 376, DateTimeKind.Utc).AddTicks(3068) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: new Guid("00001904-0000-0000-0000-000000001904"),
                columns: new[] { "CreatedAt", "DueDate", "IssueDate" },
                values: new object[] { new DateTime(2025, 8, 23, 19, 14, 17, 376, DateTimeKind.Utc).AddTicks(3070), new DateTime(2025, 9, 7, 19, 14, 17, 376, DateTimeKind.Utc).AddTicks(3071), new DateTime(2025, 8, 8, 19, 14, 17, 376, DateTimeKind.Utc).AddTicks(3070) });

            migrationBuilder.UpdateData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: new Guid("00001905-0000-0000-0000-000000001905"),
                columns: new[] { "CreatedAt", "DueDate", "IssueDate" },
                values: new object[] { new DateTime(2025, 8, 23, 19, 14, 17, 376, DateTimeKind.Utc).AddTicks(3072), new DateTime(2025, 9, 17, 19, 14, 17, 376, DateTimeKind.Utc).AddTicks(3073), new DateTime(2025, 8, 18, 19, 14, 17, 376, DateTimeKind.Utc).AddTicks(3073) });

            migrationBuilder.UpdateData(
                table: "NearbyPlaceTypes",
                keyColumn: "Id",
                keyValue: new Guid("00000801-0000-0000-0000-000000000801"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 377, DateTimeKind.Utc).AddTicks(4013));

            migrationBuilder.UpdateData(
                table: "NearbyPlaceTypes",
                keyColumn: "Id",
                keyValue: new Guid("00000802-0000-0000-0000-000000000802"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 377, DateTimeKind.Utc).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "NearbyPlaceTypes",
                keyColumn: "Id",
                keyValue: new Guid("00000803-0000-0000-0000-000000000803"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 377, DateTimeKind.Utc).AddTicks(4024));

            migrationBuilder.UpdateData(
                table: "NearbyPlaceTypes",
                keyColumn: "Id",
                keyValue: new Guid("00000804-0000-0000-0000-000000000804"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 377, DateTimeKind.Utc).AddTicks(4025));

            migrationBuilder.UpdateData(
                table: "NearbyPlaceTypes",
                keyColumn: "Id",
                keyValue: new Guid("00000805-0000-0000-0000-000000000805"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 377, DateTimeKind.Utc).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "NearbyPlaces",
                keyColumns: new[] { "NearbyPlaceTypeId", "PropertyId" },
                keyValues: new object[] { new Guid("00000801-0000-0000-0000-000000000801"), new Guid("00001801-0000-0000-0000-000000001801") },
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 377, DateTimeKind.Utc).AddTicks(1206));

            migrationBuilder.UpdateData(
                table: "NearbyPlaces",
                keyColumns: new[] { "NearbyPlaceTypeId", "PropertyId" },
                keyValues: new object[] { new Guid("00000802-0000-0000-0000-000000000802"), new Guid("00001801-0000-0000-0000-000000001801") },
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 377, DateTimeKind.Utc).AddTicks(1209));

            migrationBuilder.UpdateData(
                table: "NearbyPlaces",
                keyColumns: new[] { "NearbyPlaceTypeId", "PropertyId" },
                keyValues: new object[] { new Guid("00000803-0000-0000-0000-000000000803"), new Guid("00001802-0000-0000-0000-000000001802") },
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 377, DateTimeKind.Utc).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "NearbyPlaces",
                keyColumns: new[] { "NearbyPlaceTypeId", "PropertyId" },
                keyValues: new object[] { new Guid("00000804-0000-0000-0000-000000000804"), new Guid("00001803-0000-0000-0000-000000001803") },
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 377, DateTimeKind.Utc).AddTicks(1211));

            migrationBuilder.UpdateData(
                table: "NearbyPlaces",
                keyColumns: new[] { "NearbyPlaceTypeId", "PropertyId" },
                keyValues: new object[] { new Guid("00000805-0000-0000-0000-000000000805"), new Guid("00001804-0000-0000-0000-000000001804") },
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 377, DateTimeKind.Utc).AddTicks(1212));

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: new Guid("00001001-0000-0000-0000-000000001001"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 377, DateTimeKind.Utc).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: new Guid("00001002-0000-0000-0000-000000001002"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 377, DateTimeKind.Utc).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: new Guid("00001003-0000-0000-0000-000000001003"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 377, DateTimeKind.Utc).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: new Guid("00001004-0000-0000-0000-000000001004"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 377, DateTimeKind.Utc).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "PaymentFrequencies",
                keyColumn: "Id",
                keyValue: new Guid("00001005-0000-0000-0000-000000001005"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 377, DateTimeKind.Utc).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("00001101-0000-0000-0000-000000001101"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 377, DateTimeKind.Utc).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("00001102-0000-0000-0000-000000001102"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 377, DateTimeKind.Utc).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("00001103-0000-0000-0000-000000001103"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 377, DateTimeKind.Utc).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("00001104-0000-0000-0000-000000001104"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 377, DateTimeKind.Utc).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "PaymentMethods",
                keyColumn: "Id",
                keyValue: new Guid("00001105-0000-0000-0000-000000001105"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 377, DateTimeKind.Utc).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "PriceUnitTypes",
                keyColumn: "Id",
                keyValue: new Guid("00001301-0000-0000-0000-000000001301"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 378, DateTimeKind.Utc).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "PriceUnitTypes",
                keyColumn: "Id",
                keyValue: new Guid("00001302-0000-0000-0000-000000001302"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 378, DateTimeKind.Utc).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "PriceUnitTypes",
                keyColumn: "Id",
                keyValue: new Guid("00001303-0000-0000-0000-000000001303"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 378, DateTimeKind.Utc).AddTicks(6755));

            migrationBuilder.UpdateData(
                table: "PriceUnitTypes",
                keyColumn: "Id",
                keyValue: new Guid("00001304-0000-0000-0000-000000001304"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 378, DateTimeKind.Utc).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "PriceUnitTypes",
                keyColumn: "Id",
                keyValue: new Guid("00001305-0000-0000-0000-000000001305"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 378, DateTimeKind.Utc).AddTicks(6765));

            migrationBuilder.UpdateData(
                table: "PriceUnits",
                keyColumn: "Id",
                keyValue: new Guid("00002201-0000-0000-0000-000000002201"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 378, DateTimeKind.Utc).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "PriceUnits",
                keyColumn: "Id",
                keyValue: new Guid("00002202-0000-0000-0000-000000002202"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 378, DateTimeKind.Utc).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "PriceUnits",
                keyColumn: "Id",
                keyValue: new Guid("00002203-0000-0000-0000-000000002203"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 378, DateTimeKind.Utc).AddTicks(4187));

            migrationBuilder.UpdateData(
                table: "PriceUnits",
                keyColumn: "Id",
                keyValue: new Guid("00002204-0000-0000-0000-000000002204"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 378, DateTimeKind.Utc).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "PriceUnits",
                keyColumn: "Id",
                keyValue: new Guid("00002205-0000-0000-0000-000000002205"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 378, DateTimeKind.Utc).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("00001801-0000-0000-0000-000000001801"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 381, DateTimeKind.Utc).AddTicks(8877));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("00001802-0000-0000-0000-000000001802"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 381, DateTimeKind.Utc).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("00001803-0000-0000-0000-000000001803"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 381, DateTimeKind.Utc).AddTicks(8904));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("00001804-0000-0000-0000-000000001804"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 381, DateTimeKind.Utc).AddTicks(8909));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: new Guid("00001805-0000-0000-0000-000000001805"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 381, DateTimeKind.Utc).AddTicks(8913));

            migrationBuilder.UpdateData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { new Guid("00000401-0000-0000-0000-000000000401"), new Guid("00001801-0000-0000-0000-000000001801") },
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 379, DateTimeKind.Utc).AddTicks(1452));

            migrationBuilder.UpdateData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { new Guid("00000402-0000-0000-0000-000000000402"), new Guid("00001801-0000-0000-0000-000000001801") },
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 379, DateTimeKind.Utc).AddTicks(1454));

            migrationBuilder.UpdateData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { new Guid("00000403-0000-0000-0000-000000000403"), new Guid("00001802-0000-0000-0000-000000001802") },
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 379, DateTimeKind.Utc).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { new Guid("00000404-0000-0000-0000-000000000404"), new Guid("00001803-0000-0000-0000-000000001803") },
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 379, DateTimeKind.Utc).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "PropertyAmenities",
                keyColumns: new[] { "AmenityId", "PropertyId" },
                keyValues: new object[] { new Guid("00000405-0000-0000-0000-000000000405"), new Guid("00001804-0000-0000-0000-000000001804") },
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 379, DateTimeKind.Utc).AddTicks(1456));

            migrationBuilder.UpdateData(
                table: "PropertyCategories",
                keyColumn: "Id",
                keyValue: new Guid("00001601-0000-0000-0000-000000001601"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 379, DateTimeKind.Utc).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "PropertyCategories",
                keyColumn: "Id",
                keyValue: new Guid("00001602-0000-0000-0000-000000001602"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 379, DateTimeKind.Utc).AddTicks(9809));

            migrationBuilder.UpdateData(
                table: "PropertyCategories",
                keyColumn: "Id",
                keyValue: new Guid("00001603-0000-0000-0000-000000001603"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 379, DateTimeKind.Utc).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "PropertyCategories",
                keyColumn: "Id",
                keyValue: new Guid("00001604-0000-0000-0000-000000001604"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 379, DateTimeKind.Utc).AddTicks(9811));

            migrationBuilder.UpdateData(
                table: "PropertyCategories",
                keyColumn: "Id",
                keyValue: new Guid("00001605-0000-0000-0000-000000001605"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 379, DateTimeKind.Utc).AddTicks(9812));

            migrationBuilder.UpdateData(
                table: "PropertyCategoryAssociations",
                keyColumns: new[] { "PropertyCategoryId", "PropertyId" },
                keyValues: new object[] { new Guid("00001601-0000-0000-0000-000000001601"), new Guid("00001801-0000-0000-0000-000000001801") },
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 379, DateTimeKind.Utc).AddTicks(7996));

            migrationBuilder.UpdateData(
                table: "PropertyCategoryAssociations",
                keyColumns: new[] { "PropertyCategoryId", "PropertyId" },
                keyValues: new object[] { new Guid("00001602-0000-0000-0000-000000001602"), new Guid("00001802-0000-0000-0000-000000001802") },
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 379, DateTimeKind.Utc).AddTicks(7998));

            migrationBuilder.UpdateData(
                table: "PropertyCategoryAssociations",
                keyColumns: new[] { "PropertyCategoryId", "PropertyId" },
                keyValues: new object[] { new Guid("00001603-0000-0000-0000-000000001603"), new Guid("00001803-0000-0000-0000-000000001803") },
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 379, DateTimeKind.Utc).AddTicks(7999));

            migrationBuilder.UpdateData(
                table: "PropertyCategoryAssociations",
                keyColumns: new[] { "PropertyCategoryId", "PropertyId" },
                keyValues: new object[] { new Guid("00001604-0000-0000-0000-000000001604"), new Guid("00001804-0000-0000-0000-000000001804") },
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 379, DateTimeKind.Utc).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "PropertyCategoryAssociations",
                keyColumns: new[] { "PropertyCategoryId", "PropertyId" },
                keyValues: new object[] { new Guid("00001605-0000-0000-0000-000000001605"), new Guid("00001805-0000-0000-0000-000000001805") },
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 379, DateTimeKind.Utc).AddTicks(8001));

            migrationBuilder.UpdateData(
                table: "PropertyFeatureAssociations",
                keyColumns: new[] { "PropertyFeatureId", "PropertyId" },
                keyValues: new object[] { new Guid("00001501-0000-0000-0000-000000001501"), new Guid("00001801-0000-0000-0000-000000001801") },
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 382, DateTimeKind.Utc).AddTicks(9777));

            migrationBuilder.UpdateData(
                table: "PropertyFeatureAssociations",
                keyColumns: new[] { "PropertyFeatureId", "PropertyId" },
                keyValues: new object[] { new Guid("00001502-0000-0000-0000-000000001502"), new Guid("00001802-0000-0000-0000-000000001802") },
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 382, DateTimeKind.Utc).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "PropertyFeatureAssociations",
                keyColumns: new[] { "PropertyFeatureId", "PropertyId" },
                keyValues: new object[] { new Guid("00001503-0000-0000-0000-000000001503"), new Guid("00001803-0000-0000-0000-000000001803") },
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 382, DateTimeKind.Utc).AddTicks(9786));

            migrationBuilder.UpdateData(
                table: "PropertyFeatureAssociations",
                keyColumns: new[] { "PropertyFeatureId", "PropertyId" },
                keyValues: new object[] { new Guid("00001504-0000-0000-0000-000000001504"), new Guid("00001804-0000-0000-0000-000000001804") },
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 382, DateTimeKind.Utc).AddTicks(9787));

            migrationBuilder.UpdateData(
                table: "PropertyFeatureAssociations",
                keyColumns: new[] { "PropertyFeatureId", "PropertyId" },
                keyValues: new object[] { new Guid("00001505-0000-0000-0000-000000001505"), new Guid("00001805-0000-0000-0000-000000001805") },
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 382, DateTimeKind.Utc).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "PropertyFeatures",
                keyColumn: "Id",
                keyValue: new Guid("00001501-0000-0000-0000-000000001501"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 383, DateTimeKind.Utc).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "PropertyFeatures",
                keyColumn: "Id",
                keyValue: new Guid("00001502-0000-0000-0000-000000001502"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 383, DateTimeKind.Utc).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "PropertyFeatures",
                keyColumn: "Id",
                keyValue: new Guid("00001503-0000-0000-0000-000000001503"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 383, DateTimeKind.Utc).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "PropertyFeatures",
                keyColumn: "Id",
                keyValue: new Guid("00001504-0000-0000-0000-000000001504"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 383, DateTimeKind.Utc).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "PropertyFeatures",
                keyColumn: "Id",
                keyValue: new Guid("00001505-0000-0000-0000-000000001505"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 383, DateTimeKind.Utc).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: new Guid("00001701-0000-0000-0000-000000001701"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 383, DateTimeKind.Utc).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: new Guid("00001702-0000-0000-0000-000000001702"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 383, DateTimeKind.Utc).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: new Guid("00001703-0000-0000-0000-000000001703"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 383, DateTimeKind.Utc).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: new Guid("00001704-0000-0000-0000-000000001704"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 383, DateTimeKind.Utc).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "PropertyImages",
                keyColumn: "Id",
                keyValue: new Guid("00001705-0000-0000-0000-000000001705"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 383, DateTimeKind.Utc).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "PropertyReviews",
                keyColumn: "Id",
                keyValue: new Guid("00002301-0000-0000-0000-000000002301"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 385, DateTimeKind.Utc).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "PropertyReviews",
                keyColumn: "Id",
                keyValue: new Guid("00002302-0000-0000-0000-000000002302"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 385, DateTimeKind.Utc).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "PropertyReviews",
                keyColumn: "Id",
                keyValue: new Guid("00002303-0000-0000-0000-000000002303"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 385, DateTimeKind.Utc).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "PropertyReviews",
                keyColumn: "Id",
                keyValue: new Guid("00002304-0000-0000-0000-000000002304"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 385, DateTimeKind.Utc).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "PropertyReviews",
                keyColumn: "Id",
                keyValue: new Guid("00002305-0000-0000-0000-000000002305"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 385, DateTimeKind.Utc).AddTicks(6277));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00001401-0000-0000-0000-000000001401"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 385, DateTimeKind.Utc).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00001402-0000-0000-0000-000000001402"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 385, DateTimeKind.Utc).AddTicks(8171));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00001403-0000-0000-0000-000000001403"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 385, DateTimeKind.Utc).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00001404-0000-0000-0000-000000001404"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 385, DateTimeKind.Utc).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "PropertyStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00001405-0000-0000-0000-000000001405"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 385, DateTimeKind.Utc).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "PropertyTourRequestStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00001201-0000-0000-0000-000000001201"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 386, DateTimeKind.Utc).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "PropertyTourRequestStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00001202-0000-0000-0000-000000001202"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 386, DateTimeKind.Utc).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "PropertyTourRequestStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00001203-0000-0000-0000-000000001203"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 386, DateTimeKind.Utc).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "PropertyTourRequestStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00001204-0000-0000-0000-000000001204"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 386, DateTimeKind.Utc).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "PropertyTourRequestStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00001205-0000-0000-0000-000000001205"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 386, DateTimeKind.Utc).AddTicks(3928));

            migrationBuilder.UpdateData(
                table: "PropertyTourRequests",
                keyColumn: "Id",
                keyValue: new Guid("00002001-0000-0000-0000-000000002001"),
                columns: new[] { "CreatedAt", "PreferredDateTime" },
                values: new object[] { new DateTime(2025, 8, 23, 19, 14, 17, 386, DateTimeKind.Utc).AddTicks(2040), new DateTime(2025, 8, 26, 5, 14, 17, 386, DateTimeKind.Utc).AddTicks(2041) });

            migrationBuilder.UpdateData(
                table: "PropertyTourRequests",
                keyColumn: "Id",
                keyValue: new Guid("00002002-0000-0000-0000-000000002002"),
                columns: new[] { "CreatedAt", "PreferredDateTime" },
                values: new object[] { new DateTime(2025, 8, 23, 19, 14, 17, 386, DateTimeKind.Utc).AddTicks(2049), new DateTime(2025, 8, 27, 9, 14, 17, 386, DateTimeKind.Utc).AddTicks(2050) });

            migrationBuilder.UpdateData(
                table: "PropertyTourRequests",
                keyColumn: "Id",
                keyValue: new Guid("00002003-0000-0000-0000-000000002003"),
                columns: new[] { "CreatedAt", "PreferredDateTime" },
                values: new object[] { new DateTime(2025, 8, 23, 19, 14, 17, 386, DateTimeKind.Utc).AddTicks(2052), new DateTime(2025, 8, 25, 11, 14, 17, 386, DateTimeKind.Utc).AddTicks(2052) });

            migrationBuilder.UpdateData(
                table: "PropertyTourRequests",
                keyColumn: "Id",
                keyValue: new Guid("00002004-0000-0000-0000-000000002004"),
                columns: new[] { "CreatedAt", "PreferredDateTime" },
                values: new object[] { new DateTime(2025, 8, 23, 19, 14, 17, 386, DateTimeKind.Utc).AddTicks(2053), new DateTime(2025, 8, 29, 6, 14, 17, 386, DateTimeKind.Utc).AddTicks(2054) });

            migrationBuilder.UpdateData(
                table: "PropertyTourRequests",
                keyColumn: "Id",
                keyValue: new Guid("00002005-0000-0000-0000-000000002005"),
                columns: new[] { "CreatedAt", "PreferredDateTime" },
                values: new object[] { new DateTime(2025, 8, 23, 19, 14, 17, 386, DateTimeKind.Utc).AddTicks(2055), new DateTime(2025, 8, 28, 4, 14, 17, 386, DateTimeKind.Utc).AddTicks(2056) });

            migrationBuilder.UpdateData(
                table: "TransactionStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00000701-0000-0000-0000-000000000701"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 387, DateTimeKind.Utc).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "TransactionStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00000702-0000-0000-0000-000000000702"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 387, DateTimeKind.Utc).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "TransactionStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00000703-0000-0000-0000-000000000703"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 387, DateTimeKind.Utc).AddTicks(8469));

            migrationBuilder.UpdateData(
                table: "TransactionStatuses",
                keyColumn: "Id",
                keyValue: new Guid("00000704-0000-0000-0000-000000000704"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 387, DateTimeKind.Utc).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("00002101-0000-0000-0000-000000002101"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 387, DateTimeKind.Utc).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("00002102-0000-0000-0000-000000002102"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 387, DateTimeKind.Utc).AddTicks(6634));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("00002103-0000-0000-0000-000000002103"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 387, DateTimeKind.Utc).AddTicks(6636));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("00002104-0000-0000-0000-000000002104"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 387, DateTimeKind.Utc).AddTicks(6637));

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: new Guid("00002105-0000-0000-0000-000000002105"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 387, DateTimeKind.Utc).AddTicks(6638));

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("00000201-0000-0000-0000-000000000201"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 388, DateTimeKind.Utc).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("00000202-0000-0000-0000-000000000202"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 388, DateTimeKind.Utc).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("00000203-0000-0000-0000-000000000203"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 388, DateTimeKind.Utc).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("00000204-0000-0000-0000-000000000204"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 388, DateTimeKind.Utc).AddTicks(7788));

            migrationBuilder.UpdateData(
                table: "Zones",
                keyColumn: "Id",
                keyValue: new Guid("00000205-0000-0000-0000-000000000205"),
                column: "CreatedAt",
                value: new DateTime(2025, 8, 23, 19, 14, 17, 388, DateTimeKind.Utc).AddTicks(7791));
        }
    }
}
