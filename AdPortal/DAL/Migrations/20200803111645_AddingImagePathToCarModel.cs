using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class AddingImagePathToCarModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Motorbikes_Users_UserId",
                table: "Motorbikes");

            migrationBuilder.DropForeignKey(
                name: "FK_Tires_Users_UserId",
                table: "Tires");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0a2b2778-b363-4aa6-8c69-d521b07b7dea"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8fa096bc-4754-4ee1-9eaa-c94d1652db7b"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("6eb01d0c-0bbc-4e84-9a8f-9dd29a55cc2a"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("98ceab2b-22eb-4adf-a8a3-29d0cd9f64ef"));

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: new Guid("3cf42a9b-6865-43c4-829a-45430bbf35ba"));

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: new Guid("f40b8acf-0bfd-428e-bc9f-ebbaa232db70"));

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: new Guid("527bac95-92d7-47bc-ab92-cf285cfc16d3"));

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: new Guid("96e387bb-22d5-4f14-a717-894596bc9d2a"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("0ba1f417-4a6a-4182-9b67-db152a10a9a0"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("a170bb85-0c1d-4fea-b71c-44c602de828b"));

            migrationBuilder.DeleteData(
                table: "Diameters",
                keyColumn: "Id",
                keyValue: new Guid("c428fe91-5678-4337-a116-f2d9af39d8c9"));

            migrationBuilder.DeleteData(
                table: "Diameters",
                keyColumn: "Id",
                keyValue: new Guid("c51b6707-4560-47f5-a75f-a9dee9b8f9a5"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("363025d4-878b-4a2a-bd1c-4d1488f750d7"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("8a77402f-3114-427a-b19f-44624a7eb2d4"));

            migrationBuilder.DeleteData(
                table: "FrameTypes",
                keyColumn: "Id",
                keyValue: new Guid("7073bec9-9f70-4c83-b2bb-3b461ccb9a46"));

            migrationBuilder.DeleteData(
                table: "FrameTypes",
                keyColumn: "Id",
                keyValue: new Guid("93990847-cfa4-4bcd-82c0-1f1863043d27"));

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: new Guid("90d62119-150d-44fa-b764-c721881ebdaa"));

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: new Guid("c2f8e777-2701-47ff-85fb-334df1977672"));

            migrationBuilder.DeleteData(
                table: "Heights",
                keyColumn: "Id",
                keyValue: new Guid("a2ab7af9-37b8-4200-ad54-9cbed18d7515"));

            migrationBuilder.DeleteData(
                table: "Heights",
                keyColumn: "Id",
                keyValue: new Guid("ebba0f29-5c84-45e4-99a2-08b50466cd87"));

            migrationBuilder.DeleteData(
                table: "ManufacturerModels",
                keyColumn: "Id",
                keyValue: new Guid("0c4b8f4f-c923-4a99-9be0-22109c705130"));

            migrationBuilder.DeleteData(
                table: "ManufacturerModels",
                keyColumn: "Id",
                keyValue: new Guid("7511965b-1ee2-4624-b9a2-c10fb6b7e75f"));

            migrationBuilder.DeleteData(
                table: "SteeringWheelPos",
                keyColumn: "Id",
                keyValue: new Guid("0f68c2aa-eebe-4cce-a40c-8dbd6ed11b42"));

            migrationBuilder.DeleteData(
                table: "SteeringWheelPos",
                keyColumn: "Id",
                keyValue: new Guid("6e21f442-b70a-4688-9575-c5b1f3e0b6dc"));

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: new Guid("934344c6-8ae4-49db-bc1f-84de4199125f"));

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: new Guid("c15518bc-8441-450a-aa3b-b4af71834d17"));

            migrationBuilder.DropColumn(
                name: "Bytes",
                table: "Images");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Tires",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Motorbikes",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Path",
                table: "Images",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Motorbikes_Users_UserId",
                table: "Motorbikes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tires_Users_UserId",
                table: "Tires",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Motorbikes_Users_UserId",
                table: "Motorbikes");

            migrationBuilder.DropForeignKey(
                name: "FK_Tires_Users_UserId",
                table: "Tires");

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
                name: "Path",
                table: "Images");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Tires",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Motorbikes",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddColumn<string>(
                name: "Bytes",
                table: "Images",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("8fa096bc-4754-4ee1-9eaa-c94d1652db7b"), "Automobilis" },
                    { new Guid("0a2b2778-b363-4aa6-8c69-d521b07b7dea"), "Motociklas" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("6eb01d0c-0bbc-4e84-9a8f-9dd29a55cc2a"), "Balta" },
                    { new Guid("98ceab2b-22eb-4adf-a8a3-29d0cd9f64ef"), "Juoda" }
                });

            migrationBuilder.InsertData(
                table: "Conditions",
                columns: new[] { "Id", "VehicCondition" },
                values: new object[,]
                {
                    { new Guid("3cf42a9b-6865-43c4-829a-45430bbf35ba"), "Naudota" },
                    { new Guid("f40b8acf-0bfd-428e-bc9f-ebbaa232db70"), "Nauja" }
                });

            migrationBuilder.InsertData(
                table: "Coolings",
                columns: new[] { "Id", "CoolingType" },
                values: new object[,]
                {
                    { new Guid("96e387bb-22d5-4f14-a717-894596bc9d2a"), "Oru" },
                    { new Guid("527bac95-92d7-47bc-ab92-cf285cfc16d3"), "Vandeniu" }
                });

            migrationBuilder.InsertData(
                table: "Defects",
                columns: new[] { "Id", "Defect" },
                values: new object[,]
                {
                    { new Guid("a170bb85-0c1d-4fea-b71c-44c602de828b"), "Be defetkų" },
                    { new Guid("0ba1f417-4a6a-4182-9b67-db152a10a9a0"), "Degęs" }
                });

            migrationBuilder.InsertData(
                table: "Diameters",
                columns: new[] { "Id", "TireDiameter" },
                values: new object[,]
                {
                    { new Guid("c51b6707-4560-47f5-a75f-a9dee9b8f9a5"), 17m },
                    { new Guid("c428fe91-5678-4337-a116-f2d9af39d8c9"), 18m }
                });

            migrationBuilder.InsertData(
                table: "Doors",
                columns: new[] { "Id", "DoorCount" },
                values: new object[,]
                {
                    { new Guid("363025d4-878b-4a2a-bd1c-4d1488f750d7"), "2/3" },
                    { new Guid("8a77402f-3114-427a-b19f-44624a7eb2d4"), "4/5" }
                });

            migrationBuilder.InsertData(
                table: "FrameTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("93990847-cfa4-4bcd-82c0-1f1863043d27"), "Universalas" },
                    { new Guid("7073bec9-9f70-4c83-b2bb-3b461ccb9a46"), "Sedanas" }
                });

            migrationBuilder.InsertData(
                table: "FuelTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("90d62119-150d-44fa-b764-c721881ebdaa"), "Benzinas" },
                    { new Guid("c2f8e777-2701-47ff-85fb-334df1977672"), "Dyzelinas" }
                });

            migrationBuilder.InsertData(
                table: "Heights",
                columns: new[] { "Id", "TireHeight" },
                values: new object[,]
                {
                    { new Guid("ebba0f29-5c84-45e4-99a2-08b50466cd87"), 205m },
                    { new Guid("a2ab7af9-37b8-4200-ad54-9cbed18d7515"), 215m }
                });

            migrationBuilder.InsertData(
                table: "ManufacturerModels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0c4b8f4f-c923-4a99-9be0-22109c705130"), "RS6" },
                    { new Guid("7511965b-1ee2-4624-b9a2-c10fb6b7e75f"), "E60" }
                });

            migrationBuilder.InsertData(
                table: "SteeringWheelPos",
                columns: new[] { "Id", "Position" },
                values: new object[,]
                {
                    { new Guid("6e21f442-b70a-4688-9575-c5b1f3e0b6dc"), "Kairė" },
                    { new Guid("0f68c2aa-eebe-4cce-a40c-8dbd6ed11b42"), "Dešinė" }
                });

            migrationBuilder.InsertData(
                table: "Transmissions",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("c15518bc-8441-450a-aa3b-b4af71834d17"), "Automatinė" },
                    { new Guid("934344c6-8ae4-49db-bc1f-84de4199125f"), "Mechaninė" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Motorbikes_Users_UserId",
                table: "Motorbikes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tires_Users_UserId",
                table: "Tires",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
