using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class deletedCreatedOn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Widths");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "VehicleTypes");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Transmissions");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Tires");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "TirePurposes");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "SteeringWheelPos");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Seasons");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Motorbikes");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Manufacturers");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "ManufacturerModels");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Heights");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "FuelTypes");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "FrameTypes");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Doors");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Diameters");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Defects");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Coolings");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Conditions");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Colors");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Categories");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("bef04355-916a-49de-be7b-165631ebb2e4"), "Automobilis" },
                    { new Guid("9ef8410f-ca8f-454e-9492-ba1bef2524c4"), "Motociklas" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("c6d03134-c9f1-4261-98cf-d40d508aec95"), "Balta" },
                    { new Guid("5cdc527c-4d74-4c8c-a25e-f12a37b48073"), "Juoda" }
                });

            migrationBuilder.InsertData(
                table: "Conditions",
                columns: new[] { "Id", "VehicCondition" },
                values: new object[,]
                {
                    { new Guid("249463ae-3848-4467-a827-14b5f488d2c7"), "Naudota" },
                    { new Guid("62047d99-9f85-4818-a15d-08105e1dcdd2"), "Nauja" }
                });

            migrationBuilder.InsertData(
                table: "Coolings",
                columns: new[] { "Id", "CoolingType" },
                values: new object[,]
                {
                    { new Guid("ee488584-30b5-4d32-a194-99b09748f303"), "Oru" },
                    { new Guid("c4eb2da0-1ecb-4d53-af86-21b9ab0d43f3"), "Vandeniu" }
                });

            migrationBuilder.InsertData(
                table: "Defects",
                columns: new[] { "Id", "Defect" },
                values: new object[,]
                {
                    { new Guid("f96512f0-9a63-466c-994b-d5c45e6bacbf"), "Be defetkų" },
                    { new Guid("9210d40f-63c7-410e-bc2d-64544713268d"), "Degęs" }
                });

            migrationBuilder.InsertData(
                table: "Diameters",
                columns: new[] { "Id", "TireDiameter" },
                values: new object[,]
                {
                    { new Guid("8adba2f7-9eaf-49d6-ae40-52a292c60c35"), 17m },
                    { new Guid("9728b7a3-9a78-4be6-ace4-f97d352e4a85"), 18m }
                });

            migrationBuilder.InsertData(
                table: "Doors",
                columns: new[] { "Id", "DoorCount" },
                values: new object[,]
                {
                    { new Guid("527b5b11-15bd-4485-9fe2-a828450513b3"), "2/3" },
                    { new Guid("c2ba25e0-8355-433a-aeb8-e5f2187df256"), "4/5" }
                });

            migrationBuilder.InsertData(
                table: "FrameTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("d63af71c-07e6-4ea2-a65a-394622f641f1"), "Universalas" },
                    { new Guid("7e3585f1-364e-40a6-a91e-2dbe0b1ca9f7"), "Sedanas" }
                });

            migrationBuilder.InsertData(
                table: "FuelTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("d895c741-a4d9-4849-8dc5-00df53062280"), "Benzinas" },
                    { new Guid("1275452f-3fc8-4116-9810-f526734788a2"), "Dyzelinas" }
                });

            migrationBuilder.InsertData(
                table: "Heights",
                columns: new[] { "Id", "TireHeight" },
                values: new object[,]
                {
                    { new Guid("2e77e556-aa90-475f-8b6a-986628061c67"), 205m },
                    { new Guid("301a8bf7-8955-4c01-82ec-9c29989a893d"), 215m }
                });

            migrationBuilder.InsertData(
                table: "ManufacturerModels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("31b9b9ec-0bc9-4c10-a424-4b66f5421916"), "RS6" },
                    { new Guid("1473bc09-81e6-445b-ab6d-371a7a2ec805"), "E60" }
                });

            migrationBuilder.InsertData(
                table: "SteeringWheelPos",
                columns: new[] { "Id", "Position" },
                values: new object[,]
                {
                    { new Guid("6be13bcc-be8e-4364-950d-90a651cb85db"), "Kairė" },
                    { new Guid("2e1b4709-5c29-4664-abf6-949a1174c697"), "Dešinė" }
                });

            migrationBuilder.InsertData(
                table: "Transmissions",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("5bf58662-c8d9-4ff5-a46d-81ada8a250a3"), "Automatinė" },
                    { new Guid("f8f427da-6123-40cc-91a7-1c20aa05b44c"), "Mechaninė" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9ef8410f-ca8f-454e-9492-ba1bef2524c4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bef04355-916a-49de-be7b-165631ebb2e4"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("5cdc527c-4d74-4c8c-a25e-f12a37b48073"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("c6d03134-c9f1-4261-98cf-d40d508aec95"));

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: new Guid("249463ae-3848-4467-a827-14b5f488d2c7"));

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: new Guid("62047d99-9f85-4818-a15d-08105e1dcdd2"));

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: new Guid("c4eb2da0-1ecb-4d53-af86-21b9ab0d43f3"));

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: new Guid("ee488584-30b5-4d32-a194-99b09748f303"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("9210d40f-63c7-410e-bc2d-64544713268d"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("f96512f0-9a63-466c-994b-d5c45e6bacbf"));

            migrationBuilder.DeleteData(
                table: "Diameters",
                keyColumn: "Id",
                keyValue: new Guid("8adba2f7-9eaf-49d6-ae40-52a292c60c35"));

            migrationBuilder.DeleteData(
                table: "Diameters",
                keyColumn: "Id",
                keyValue: new Guid("9728b7a3-9a78-4be6-ace4-f97d352e4a85"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("527b5b11-15bd-4485-9fe2-a828450513b3"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("c2ba25e0-8355-433a-aeb8-e5f2187df256"));

            migrationBuilder.DeleteData(
                table: "FrameTypes",
                keyColumn: "Id",
                keyValue: new Guid("7e3585f1-364e-40a6-a91e-2dbe0b1ca9f7"));

            migrationBuilder.DeleteData(
                table: "FrameTypes",
                keyColumn: "Id",
                keyValue: new Guid("d63af71c-07e6-4ea2-a65a-394622f641f1"));

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: new Guid("1275452f-3fc8-4116-9810-f526734788a2"));

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: new Guid("d895c741-a4d9-4849-8dc5-00df53062280"));

            migrationBuilder.DeleteData(
                table: "Heights",
                keyColumn: "Id",
                keyValue: new Guid("2e77e556-aa90-475f-8b6a-986628061c67"));

            migrationBuilder.DeleteData(
                table: "Heights",
                keyColumn: "Id",
                keyValue: new Guid("301a8bf7-8955-4c01-82ec-9c29989a893d"));

            migrationBuilder.DeleteData(
                table: "ManufacturerModels",
                keyColumn: "Id",
                keyValue: new Guid("1473bc09-81e6-445b-ab6d-371a7a2ec805"));

            migrationBuilder.DeleteData(
                table: "ManufacturerModels",
                keyColumn: "Id",
                keyValue: new Guid("31b9b9ec-0bc9-4c10-a424-4b66f5421916"));

            migrationBuilder.DeleteData(
                table: "SteeringWheelPos",
                keyColumn: "Id",
                keyValue: new Guid("2e1b4709-5c29-4664-abf6-949a1174c697"));

            migrationBuilder.DeleteData(
                table: "SteeringWheelPos",
                keyColumn: "Id",
                keyValue: new Guid("6be13bcc-be8e-4364-950d-90a651cb85db"));

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: new Guid("5bf58662-c8d9-4ff5-a46d-81ada8a250a3"));

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: new Guid("f8f427da-6123-40cc-91a7-1c20aa05b44c"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Widths",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "VehicleTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Transmissions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Tires",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "TirePurposes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "SteeringWheelPos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Seasons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Motorbikes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Manufacturers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "ManufacturerModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Heights",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "FuelTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "FrameTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Doors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Diameters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Defects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Coolings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Conditions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Colors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
    }
}
