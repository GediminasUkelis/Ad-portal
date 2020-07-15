using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class AddingMotorbike : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehicleTypes_Categories_CategoryId",
                table: "VehicleTypes");

            migrationBuilder.DropIndex(
                name: "IX_VehicleTypes_CategoryId",
                table: "VehicleTypes");

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

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "VehicleTypes");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("70532b44-8670-4482-901d-30704eb6019d"), "Automobilis" },
                    { new Guid("bf3c1b95-d3fc-46fc-b515-bf954f9b36ee"), "Motociklas" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("df5ed3b2-066b-4ff2-b994-07875bb43f72"), "Balta" },
                    { new Guid("5fb4051b-e9a0-483b-a411-97797a9a6035"), "Juoda" }
                });

            migrationBuilder.InsertData(
                table: "Conditions",
                columns: new[] { "Id", "VehicCondition" },
                values: new object[,]
                {
                    { new Guid("7402a87c-c0b1-4753-9150-135d3324f688"), "Naudota" },
                    { new Guid("fb3f67d6-cb5f-4b23-a8f9-3c5a9bc9c29b"), "Nauja" }
                });

            migrationBuilder.InsertData(
                table: "Coolings",
                columns: new[] { "Id", "CoolingType" },
                values: new object[,]
                {
                    { new Guid("e43fdcba-5511-44c7-839d-c3d36e5e9b1e"), "Oru" },
                    { new Guid("2bbf0c2a-e41e-459a-b09e-10136daf8877"), "Vandeniu" }
                });

            migrationBuilder.InsertData(
                table: "Defects",
                columns: new[] { "Id", "Defect" },
                values: new object[,]
                {
                    { new Guid("563ae722-b1eb-47b2-96a8-5e60fec462d1"), "Be defetkų" },
                    { new Guid("17df7aa2-18f6-4e81-8d24-a53a9931d270"), "Degęs" }
                });

            migrationBuilder.InsertData(
                table: "Diameters",
                columns: new[] { "Id", "TireDiameter" },
                values: new object[,]
                {
                    { new Guid("be58a811-b442-4cd1-a57d-94a49983cb85"), 17m },
                    { new Guid("207d3f8b-1e3f-4095-9f6b-24e242b45f1a"), 18m }
                });

            migrationBuilder.InsertData(
                table: "Doors",
                columns: new[] { "Id", "DoorCount" },
                values: new object[,]
                {
                    { new Guid("3d693106-8da0-41e9-8660-761d0c3ca4a9"), "2/3" },
                    { new Guid("2d386750-0d6e-46f5-b780-7840fd066d92"), "4/5" }
                });

            migrationBuilder.InsertData(
                table: "FrameTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("2a625ece-c532-4532-8037-ce537c26c705"), "Universalas" },
                    { new Guid("ff93822b-b78a-41ee-84c3-adf7c09465c2"), "Sedanas" }
                });

            migrationBuilder.InsertData(
                table: "FuelTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("95a07031-6fc6-4d68-8b64-f6174fdeb863"), "Benzinas" },
                    { new Guid("0b9c8854-b5f3-4c0e-9017-50c0385d6695"), "Dyzelinas" }
                });

            migrationBuilder.InsertData(
                table: "Heights",
                columns: new[] { "Id", "TireHeight" },
                values: new object[,]
                {
                    { new Guid("bb3d8b5a-da15-4f8d-a4e9-2a940c18bdb3"), 205m },
                    { new Guid("f4d1145c-6671-4b91-8471-495ab9be6f89"), 215m }
                });

            migrationBuilder.InsertData(
                table: "ManufacturerModels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("de31ecc7-2cf0-40e1-a618-2edb64d9924b"), "RS6" },
                    { new Guid("d834208c-39c9-4063-b1c0-d73ae625ba6b"), "E60" }
                });

            migrationBuilder.InsertData(
                table: "SteeringWheelPos",
                columns: new[] { "Id", "Position" },
                values: new object[,]
                {
                    { new Guid("c9db4a18-119f-4216-baa2-6fa19d1496e4"), "Kairė" },
                    { new Guid("9349925a-99a8-4d1a-87db-e3299ee27d83"), "Dešinė" }
                });

            migrationBuilder.InsertData(
                table: "Transmissions",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("10680b85-e829-433b-90e1-26cea400c5a2"), "Automatinė" },
                    { new Guid("7ddc1b3c-8f38-4c8c-b823-437af74e6fcf"), "Mechaninė" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("70532b44-8670-4482-901d-30704eb6019d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bf3c1b95-d3fc-46fc-b515-bf954f9b36ee"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("5fb4051b-e9a0-483b-a411-97797a9a6035"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("df5ed3b2-066b-4ff2-b994-07875bb43f72"));

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: new Guid("7402a87c-c0b1-4753-9150-135d3324f688"));

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: new Guid("fb3f67d6-cb5f-4b23-a8f9-3c5a9bc9c29b"));

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: new Guid("2bbf0c2a-e41e-459a-b09e-10136daf8877"));

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: new Guid("e43fdcba-5511-44c7-839d-c3d36e5e9b1e"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("17df7aa2-18f6-4e81-8d24-a53a9931d270"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("563ae722-b1eb-47b2-96a8-5e60fec462d1"));

            migrationBuilder.DeleteData(
                table: "Diameters",
                keyColumn: "Id",
                keyValue: new Guid("207d3f8b-1e3f-4095-9f6b-24e242b45f1a"));

            migrationBuilder.DeleteData(
                table: "Diameters",
                keyColumn: "Id",
                keyValue: new Guid("be58a811-b442-4cd1-a57d-94a49983cb85"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("2d386750-0d6e-46f5-b780-7840fd066d92"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("3d693106-8da0-41e9-8660-761d0c3ca4a9"));

            migrationBuilder.DeleteData(
                table: "FrameTypes",
                keyColumn: "Id",
                keyValue: new Guid("2a625ece-c532-4532-8037-ce537c26c705"));

            migrationBuilder.DeleteData(
                table: "FrameTypes",
                keyColumn: "Id",
                keyValue: new Guid("ff93822b-b78a-41ee-84c3-adf7c09465c2"));

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: new Guid("0b9c8854-b5f3-4c0e-9017-50c0385d6695"));

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: new Guid("95a07031-6fc6-4d68-8b64-f6174fdeb863"));

            migrationBuilder.DeleteData(
                table: "Heights",
                keyColumn: "Id",
                keyValue: new Guid("bb3d8b5a-da15-4f8d-a4e9-2a940c18bdb3"));

            migrationBuilder.DeleteData(
                table: "Heights",
                keyColumn: "Id",
                keyValue: new Guid("f4d1145c-6671-4b91-8471-495ab9be6f89"));

            migrationBuilder.DeleteData(
                table: "ManufacturerModels",
                keyColumn: "Id",
                keyValue: new Guid("d834208c-39c9-4063-b1c0-d73ae625ba6b"));

            migrationBuilder.DeleteData(
                table: "ManufacturerModels",
                keyColumn: "Id",
                keyValue: new Guid("de31ecc7-2cf0-40e1-a618-2edb64d9924b"));

            migrationBuilder.DeleteData(
                table: "SteeringWheelPos",
                keyColumn: "Id",
                keyValue: new Guid("9349925a-99a8-4d1a-87db-e3299ee27d83"));

            migrationBuilder.DeleteData(
                table: "SteeringWheelPos",
                keyColumn: "Id",
                keyValue: new Guid("c9db4a18-119f-4216-baa2-6fa19d1496e4"));

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: new Guid("10680b85-e829-433b-90e1-26cea400c5a2"));

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: new Guid("7ddc1b3c-8f38-4c8c-b823-437af74e6fcf"));

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "VehicleTypes",
                type: "uniqueidentifier",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_VehicleTypes_CategoryId",
                table: "VehicleTypes",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleTypes_Categories_CategoryId",
                table: "VehicleTypes",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
