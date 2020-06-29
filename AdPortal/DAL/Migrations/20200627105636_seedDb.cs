using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class seedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("37cb6c15-d2a8-4014-8e32-714960d94a98"), new DateTime(2020, 6, 27, 13, 56, 35, 538, DateTimeKind.Local).AddTicks(871), "Automobilis" },
                    { new Guid("00d6e706-796a-4f31-b67f-268a54ed6214"), new DateTime(2020, 6, 27, 13, 56, 35, 538, DateTimeKind.Local).AddTicks(1825), "Motociklas" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "CreatedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("a8b1912f-fd7a-4f0a-854b-826647b7b751"), new DateTime(2020, 6, 27, 13, 56, 35, 539, DateTimeKind.Local).AddTicks(9059), "Balta" },
                    { new Guid("000c8e1a-634e-417a-93b5-20f1988f38db"), new DateTime(2020, 6, 27, 13, 56, 35, 539, DateTimeKind.Local).AddTicks(9921), "Juoda" }
                });

            migrationBuilder.InsertData(
                table: "Conditions",
                columns: new[] { "Id", "CreatedOn", "VehicCondition" },
                values: new object[,]
                {
                    { new Guid("4accde61-fa49-4b36-92c6-5da804871157"), new DateTime(2020, 6, 27, 13, 56, 35, 540, DateTimeKind.Local).AddTicks(1063), "Naudota" },
                    { new Guid("64cc1fe3-828c-440b-8bf0-da5b724dfeea"), new DateTime(2020, 6, 27, 13, 56, 35, 540, DateTimeKind.Local).AddTicks(1887), "Nauja" }
                });

            migrationBuilder.InsertData(
                table: "Coolings",
                columns: new[] { "Id", "CoolingType", "CreatedOn" },
                values: new object[,]
                {
                    { new Guid("ae8db698-6a0d-488e-b4e0-02fceac72488"), "Oru", new DateTime(2020, 6, 27, 13, 56, 35, 540, DateTimeKind.Local).AddTicks(3020) },
                    { new Guid("9300e26c-33bf-4916-87a4-936cb6854220"), "Vandeniu", new DateTime(2020, 6, 27, 13, 56, 35, 540, DateTimeKind.Local).AddTicks(3836) }
                });

            migrationBuilder.InsertData(
                table: "Defects",
                columns: new[] { "Id", "CreatedOn", "Defect" },
                values: new object[,]
                {
                    { new Guid("111ce923-5ff8-4f90-8327-4b3af451505a"), new DateTime(2020, 6, 27, 13, 56, 35, 540, DateTimeKind.Local).AddTicks(4930), "Be defetkų" },
                    { new Guid("5abdaced-5867-44ec-a519-18a6335481ba"), new DateTime(2020, 6, 27, 13, 56, 35, 540, DateTimeKind.Local).AddTicks(5724), "Degęs" }
                });

            migrationBuilder.InsertData(
                table: "Diameters",
                columns: new[] { "Id", "CreatedOn", "TireDiameter" },
                values: new object[,]
                {
                    { new Guid("0ac83b71-2d70-4a3b-80e3-a49ba873bf69"), new DateTime(2020, 6, 27, 13, 56, 35, 540, DateTimeKind.Local).AddTicks(7767), 18m },
                    { new Guid("3f9f8c27-184d-412e-b467-9e2aebe4f1c7"), new DateTime(2020, 6, 27, 13, 56, 35, 540, DateTimeKind.Local).AddTicks(6828), 17m }
                });

            migrationBuilder.InsertData(
                table: "Doors",
                columns: new[] { "Id", "CreatedOn", "DoorCount" },
                values: new object[,]
                {
                    { new Guid("cb4652ff-ddf6-4f5f-b692-2d2d1d04b241"), new DateTime(2020, 6, 27, 13, 56, 35, 540, DateTimeKind.Local).AddTicks(8846), "4/5" },
                    { new Guid("7254b27a-b186-431c-a05a-f99527636d5b"), new DateTime(2020, 6, 27, 13, 56, 35, 540, DateTimeKind.Local).AddTicks(9632), "2/3" }
                });

            migrationBuilder.InsertData(
                table: "FrameTypes",
                columns: new[] { "Id", "CreatedOn", "Type" },
                values: new object[,]
                {
                    { new Guid("962419fd-6cc1-4800-b7d2-6467fc86b1af"), new DateTime(2020, 6, 27, 13, 56, 35, 541, DateTimeKind.Local).AddTicks(710), "Universalas" },
                    { new Guid("db571b79-ff10-4b06-a801-84300c7e3d89"), new DateTime(2020, 6, 27, 13, 56, 35, 541, DateTimeKind.Local).AddTicks(1490), "Sedanas" }
                });

            migrationBuilder.InsertData(
                table: "FuelTypes",
                columns: new[] { "Id", "CreatedOn", "Type" },
                values: new object[,]
                {
                    { new Guid("9209291d-fce2-451f-84db-c6bea335d611"), new DateTime(2020, 6, 27, 13, 56, 35, 541, DateTimeKind.Local).AddTicks(2548), "Benzinas" },
                    { new Guid("813e7104-a375-494d-ad23-d24597a99235"), new DateTime(2020, 6, 27, 13, 56, 35, 541, DateTimeKind.Local).AddTicks(3346), "Dyzelinas" }
                });

            migrationBuilder.InsertData(
                table: "Heights",
                columns: new[] { "Id", "CreatedOn", "TireHeight" },
                values: new object[,]
                {
                    { new Guid("af48e64f-92da-456c-a2e6-15c656de06e3"), new DateTime(2020, 6, 27, 13, 56, 35, 541, DateTimeKind.Local).AddTicks(4490), 205m },
                    { new Guid("c49fe6e3-1ce1-4ac4-ac4e-138d00c0b374"), new DateTime(2020, 6, 27, 13, 56, 35, 541, DateTimeKind.Local).AddTicks(5376), 215m }
                });

            migrationBuilder.InsertData(
                table: "SteeringWheelPos",
                columns: new[] { "Id", "CreatedOn", "Position" },
                values: new object[,]
                {
                    { new Guid("a36ec75d-8854-4b6a-8ab9-f3dfeebc8954"), new DateTime(2020, 6, 27, 13, 56, 35, 541, DateTimeKind.Local).AddTicks(6428), "Kairė" },
                    { new Guid("52e5b297-a282-488f-b210-f1608d787b27"), new DateTime(2020, 6, 27, 13, 56, 35, 541, DateTimeKind.Local).AddTicks(7198), "Dešinė" }
                });

            migrationBuilder.InsertData(
                table: "Transmissions",
                columns: new[] { "Id", "CreatedOn", "Type" },
                values: new object[,]
                {
                    { new Guid("a37485b2-1228-4389-b97d-e2ce95fdb0e8"), new DateTime(2020, 6, 27, 13, 56, 35, 541, DateTimeKind.Local).AddTicks(8238), "Automatinė" },
                    { new Guid("141de44f-1259-443f-9f09-0223925e4e63"), new DateTime(2020, 6, 27, 13, 56, 35, 541, DateTimeKind.Local).AddTicks(8997), "Mechaninė" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("00d6e706-796a-4f31-b67f-268a54ed6214"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("37cb6c15-d2a8-4014-8e32-714960d94a98"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("000c8e1a-634e-417a-93b5-20f1988f38db"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("a8b1912f-fd7a-4f0a-854b-826647b7b751"));

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: new Guid("4accde61-fa49-4b36-92c6-5da804871157"));

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: new Guid("64cc1fe3-828c-440b-8bf0-da5b724dfeea"));

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: new Guid("9300e26c-33bf-4916-87a4-936cb6854220"));

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: new Guid("ae8db698-6a0d-488e-b4e0-02fceac72488"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("111ce923-5ff8-4f90-8327-4b3af451505a"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("5abdaced-5867-44ec-a519-18a6335481ba"));

            migrationBuilder.DeleteData(
                table: "Diameters",
                keyColumn: "Id",
                keyValue: new Guid("0ac83b71-2d70-4a3b-80e3-a49ba873bf69"));

            migrationBuilder.DeleteData(
                table: "Diameters",
                keyColumn: "Id",
                keyValue: new Guid("3f9f8c27-184d-412e-b467-9e2aebe4f1c7"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("7254b27a-b186-431c-a05a-f99527636d5b"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("cb4652ff-ddf6-4f5f-b692-2d2d1d04b241"));

            migrationBuilder.DeleteData(
                table: "FrameTypes",
                keyColumn: "Id",
                keyValue: new Guid("962419fd-6cc1-4800-b7d2-6467fc86b1af"));

            migrationBuilder.DeleteData(
                table: "FrameTypes",
                keyColumn: "Id",
                keyValue: new Guid("db571b79-ff10-4b06-a801-84300c7e3d89"));

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: new Guid("813e7104-a375-494d-ad23-d24597a99235"));

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: new Guid("9209291d-fce2-451f-84db-c6bea335d611"));

            migrationBuilder.DeleteData(
                table: "Heights",
                keyColumn: "Id",
                keyValue: new Guid("af48e64f-92da-456c-a2e6-15c656de06e3"));

            migrationBuilder.DeleteData(
                table: "Heights",
                keyColumn: "Id",
                keyValue: new Guid("c49fe6e3-1ce1-4ac4-ac4e-138d00c0b374"));

            migrationBuilder.DeleteData(
                table: "SteeringWheelPos",
                keyColumn: "Id",
                keyValue: new Guid("52e5b297-a282-488f-b210-f1608d787b27"));

            migrationBuilder.DeleteData(
                table: "SteeringWheelPos",
                keyColumn: "Id",
                keyValue: new Guid("a36ec75d-8854-4b6a-8ab9-f3dfeebc8954"));

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: new Guid("141de44f-1259-443f-9f09-0223925e4e63"));

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: new Guid("a37485b2-1228-4389-b97d-e2ce95fdb0e8"));
        }
    }
}
