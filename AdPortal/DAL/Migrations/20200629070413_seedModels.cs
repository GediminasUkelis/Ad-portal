using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class seedModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("a2d79e32-444d-4b1c-a34b-9292695d4911"), new DateTime(2020, 6, 29, 10, 4, 12, 229, DateTimeKind.Local).AddTicks(7193), "Automobilis" },
                    { new Guid("cbfdfe38-32e4-4f43-9fc4-e1b9bcd7b692"), new DateTime(2020, 6, 29, 10, 4, 12, 229, DateTimeKind.Local).AddTicks(7800), "Motociklas" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "CreatedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("90e8506c-4302-4a38-ba8d-c71e3f4c1987"), new DateTime(2020, 6, 29, 10, 4, 12, 230, DateTimeKind.Local).AddTicks(9689), "Balta" },
                    { new Guid("aa2af6bd-c75a-4d72-87e7-e5d84c933e77"), new DateTime(2020, 6, 29, 10, 4, 12, 231, DateTimeKind.Local).AddTicks(215), "Juoda" }
                });

            migrationBuilder.InsertData(
                table: "Conditions",
                columns: new[] { "Id", "CreatedOn", "VehicCondition" },
                values: new object[,]
                {
                    { new Guid("c79c266e-bf9d-417f-bd72-3457278a1ad4"), new DateTime(2020, 6, 29, 10, 4, 12, 231, DateTimeKind.Local).AddTicks(893), "Naudota" },
                    { new Guid("23559e34-dd0b-4bb7-b6db-39ec38b6bed4"), new DateTime(2020, 6, 29, 10, 4, 12, 231, DateTimeKind.Local).AddTicks(1370), "Nauja" }
                });

            migrationBuilder.InsertData(
                table: "Coolings",
                columns: new[] { "Id", "CoolingType", "CreatedOn" },
                values: new object[,]
                {
                    { new Guid("4df05bd8-410b-4fe9-89ba-67db899701b8"), "Oru", new DateTime(2020, 6, 29, 10, 4, 12, 231, DateTimeKind.Local).AddTicks(2017) },
                    { new Guid("97bb57af-76a6-48e1-a46c-e22e4d35bf9e"), "Vandeniu", new DateTime(2020, 6, 29, 10, 4, 12, 231, DateTimeKind.Local).AddTicks(2478) }
                });

            migrationBuilder.InsertData(
                table: "Defects",
                columns: new[] { "Id", "CreatedOn", "Defect" },
                values: new object[,]
                {
                    { new Guid("8020d6aa-f22d-4395-a389-bfeeac8de3f0"), new DateTime(2020, 6, 29, 10, 4, 12, 231, DateTimeKind.Local).AddTicks(3150), "Be defetkų" },
                    { new Guid("77df4469-b3e4-41b2-ba4e-1417a8b5b91a"), new DateTime(2020, 6, 29, 10, 4, 12, 231, DateTimeKind.Local).AddTicks(3597), "Degęs" }
                });

            migrationBuilder.InsertData(
                table: "Diameters",
                columns: new[] { "Id", "CreatedOn", "TireDiameter" },
                values: new object[,]
                {
                    { new Guid("4bbcfaab-8ddb-426a-92b0-65f758ec0aa3"), new DateTime(2020, 6, 29, 10, 4, 12, 231, DateTimeKind.Local).AddTicks(4216), 17m },
                    { new Guid("aca85c39-20a5-4149-9834-7e5bffdedaf6"), new DateTime(2020, 6, 29, 10, 4, 12, 231, DateTimeKind.Local).AddTicks(4772), 18m }
                });

            migrationBuilder.InsertData(
                table: "Doors",
                columns: new[] { "Id", "CreatedOn", "DoorCount" },
                values: new object[,]
                {
                    { new Guid("cd635009-af34-4c5a-9d97-8c6c7be3eeb9"), new DateTime(2020, 6, 29, 10, 4, 12, 231, DateTimeKind.Local).AddTicks(5858), "2/3" },
                    { new Guid("d33fd274-fb60-480e-8380-cb70a6d8b99b"), new DateTime(2020, 6, 29, 10, 4, 12, 231, DateTimeKind.Local).AddTicks(5406), "4/5" }
                });

            migrationBuilder.InsertData(
                table: "FrameTypes",
                columns: new[] { "Id", "CreatedOn", "Type" },
                values: new object[,]
                {
                    { new Guid("aedabf43-e391-4b66-80eb-f299bf2d8cf0"), new DateTime(2020, 6, 29, 10, 4, 12, 231, DateTimeKind.Local).AddTicks(6471), "Universalas" },
                    { new Guid("502fb7ca-28ed-46e8-8569-3e474fe4fa46"), new DateTime(2020, 6, 29, 10, 4, 12, 231, DateTimeKind.Local).AddTicks(6921), "Sedanas" }
                });

            migrationBuilder.InsertData(
                table: "FuelTypes",
                columns: new[] { "Id", "CreatedOn", "Type" },
                values: new object[,]
                {
                    { new Guid("e88908df-9c32-44b1-bff0-46810515e69f"), new DateTime(2020, 6, 29, 10, 4, 12, 231, DateTimeKind.Local).AddTicks(7522), "Benzinas" },
                    { new Guid("7b150833-4107-442d-aead-7208874714f4"), new DateTime(2020, 6, 29, 10, 4, 12, 231, DateTimeKind.Local).AddTicks(7960), "Dyzelinas" }
                });

            migrationBuilder.InsertData(
                table: "Heights",
                columns: new[] { "Id", "CreatedOn", "TireHeight" },
                values: new object[,]
                {
                    { new Guid("ae8e6829-d44d-4f54-bcbd-de4d8f4e9d4f"), new DateTime(2020, 6, 29, 10, 4, 12, 231, DateTimeKind.Local).AddTicks(8552), 205m },
                    { new Guid("189078ef-cf37-4844-9390-a9f692467366"), new DateTime(2020, 6, 29, 10, 4, 12, 231, DateTimeKind.Local).AddTicks(9075), 215m }
                });

            migrationBuilder.InsertData(
                table: "ManufacturerModels",
                columns: new[] { "Id", "CreatedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("2e0c2e55-473d-4292-b4fd-e1674d867ac8"), new DateTime(2020, 6, 29, 10, 4, 12, 232, DateTimeKind.Local).AddTicks(2725), "RS6" },
                    { new Guid("7cdfe45d-578e-4b4c-8fc0-13181f5e9fc5"), new DateTime(2020, 6, 29, 10, 4, 12, 232, DateTimeKind.Local).AddTicks(3193), "E60" }
                });

            migrationBuilder.InsertData(
                table: "SteeringWheelPos",
                columns: new[] { "Id", "CreatedOn", "Position" },
                values: new object[,]
                {
                    { new Guid("6f1a0f82-7e35-4411-853e-0818b35793b5"), new DateTime(2020, 6, 29, 10, 4, 12, 232, DateTimeKind.Local).AddTicks(254), "Kairė" },
                    { new Guid("ed860296-a36e-445d-8c29-93ca413cd89d"), new DateTime(2020, 6, 29, 10, 4, 12, 232, DateTimeKind.Local).AddTicks(816), "Dešinė" }
                });

            migrationBuilder.InsertData(
                table: "Transmissions",
                columns: new[] { "Id", "CreatedOn", "Type" },
                values: new object[,]
                {
                    { new Guid("40a1d5ab-9d1a-4dc0-a28c-b3ef22a70e18"), new DateTime(2020, 6, 29, 10, 4, 12, 232, DateTimeKind.Local).AddTicks(1572), "Automatinė" },
                    { new Guid("c9e90ab7-1285-46d2-8c05-2286f49dbd22"), new DateTime(2020, 6, 29, 10, 4, 12, 232, DateTimeKind.Local).AddTicks(2069), "Mechaninė" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a2d79e32-444d-4b1c-a34b-9292695d4911"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cbfdfe38-32e4-4f43-9fc4-e1b9bcd7b692"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("90e8506c-4302-4a38-ba8d-c71e3f4c1987"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("aa2af6bd-c75a-4d72-87e7-e5d84c933e77"));

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: new Guid("23559e34-dd0b-4bb7-b6db-39ec38b6bed4"));

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: new Guid("c79c266e-bf9d-417f-bd72-3457278a1ad4"));

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: new Guid("4df05bd8-410b-4fe9-89ba-67db899701b8"));

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: new Guid("97bb57af-76a6-48e1-a46c-e22e4d35bf9e"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("77df4469-b3e4-41b2-ba4e-1417a8b5b91a"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("8020d6aa-f22d-4395-a389-bfeeac8de3f0"));

            migrationBuilder.DeleteData(
                table: "Diameters",
                keyColumn: "Id",
                keyValue: new Guid("4bbcfaab-8ddb-426a-92b0-65f758ec0aa3"));

            migrationBuilder.DeleteData(
                table: "Diameters",
                keyColumn: "Id",
                keyValue: new Guid("aca85c39-20a5-4149-9834-7e5bffdedaf6"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("cd635009-af34-4c5a-9d97-8c6c7be3eeb9"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("d33fd274-fb60-480e-8380-cb70a6d8b99b"));

            migrationBuilder.DeleteData(
                table: "FrameTypes",
                keyColumn: "Id",
                keyValue: new Guid("502fb7ca-28ed-46e8-8569-3e474fe4fa46"));

            migrationBuilder.DeleteData(
                table: "FrameTypes",
                keyColumn: "Id",
                keyValue: new Guid("aedabf43-e391-4b66-80eb-f299bf2d8cf0"));

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: new Guid("7b150833-4107-442d-aead-7208874714f4"));

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: new Guid("e88908df-9c32-44b1-bff0-46810515e69f"));

            migrationBuilder.DeleteData(
                table: "Heights",
                keyColumn: "Id",
                keyValue: new Guid("189078ef-cf37-4844-9390-a9f692467366"));

            migrationBuilder.DeleteData(
                table: "Heights",
                keyColumn: "Id",
                keyValue: new Guid("ae8e6829-d44d-4f54-bcbd-de4d8f4e9d4f"));

            migrationBuilder.DeleteData(
                table: "ManufacturerModels",
                keyColumn: "Id",
                keyValue: new Guid("2e0c2e55-473d-4292-b4fd-e1674d867ac8"));

            migrationBuilder.DeleteData(
                table: "ManufacturerModels",
                keyColumn: "Id",
                keyValue: new Guid("7cdfe45d-578e-4b4c-8fc0-13181f5e9fc5"));

            migrationBuilder.DeleteData(
                table: "SteeringWheelPos",
                keyColumn: "Id",
                keyValue: new Guid("6f1a0f82-7e35-4411-853e-0818b35793b5"));

            migrationBuilder.DeleteData(
                table: "SteeringWheelPos",
                keyColumn: "Id",
                keyValue: new Guid("ed860296-a36e-445d-8c29-93ca413cd89d"));

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: new Guid("40a1d5ab-9d1a-4dc0-a28c-b3ef22a70e18"));

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: new Guid("c9e90ab7-1285-46d2-8c05-2286f49dbd22"));

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
    }
}
