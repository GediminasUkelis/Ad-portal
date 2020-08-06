using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class AddImageTableToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Cars_CarsId",
                table: "Images");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Images",
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

            migrationBuilder.RenameTable(
                name: "Images",
                newName: "Image");

            migrationBuilder.AddColumn<Guid>(
                name: "CarId",
                table: "Image",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "MotorbikeId",
                table: "Image",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TireId",
                table: "Image",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Image",
                table: "Image",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Image_CarId",
                table: "Image",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_MotorbikeId",
                table: "Image",
                column: "MotorbikeId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_TireId",
                table: "Image",
                column: "TireId");

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Cars_CarId",
                table: "Image",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Motorbikes_MotorbikeId",
                table: "Image",
                column: "MotorbikeId",
                principalTable: "Motorbikes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Tires_TireId",
                table: "Image",
                column: "TireId",
                principalTable: "Tires",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Image_Cars_CarId",
                table: "Image");

            migrationBuilder.DropForeignKey(
                name: "FK_Image_Motorbikes_MotorbikeId",
                table: "Image");

            migrationBuilder.DropForeignKey(
                name: "FK_Image_Tires_TireId",
                table: "Image");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Image",
                table: "Image");

            migrationBuilder.DropIndex(
                name: "IX_Image_CarId",
                table: "Image");

            migrationBuilder.DropIndex(
                name: "IX_Image_MotorbikeId",
                table: "Image");

            migrationBuilder.DropIndex(
                name: "IX_Image_TireId",
                table: "Image");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "Image");

            migrationBuilder.DropColumn(
                name: "MotorbikeId",
                table: "Image");

            migrationBuilder.DropColumn(
                name: "TireId",
                table: "Image");

            migrationBuilder.RenameTable(
                name: "Image",
                newName: "Images");

            migrationBuilder.AddColumn<Guid>(
                name: "CarsId",
                table: "Images",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Images",
                table: "Images",
                column: "Id");

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
