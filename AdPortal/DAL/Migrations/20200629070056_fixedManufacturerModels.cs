using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class fixedManufacturerModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ManufacturerModels_Manufacturers_ManufacturerId",
                table: "ManufacturerModels");

            migrationBuilder.DropIndex(
                name: "IX_ManufacturerModels_ManufacturerId",
                table: "ManufacturerModels");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("07c9f122-9ed4-4817-baf0-c96e86c00fba"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("11f0d61a-389a-404c-99da-945455174517"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("1aee93b0-52d4-4e8d-99ff-a3ef50f37786"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("6ee2d1c4-2644-4c0c-93bf-e987e375665e"));

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: new Guid("35cde63b-fd75-46b7-9166-7d886e593c61"));

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: new Guid("3b2e5af9-2577-4716-ac85-45870748bb09"));

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: new Guid("3a76f8f9-39e9-48d4-9a4d-aa12cb6d7446"));

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: new Guid("a2647fe7-0323-4909-a2b2-5f057a404368"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("3ed762df-f262-4dfc-8451-93f3c751d6b8"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("d604d43a-41cd-46a8-bba8-ee9277ac8bad"));

            migrationBuilder.DeleteData(
                table: "Diameters",
                keyColumn: "Id",
                keyValue: new Guid("aba3cd9a-8fc2-48d6-9b11-aa64a3d3f323"));

            migrationBuilder.DeleteData(
                table: "Diameters",
                keyColumn: "Id",
                keyValue: new Guid("f6efea31-ec9b-4996-a518-3d5f0e3366cb"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("168071b7-2ae9-41a4-bd4e-3a01de3c8e86"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("f9622ec0-d8d8-42d4-aa00-96eea4cb5b0c"));

            migrationBuilder.DeleteData(
                table: "FrameTypes",
                keyColumn: "Id",
                keyValue: new Guid("5bbcb97c-bc96-4307-b2c4-4969baad050e"));

            migrationBuilder.DeleteData(
                table: "FrameTypes",
                keyColumn: "Id",
                keyValue: new Guid("7e9530be-adef-47f7-a51c-b74f3c984738"));

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: new Guid("969500b9-10a6-4aea-89ac-e9e94e952dd6"));

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: new Guid("b7264173-e312-4ffe-8b2f-d25b4381e28c"));

            migrationBuilder.DeleteData(
                table: "Heights",
                keyColumn: "Id",
                keyValue: new Guid("2a053391-fb74-40af-9c6d-e3f267f7f78c"));

            migrationBuilder.DeleteData(
                table: "Heights",
                keyColumn: "Id",
                keyValue: new Guid("af25eaa6-59cf-4b79-907c-5888581859c2"));

            migrationBuilder.DeleteData(
                table: "SteeringWheelPos",
                keyColumn: "Id",
                keyValue: new Guid("3d43717f-73ac-4b00-972d-06c54ecdba4e"));

            migrationBuilder.DeleteData(
                table: "SteeringWheelPos",
                keyColumn: "Id",
                keyValue: new Guid("ae426667-da14-4195-85dd-25d3234fb7db"));

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: new Guid("00333bb9-afb1-42e3-a19c-ff3634474fda"));

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: new Guid("d47d6670-2577-48d7-89e0-1dd0e92d5fe4"));

            migrationBuilder.DropColumn(
                name: "ManufacturerId",
                table: "ManufacturerModels");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("e960b844-521e-45af-97ee-dac5d8407b9e"), new DateTime(2020, 6, 29, 10, 0, 55, 892, DateTimeKind.Local).AddTicks(3279), "Automobilis" },
                    { new Guid("802901fe-7251-4f86-9ba3-ad3aa26803b0"), new DateTime(2020, 6, 29, 10, 0, 55, 892, DateTimeKind.Local).AddTicks(3897), "Motociklas" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "CreatedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("a500e6ed-7892-44e1-98f8-4978ecbb0826"), new DateTime(2020, 6, 29, 10, 0, 55, 893, DateTimeKind.Local).AddTicks(7538), "Balta" },
                    { new Guid("75baa295-96a3-4499-bfba-d53e37122b72"), new DateTime(2020, 6, 29, 10, 0, 55, 893, DateTimeKind.Local).AddTicks(8105), "Juoda" }
                });

            migrationBuilder.InsertData(
                table: "Conditions",
                columns: new[] { "Id", "CreatedOn", "VehicCondition" },
                values: new object[,]
                {
                    { new Guid("b02ce468-0e03-4c67-9a57-6b10b2f382da"), new DateTime(2020, 6, 29, 10, 0, 55, 893, DateTimeKind.Local).AddTicks(8881), "Naudota" },
                    { new Guid("5600a1ae-e95c-453b-b84f-fe88b0c6b583"), new DateTime(2020, 6, 29, 10, 0, 55, 893, DateTimeKind.Local).AddTicks(9390), "Nauja" }
                });

            migrationBuilder.InsertData(
                table: "Coolings",
                columns: new[] { "Id", "CoolingType", "CreatedOn" },
                values: new object[,]
                {
                    { new Guid("29c631a5-e803-46e3-8c61-9b577f7b9d03"), "Oru", new DateTime(2020, 6, 29, 10, 0, 55, 894, DateTimeKind.Local).AddTicks(65) },
                    { new Guid("30f45707-6d42-43ac-adee-8fc089916e6b"), "Vandeniu", new DateTime(2020, 6, 29, 10, 0, 55, 894, DateTimeKind.Local).AddTicks(540) }
                });

            migrationBuilder.InsertData(
                table: "Defects",
                columns: new[] { "Id", "CreatedOn", "Defect" },
                values: new object[,]
                {
                    { new Guid("7cb03e8a-ddd4-4325-b9a6-ac524b03021b"), new DateTime(2020, 6, 29, 10, 0, 55, 894, DateTimeKind.Local).AddTicks(1182), "Be defetkų" },
                    { new Guid("76492d97-0c1e-48a7-9225-e74c79848209"), new DateTime(2020, 6, 29, 10, 0, 55, 894, DateTimeKind.Local).AddTicks(1651), "Degęs" }
                });

            migrationBuilder.InsertData(
                table: "Diameters",
                columns: new[] { "Id", "CreatedOn", "TireDiameter" },
                values: new object[,]
                {
                    { new Guid("2f5eec0a-ee75-4648-9cd0-f931cbfef229"), new DateTime(2020, 6, 29, 10, 0, 55, 894, DateTimeKind.Local).AddTicks(2971), 18m },
                    { new Guid("6d56795c-810e-4d9f-9fb5-92bf082d558b"), new DateTime(2020, 6, 29, 10, 0, 55, 894, DateTimeKind.Local).AddTicks(2369), 17m }
                });

            migrationBuilder.InsertData(
                table: "Doors",
                columns: new[] { "Id", "CreatedOn", "DoorCount" },
                values: new object[,]
                {
                    { new Guid("85d5a284-564a-4592-8861-7906352cdfc7"), new DateTime(2020, 6, 29, 10, 0, 55, 894, DateTimeKind.Local).AddTicks(3607), "4/5" },
                    { new Guid("17debee6-2fca-4def-b100-b28a230e5f00"), new DateTime(2020, 6, 29, 10, 0, 55, 894, DateTimeKind.Local).AddTicks(4084), "2/3" }
                });

            migrationBuilder.InsertData(
                table: "FrameTypes",
                columns: new[] { "Id", "CreatedOn", "Type" },
                values: new object[,]
                {
                    { new Guid("c0fdc615-50ce-4540-b1c0-c61f7a13ae01"), new DateTime(2020, 6, 29, 10, 0, 55, 894, DateTimeKind.Local).AddTicks(4715), "Universalas" },
                    { new Guid("0a7af4cc-8235-464d-a744-cc96bea35147"), new DateTime(2020, 6, 29, 10, 0, 55, 894, DateTimeKind.Local).AddTicks(5177), "Sedanas" }
                });

            migrationBuilder.InsertData(
                table: "FuelTypes",
                columns: new[] { "Id", "CreatedOn", "Type" },
                values: new object[,]
                {
                    { new Guid("db2184eb-9566-4837-8cad-d123c8365fec"), new DateTime(2020, 6, 29, 10, 0, 55, 894, DateTimeKind.Local).AddTicks(5794), "Benzinas" },
                    { new Guid("9453869c-ba98-4e3c-8169-66787ed178e8"), new DateTime(2020, 6, 29, 10, 0, 55, 894, DateTimeKind.Local).AddTicks(7064), "Dyzelinas" }
                });

            migrationBuilder.InsertData(
                table: "Heights",
                columns: new[] { "Id", "CreatedOn", "TireHeight" },
                values: new object[,]
                {
                    { new Guid("6743ff10-6152-4c8f-86fb-e3dca26f5fb8"), new DateTime(2020, 6, 29, 10, 0, 55, 896, DateTimeKind.Local).AddTicks(6718), 205m },
                    { new Guid("2131f146-f8fe-4726-8311-2a2f77466346"), new DateTime(2020, 6, 29, 10, 0, 55, 896, DateTimeKind.Local).AddTicks(8513), 215m }
                });

            migrationBuilder.InsertData(
                table: "SteeringWheelPos",
                columns: new[] { "Id", "CreatedOn", "Position" },
                values: new object[,]
                {
                    { new Guid("a0f68f8c-2735-4e4f-944f-f2a0dab33ea9"), new DateTime(2020, 6, 29, 10, 0, 55, 896, DateTimeKind.Local).AddTicks(9938), "Kairė" },
                    { new Guid("b5d2fe8e-91b4-4749-ba7d-ebba3185074f"), new DateTime(2020, 6, 29, 10, 0, 55, 897, DateTimeKind.Local).AddTicks(544), "Dešinė" }
                });

            migrationBuilder.InsertData(
                table: "Transmissions",
                columns: new[] { "Id", "CreatedOn", "Type" },
                values: new object[,]
                {
                    { new Guid("7c806ef8-777a-4740-818f-ce303f9a0ce7"), new DateTime(2020, 6, 29, 10, 0, 55, 897, DateTimeKind.Local).AddTicks(1366), "Automatinė" },
                    { new Guid("115bed0e-b00e-41e6-bfca-a2b5d928562a"), new DateTime(2020, 6, 29, 10, 0, 55, 897, DateTimeKind.Local).AddTicks(1900), "Mechaninė" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("802901fe-7251-4f86-9ba3-ad3aa26803b0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e960b844-521e-45af-97ee-dac5d8407b9e"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("75baa295-96a3-4499-bfba-d53e37122b72"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("a500e6ed-7892-44e1-98f8-4978ecbb0826"));

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: new Guid("5600a1ae-e95c-453b-b84f-fe88b0c6b583"));

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: new Guid("b02ce468-0e03-4c67-9a57-6b10b2f382da"));

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: new Guid("29c631a5-e803-46e3-8c61-9b577f7b9d03"));

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: new Guid("30f45707-6d42-43ac-adee-8fc089916e6b"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("76492d97-0c1e-48a7-9225-e74c79848209"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("7cb03e8a-ddd4-4325-b9a6-ac524b03021b"));

            migrationBuilder.DeleteData(
                table: "Diameters",
                keyColumn: "Id",
                keyValue: new Guid("2f5eec0a-ee75-4648-9cd0-f931cbfef229"));

            migrationBuilder.DeleteData(
                table: "Diameters",
                keyColumn: "Id",
                keyValue: new Guid("6d56795c-810e-4d9f-9fb5-92bf082d558b"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("17debee6-2fca-4def-b100-b28a230e5f00"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("85d5a284-564a-4592-8861-7906352cdfc7"));

            migrationBuilder.DeleteData(
                table: "FrameTypes",
                keyColumn: "Id",
                keyValue: new Guid("0a7af4cc-8235-464d-a744-cc96bea35147"));

            migrationBuilder.DeleteData(
                table: "FrameTypes",
                keyColumn: "Id",
                keyValue: new Guid("c0fdc615-50ce-4540-b1c0-c61f7a13ae01"));

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: new Guid("9453869c-ba98-4e3c-8169-66787ed178e8"));

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: new Guid("db2184eb-9566-4837-8cad-d123c8365fec"));

            migrationBuilder.DeleteData(
                table: "Heights",
                keyColumn: "Id",
                keyValue: new Guid("2131f146-f8fe-4726-8311-2a2f77466346"));

            migrationBuilder.DeleteData(
                table: "Heights",
                keyColumn: "Id",
                keyValue: new Guid("6743ff10-6152-4c8f-86fb-e3dca26f5fb8"));

            migrationBuilder.DeleteData(
                table: "SteeringWheelPos",
                keyColumn: "Id",
                keyValue: new Guid("a0f68f8c-2735-4e4f-944f-f2a0dab33ea9"));

            migrationBuilder.DeleteData(
                table: "SteeringWheelPos",
                keyColumn: "Id",
                keyValue: new Guid("b5d2fe8e-91b4-4749-ba7d-ebba3185074f"));

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: new Guid("115bed0e-b00e-41e6-bfca-a2b5d928562a"));

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: new Guid("7c806ef8-777a-4740-818f-ce303f9a0ce7"));

            migrationBuilder.AddColumn<Guid>(
                name: "ManufacturerId",
                table: "ManufacturerModels",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("07c9f122-9ed4-4817-baf0-c96e86c00fba"), new DateTime(2020, 6, 29, 9, 56, 11, 686, DateTimeKind.Local).AddTicks(6815), "Automobilis" },
                    { new Guid("11f0d61a-389a-404c-99da-945455174517"), new DateTime(2020, 6, 29, 9, 56, 11, 686, DateTimeKind.Local).AddTicks(7428), "Motociklas" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "CreatedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("1aee93b0-52d4-4e8d-99ff-a3ef50f37786"), new DateTime(2020, 6, 29, 9, 56, 11, 688, DateTimeKind.Local).AddTicks(643), "Balta" },
                    { new Guid("6ee2d1c4-2644-4c0c-93bf-e987e375665e"), new DateTime(2020, 6, 29, 9, 56, 11, 688, DateTimeKind.Local).AddTicks(1176), "Juoda" }
                });

            migrationBuilder.InsertData(
                table: "Conditions",
                columns: new[] { "Id", "CreatedOn", "VehicCondition" },
                values: new object[,]
                {
                    { new Guid("3b2e5af9-2577-4716-ac85-45870748bb09"), new DateTime(2020, 6, 29, 9, 56, 11, 688, DateTimeKind.Local).AddTicks(1934), "Naudota" },
                    { new Guid("35cde63b-fd75-46b7-9166-7d886e593c61"), new DateTime(2020, 6, 29, 9, 56, 11, 688, DateTimeKind.Local).AddTicks(2420), "Nauja" }
                });

            migrationBuilder.InsertData(
                table: "Coolings",
                columns: new[] { "Id", "CoolingType", "CreatedOn" },
                values: new object[,]
                {
                    { new Guid("3a76f8f9-39e9-48d4-9a4d-aa12cb6d7446"), "Oru", new DateTime(2020, 6, 29, 9, 56, 11, 688, DateTimeKind.Local).AddTicks(3069) },
                    { new Guid("a2647fe7-0323-4909-a2b2-5f057a404368"), "Vandeniu", new DateTime(2020, 6, 29, 9, 56, 11, 688, DateTimeKind.Local).AddTicks(3530) }
                });

            migrationBuilder.InsertData(
                table: "Defects",
                columns: new[] { "Id", "CreatedOn", "Defect" },
                values: new object[,]
                {
                    { new Guid("3ed762df-f262-4dfc-8451-93f3c751d6b8"), new DateTime(2020, 6, 29, 9, 56, 11, 688, DateTimeKind.Local).AddTicks(4147), "Be defetkų" },
                    { new Guid("d604d43a-41cd-46a8-bba8-ee9277ac8bad"), new DateTime(2020, 6, 29, 9, 56, 11, 688, DateTimeKind.Local).AddTicks(4598), "Degęs" }
                });

            migrationBuilder.InsertData(
                table: "Diameters",
                columns: new[] { "Id", "CreatedOn", "TireDiameter" },
                values: new object[,]
                {
                    { new Guid("aba3cd9a-8fc2-48d6-9b11-aa64a3d3f323"), new DateTime(2020, 6, 29, 9, 56, 11, 688, DateTimeKind.Local).AddTicks(5766), 18m },
                    { new Guid("f6efea31-ec9b-4996-a518-3d5f0e3366cb"), new DateTime(2020, 6, 29, 9, 56, 11, 688, DateTimeKind.Local).AddTicks(5208), 17m }
                });

            migrationBuilder.InsertData(
                table: "Doors",
                columns: new[] { "Id", "CreatedOn", "DoorCount" },
                values: new object[,]
                {
                    { new Guid("168071b7-2ae9-41a4-bd4e-3a01de3c8e86"), new DateTime(2020, 6, 29, 9, 56, 11, 688, DateTimeKind.Local).AddTicks(6380), "4/5" },
                    { new Guid("f9622ec0-d8d8-42d4-aa00-96eea4cb5b0c"), new DateTime(2020, 6, 29, 9, 56, 11, 688, DateTimeKind.Local).AddTicks(6837), "2/3" }
                });

            migrationBuilder.InsertData(
                table: "FrameTypes",
                columns: new[] { "Id", "CreatedOn", "Type" },
                values: new object[,]
                {
                    { new Guid("5bbcb97c-bc96-4307-b2c4-4969baad050e"), new DateTime(2020, 6, 29, 9, 56, 11, 688, DateTimeKind.Local).AddTicks(7441), "Universalas" },
                    { new Guid("7e9530be-adef-47f7-a51c-b74f3c984738"), new DateTime(2020, 6, 29, 9, 56, 11, 688, DateTimeKind.Local).AddTicks(7881), "Sedanas" }
                });

            migrationBuilder.InsertData(
                table: "FuelTypes",
                columns: new[] { "Id", "CreatedOn", "Type" },
                values: new object[,]
                {
                    { new Guid("b7264173-e312-4ffe-8b2f-d25b4381e28c"), new DateTime(2020, 6, 29, 9, 56, 11, 688, DateTimeKind.Local).AddTicks(8502), "Benzinas" },
                    { new Guid("969500b9-10a6-4aea-89ac-e9e94e952dd6"), new DateTime(2020, 6, 29, 9, 56, 11, 688, DateTimeKind.Local).AddTicks(8942), "Dyzelinas" }
                });

            migrationBuilder.InsertData(
                table: "Heights",
                columns: new[] { "Id", "CreatedOn", "TireHeight" },
                values: new object[,]
                {
                    { new Guid("2a053391-fb74-40af-9c6d-e3f267f7f78c"), new DateTime(2020, 6, 29, 9, 56, 11, 688, DateTimeKind.Local).AddTicks(9526), 205m },
                    { new Guid("af25eaa6-59cf-4b79-907c-5888581859c2"), new DateTime(2020, 6, 29, 9, 56, 11, 689, DateTimeKind.Local).AddTicks(41), 215m }
                });

            migrationBuilder.InsertData(
                table: "SteeringWheelPos",
                columns: new[] { "Id", "CreatedOn", "Position" },
                values: new object[,]
                {
                    { new Guid("3d43717f-73ac-4b00-972d-06c54ecdba4e"), new DateTime(2020, 6, 29, 9, 56, 11, 689, DateTimeKind.Local).AddTicks(650), "Kairė" },
                    { new Guid("ae426667-da14-4195-85dd-25d3234fb7db"), new DateTime(2020, 6, 29, 9, 56, 11, 689, DateTimeKind.Local).AddTicks(1097), "Dešinė" }
                });

            migrationBuilder.InsertData(
                table: "Transmissions",
                columns: new[] { "Id", "CreatedOn", "Type" },
                values: new object[,]
                {
                    { new Guid("00333bb9-afb1-42e3-a19c-ff3634474fda"), new DateTime(2020, 6, 29, 9, 56, 11, 689, DateTimeKind.Local).AddTicks(1692), "Automatinė" },
                    { new Guid("d47d6670-2577-48d7-89e0-1dd0e92d5fe4"), new DateTime(2020, 6, 29, 9, 56, 11, 689, DateTimeKind.Local).AddTicks(2289), "Mechaninė" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ManufacturerModels_ManufacturerId",
                table: "ManufacturerModels",
                column: "ManufacturerId");

            migrationBuilder.AddForeignKey(
                name: "FK_ManufacturerModels_Manufacturers_ManufacturerId",
                table: "ManufacturerModels",
                column: "ManufacturerId",
                principalTable: "Manufacturers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
