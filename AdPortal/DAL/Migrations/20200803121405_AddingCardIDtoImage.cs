using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class AddingCardIDtoImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Cars_CarsId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_CarsId",
                table: "Images");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("010bf490-e76d-43b1-aa8c-39f10c17d0ca"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("79d8ad81-86eb-4435-a7fe-854a1db6f0ab"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("464967ce-4fee-4df9-8e59-d45bc51017c7"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("ad7fdecb-7bc7-457b-b36a-58b3c451dee6"));

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: new Guid("025157ef-e5fd-4b1d-8bfe-8a84e88afaf7"));

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: new Guid("7018586b-736c-4b4d-9a3f-981bbde0418c"));

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: new Guid("57ba79a1-61be-4621-b35e-ab3ba1602876"));

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: new Guid("cf285d2b-12a7-42ab-9fdb-86f63b67c7de"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("6699aa81-d93c-402a-ae24-bd3d684513ca"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("73d5741c-6ba0-45e9-89aa-e8492b691263"));

            migrationBuilder.DeleteData(
                table: "Diameters",
                keyColumn: "Id",
                keyValue: new Guid("7f5d433b-1f81-40e6-9877-112a4cf223ed"));

            migrationBuilder.DeleteData(
                table: "Diameters",
                keyColumn: "Id",
                keyValue: new Guid("f99dc17d-cb00-458b-8086-40a3a8c073e0"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("204679fc-2b32-4182-acf4-a93432c2743f"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("2ddcb346-43cb-4657-855c-98f9fec26a25"));

            migrationBuilder.DeleteData(
                table: "FrameTypes",
                keyColumn: "Id",
                keyValue: new Guid("2a86b0ed-85e0-468c-8aee-6687ed7d795e"));

            migrationBuilder.DeleteData(
                table: "FrameTypes",
                keyColumn: "Id",
                keyValue: new Guid("3d0cd103-9b52-4227-a7b1-6cdbf947a1f5"));

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: new Guid("18f236c9-c171-4614-b4ce-a11ef2f880be"));

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: new Guid("79632e1e-4005-447c-9d64-55f11078306e"));

            migrationBuilder.DeleteData(
                table: "Heights",
                keyColumn: "Id",
                keyValue: new Guid("1351fea5-60d8-4b81-afcc-236586033e48"));

            migrationBuilder.DeleteData(
                table: "Heights",
                keyColumn: "Id",
                keyValue: new Guid("99ff90ae-92e7-42da-8f25-b629ab2f4ed4"));

            migrationBuilder.DeleteData(
                table: "ManufacturerModels",
                keyColumn: "Id",
                keyValue: new Guid("45aa3c60-6820-4cbc-a4af-5d6009a14ab5"));

            migrationBuilder.DeleteData(
                table: "ManufacturerModels",
                keyColumn: "Id",
                keyValue: new Guid("52116167-adb1-4deb-9fab-6fbc7bce001b"));

            migrationBuilder.DeleteData(
                table: "SteeringWheelPos",
                keyColumn: "Id",
                keyValue: new Guid("2fec891e-67e5-4006-8a25-419c8f6712d2"));

            migrationBuilder.DeleteData(
                table: "SteeringWheelPos",
                keyColumn: "Id",
                keyValue: new Guid("55cc2351-4a40-4680-9d66-ff2b28af140f"));

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: new Guid("3740372b-a6d8-4c8c-8042-e57537fad6c0"));

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: new Guid("943d3a7b-302e-45de-855b-20cfb891a387"));

            migrationBuilder.DropColumn(
                name: "CarsId",
                table: "Images");

            migrationBuilder.AddColumn<Guid>(
                name: "CarId",
                table: "Images",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2a66039e-f447-4348-969d-5d09a735d5dc"), "Automobilis" },
                    { new Guid("a5556584-f587-4680-acd9-7ee6c5ddbca6"), "Motociklas" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("4f0dbef2-b49c-4396-b3de-b9d4694cfa6b"), "Balta" },
                    { new Guid("4af062a9-2439-4f28-b075-6634ac20bce8"), "Juoda" }
                });

            migrationBuilder.InsertData(
                table: "Conditions",
                columns: new[] { "Id", "VehicCondition" },
                values: new object[,]
                {
                    { new Guid("1dd774d1-097d-4bdc-ab83-43442f77b7f8"), "Naudota" },
                    { new Guid("e30056bc-1b6e-44f5-9de2-7255381430c8"), "Nauja" }
                });

            migrationBuilder.InsertData(
                table: "Coolings",
                columns: new[] { "Id", "CoolingType" },
                values: new object[,]
                {
                    { new Guid("3d04b4af-bff0-443e-9f8f-271e7da967b8"), "Oru" },
                    { new Guid("655bcc53-053d-43fc-bae1-035ad524901b"), "Vandeniu" }
                });

            migrationBuilder.InsertData(
                table: "Defects",
                columns: new[] { "Id", "Defect" },
                values: new object[,]
                {
                    { new Guid("e041a12b-f267-4ab3-9a8d-0c6dd7d63118"), "Be defetkų" },
                    { new Guid("a6e612ba-b37c-4329-8c6e-d415ae9520e9"), "Degęs" }
                });

            migrationBuilder.InsertData(
                table: "Diameters",
                columns: new[] { "Id", "TireDiameter" },
                values: new object[,]
                {
                    { new Guid("5c3d7b5b-f8e3-4eb6-9a2c-601aa44ef77c"), 17m },
                    { new Guid("feb2f9bc-567a-4ebe-ab54-2d39dec5979f"), 18m }
                });

            migrationBuilder.InsertData(
                table: "Doors",
                columns: new[] { "Id", "DoorCount" },
                values: new object[,]
                {
                    { new Guid("1b3988c1-e392-45f3-bcf5-bdb1b59b85f8"), "2/3" },
                    { new Guid("fa7a0b4c-bc01-479a-8b3d-c137d67c0b29"), "4/5" }
                });

            migrationBuilder.InsertData(
                table: "FrameTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("1fc67b35-c6b7-427f-aaf5-2d71ff1bdf1b"), "Universalas" },
                    { new Guid("aa1fc47f-1753-4ea5-a4d5-43c811586c83"), "Sedanas" }
                });

            migrationBuilder.InsertData(
                table: "FuelTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("703cd7e6-65d7-4a47-9aef-07bae4b3465c"), "Benzinas" },
                    { new Guid("e184a9c5-e2e9-4700-b847-47811f98a7c7"), "Dyzelinas" }
                });

            migrationBuilder.InsertData(
                table: "Heights",
                columns: new[] { "Id", "TireHeight" },
                values: new object[,]
                {
                    { new Guid("fb98e7ea-7d0f-47bc-bcef-420730ef9ad3"), 205m },
                    { new Guid("d9afc208-90ef-4b15-b085-2596b6444a7d"), 215m }
                });

            migrationBuilder.InsertData(
                table: "ManufacturerModels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("61871236-0fd8-4b84-a34b-8e7d14309786"), "RS6" },
                    { new Guid("7a5a818c-6106-4ac0-9a7e-c9450027291d"), "E60" }
                });

            migrationBuilder.InsertData(
                table: "SteeringWheelPos",
                columns: new[] { "Id", "Position" },
                values: new object[,]
                {
                    { new Guid("63108cc8-ab64-4aa3-9cc7-92f5e2187d26"), "Kairė" },
                    { new Guid("a678f96e-a02f-4ba9-a30a-538baf703c67"), "Dešinė" }
                });

            migrationBuilder.InsertData(
                table: "Transmissions",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("8dfc58e4-0d53-4e66-98b8-9117ebf76391"), "Automatinė" },
                    { new Guid("6edbb704-a7a3-4f69-8f0e-429727f50adc"), "Mechaninė" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Images_CarId",
                table: "Images",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Cars_CarId",
                table: "Images",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Cars_CarId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_CarId",
                table: "Images");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2a66039e-f447-4348-969d-5d09a735d5dc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a5556584-f587-4680-acd9-7ee6c5ddbca6"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("4af062a9-2439-4f28-b075-6634ac20bce8"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("4f0dbef2-b49c-4396-b3de-b9d4694cfa6b"));

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: new Guid("1dd774d1-097d-4bdc-ab83-43442f77b7f8"));

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: new Guid("e30056bc-1b6e-44f5-9de2-7255381430c8"));

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: new Guid("3d04b4af-bff0-443e-9f8f-271e7da967b8"));

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: new Guid("655bcc53-053d-43fc-bae1-035ad524901b"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("a6e612ba-b37c-4329-8c6e-d415ae9520e9"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("e041a12b-f267-4ab3-9a8d-0c6dd7d63118"));

            migrationBuilder.DeleteData(
                table: "Diameters",
                keyColumn: "Id",
                keyValue: new Guid("5c3d7b5b-f8e3-4eb6-9a2c-601aa44ef77c"));

            migrationBuilder.DeleteData(
                table: "Diameters",
                keyColumn: "Id",
                keyValue: new Guid("feb2f9bc-567a-4ebe-ab54-2d39dec5979f"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("1b3988c1-e392-45f3-bcf5-bdb1b59b85f8"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("fa7a0b4c-bc01-479a-8b3d-c137d67c0b29"));

            migrationBuilder.DeleteData(
                table: "FrameTypes",
                keyColumn: "Id",
                keyValue: new Guid("1fc67b35-c6b7-427f-aaf5-2d71ff1bdf1b"));

            migrationBuilder.DeleteData(
                table: "FrameTypes",
                keyColumn: "Id",
                keyValue: new Guid("aa1fc47f-1753-4ea5-a4d5-43c811586c83"));

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: new Guid("703cd7e6-65d7-4a47-9aef-07bae4b3465c"));

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: new Guid("e184a9c5-e2e9-4700-b847-47811f98a7c7"));

            migrationBuilder.DeleteData(
                table: "Heights",
                keyColumn: "Id",
                keyValue: new Guid("d9afc208-90ef-4b15-b085-2596b6444a7d"));

            migrationBuilder.DeleteData(
                table: "Heights",
                keyColumn: "Id",
                keyValue: new Guid("fb98e7ea-7d0f-47bc-bcef-420730ef9ad3"));

            migrationBuilder.DeleteData(
                table: "ManufacturerModels",
                keyColumn: "Id",
                keyValue: new Guid("61871236-0fd8-4b84-a34b-8e7d14309786"));

            migrationBuilder.DeleteData(
                table: "ManufacturerModels",
                keyColumn: "Id",
                keyValue: new Guid("7a5a818c-6106-4ac0-9a7e-c9450027291d"));

            migrationBuilder.DeleteData(
                table: "SteeringWheelPos",
                keyColumn: "Id",
                keyValue: new Guid("63108cc8-ab64-4aa3-9cc7-92f5e2187d26"));

            migrationBuilder.DeleteData(
                table: "SteeringWheelPos",
                keyColumn: "Id",
                keyValue: new Guid("a678f96e-a02f-4ba9-a30a-538baf703c67"));

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: new Guid("6edbb704-a7a3-4f69-8f0e-429727f50adc"));

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: new Guid("8dfc58e4-0d53-4e66-98b8-9117ebf76391"));

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "Images");

            migrationBuilder.AddColumn<Guid>(
                name: "CarsId",
                table: "Images",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("010bf490-e76d-43b1-aa8c-39f10c17d0ca"), "Automobilis" },
                    { new Guid("79d8ad81-86eb-4435-a7fe-854a1db6f0ab"), "Motociklas" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("ad7fdecb-7bc7-457b-b36a-58b3c451dee6"), "Balta" },
                    { new Guid("464967ce-4fee-4df9-8e59-d45bc51017c7"), "Juoda" }
                });

            migrationBuilder.InsertData(
                table: "Conditions",
                columns: new[] { "Id", "VehicCondition" },
                values: new object[,]
                {
                    { new Guid("025157ef-e5fd-4b1d-8bfe-8a84e88afaf7"), "Naudota" },
                    { new Guid("7018586b-736c-4b4d-9a3f-981bbde0418c"), "Nauja" }
                });

            migrationBuilder.InsertData(
                table: "Coolings",
                columns: new[] { "Id", "CoolingType" },
                values: new object[,]
                {
                    { new Guid("cf285d2b-12a7-42ab-9fdb-86f63b67c7de"), "Oru" },
                    { new Guid("57ba79a1-61be-4621-b35e-ab3ba1602876"), "Vandeniu" }
                });

            migrationBuilder.InsertData(
                table: "Defects",
                columns: new[] { "Id", "Defect" },
                values: new object[,]
                {
                    { new Guid("6699aa81-d93c-402a-ae24-bd3d684513ca"), "Be defetkų" },
                    { new Guid("73d5741c-6ba0-45e9-89aa-e8492b691263"), "Degęs" }
                });

            migrationBuilder.InsertData(
                table: "Diameters",
                columns: new[] { "Id", "TireDiameter" },
                values: new object[,]
                {
                    { new Guid("7f5d433b-1f81-40e6-9877-112a4cf223ed"), 17m },
                    { new Guid("f99dc17d-cb00-458b-8086-40a3a8c073e0"), 18m }
                });

            migrationBuilder.InsertData(
                table: "Doors",
                columns: new[] { "Id", "DoorCount" },
                values: new object[,]
                {
                    { new Guid("204679fc-2b32-4182-acf4-a93432c2743f"), "2/3" },
                    { new Guid("2ddcb346-43cb-4657-855c-98f9fec26a25"), "4/5" }
                });

            migrationBuilder.InsertData(
                table: "FrameTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("2a86b0ed-85e0-468c-8aee-6687ed7d795e"), "Universalas" },
                    { new Guid("3d0cd103-9b52-4227-a7b1-6cdbf947a1f5"), "Sedanas" }
                });

            migrationBuilder.InsertData(
                table: "FuelTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("79632e1e-4005-447c-9d64-55f11078306e"), "Benzinas" },
                    { new Guid("18f236c9-c171-4614-b4ce-a11ef2f880be"), "Dyzelinas" }
                });

            migrationBuilder.InsertData(
                table: "Heights",
                columns: new[] { "Id", "TireHeight" },
                values: new object[,]
                {
                    { new Guid("99ff90ae-92e7-42da-8f25-b629ab2f4ed4"), 205m },
                    { new Guid("1351fea5-60d8-4b81-afcc-236586033e48"), 215m }
                });

            migrationBuilder.InsertData(
                table: "ManufacturerModels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("52116167-adb1-4deb-9fab-6fbc7bce001b"), "RS6" },
                    { new Guid("45aa3c60-6820-4cbc-a4af-5d6009a14ab5"), "E60" }
                });

            migrationBuilder.InsertData(
                table: "SteeringWheelPos",
                columns: new[] { "Id", "Position" },
                values: new object[,]
                {
                    { new Guid("2fec891e-67e5-4006-8a25-419c8f6712d2"), "Kairė" },
                    { new Guid("55cc2351-4a40-4680-9d66-ff2b28af140f"), "Dešinė" }
                });

            migrationBuilder.InsertData(
                table: "Transmissions",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("3740372b-a6d8-4c8c-8042-e57537fad6c0"), "Automatinė" },
                    { new Guid("943d3a7b-302e-45de-855b-20cfb891a387"), "Mechaninė" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Images_CarsId",
                table: "Images",
                column: "CarsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Cars_CarsId",
                table: "Images",
                column: "CarsId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
