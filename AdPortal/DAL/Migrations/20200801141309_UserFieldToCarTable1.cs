using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class UserFieldToCarTable1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Users_UserId",
                table: "Cars");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3e783b72-6716-4941-88dc-5221b374d588"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8af98edc-c81e-4c66-985f-8fc58620df71"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("59dbcbb1-bcdf-4bd6-a085-350fb065d026"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("99eee46b-a929-4796-8ad4-9bfbfe5db0f9"));

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: new Guid("0cda78a3-c638-40c0-b77d-2d1d8400b21c"));

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: new Guid("eb512879-f0ba-41a7-9813-82487838daae"));

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: new Guid("16f216e5-1861-45bb-845a-f031b0770eb1"));

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: new Guid("de3c295c-75a7-4480-9bcc-afda817b2c9f"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("03143806-7dee-4ee0-b48c-2c956980bef2"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("68c409ec-e7b1-42a9-9dd4-483a36191814"));

            migrationBuilder.DeleteData(
                table: "Diameters",
                keyColumn: "Id",
                keyValue: new Guid("dacee200-121a-4123-ad4d-c782d8f4a5de"));

            migrationBuilder.DeleteData(
                table: "Diameters",
                keyColumn: "Id",
                keyValue: new Guid("e534d088-2337-42a9-a05f-efb9cb441038"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("104966ef-9988-40bd-8532-2a54c51b7f8e"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("3204ee63-01bf-427b-9dd0-ddaa92e73635"));

            migrationBuilder.DeleteData(
                table: "FrameTypes",
                keyColumn: "Id",
                keyValue: new Guid("5c5ba7f9-4503-400f-bf00-737be7b2e3b8"));

            migrationBuilder.DeleteData(
                table: "FrameTypes",
                keyColumn: "Id",
                keyValue: new Guid("f820e4f3-3c17-4542-906e-e4310fff835c"));

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: new Guid("a183bf42-42bc-4eb5-88fb-49fbca21055f"));

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: new Guid("cb872ce2-077b-4609-909c-45449e7d637b"));

            migrationBuilder.DeleteData(
                table: "Heights",
                keyColumn: "Id",
                keyValue: new Guid("46f2b539-819d-4171-9d40-ce47763ebff2"));

            migrationBuilder.DeleteData(
                table: "Heights",
                keyColumn: "Id",
                keyValue: new Guid("9861948a-528e-4b49-84a4-0f94cb79e210"));

            migrationBuilder.DeleteData(
                table: "ManufacturerModels",
                keyColumn: "Id",
                keyValue: new Guid("911663cc-09ab-403c-b51b-d9c17e58b6b3"));

            migrationBuilder.DeleteData(
                table: "ManufacturerModels",
                keyColumn: "Id",
                keyValue: new Guid("dbc3cf1f-0e71-48d8-8692-48bd83e50ef8"));

            migrationBuilder.DeleteData(
                table: "SteeringWheelPos",
                keyColumn: "Id",
                keyValue: new Guid("4fc2925d-b369-40c9-8570-4e935fc86856"));

            migrationBuilder.DeleteData(
                table: "SteeringWheelPos",
                keyColumn: "Id",
                keyValue: new Guid("dc9b894d-b2b3-4eaa-bab2-d3a7441390df"));

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: new Guid("7a20609e-d43f-403d-b943-8e49b99e09e3"));

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: new Guid("c2c5ef44-a50f-41fa-8d4e-d3d7fb6ddf83"));

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Cars",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

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
                name: "FK_Cars_Users_UserId",
                table: "Cars",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Users_UserId",
                table: "Cars");

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

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Cars",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("8af98edc-c81e-4c66-985f-8fc58620df71"), "Automobilis" },
                    { new Guid("3e783b72-6716-4941-88dc-5221b374d588"), "Motociklas" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("99eee46b-a929-4796-8ad4-9bfbfe5db0f9"), "Balta" },
                    { new Guid("59dbcbb1-bcdf-4bd6-a085-350fb065d026"), "Juoda" }
                });

            migrationBuilder.InsertData(
                table: "Conditions",
                columns: new[] { "Id", "VehicCondition" },
                values: new object[,]
                {
                    { new Guid("eb512879-f0ba-41a7-9813-82487838daae"), "Naudota" },
                    { new Guid("0cda78a3-c638-40c0-b77d-2d1d8400b21c"), "Nauja" }
                });

            migrationBuilder.InsertData(
                table: "Coolings",
                columns: new[] { "Id", "CoolingType" },
                values: new object[,]
                {
                    { new Guid("de3c295c-75a7-4480-9bcc-afda817b2c9f"), "Oru" },
                    { new Guid("16f216e5-1861-45bb-845a-f031b0770eb1"), "Vandeniu" }
                });

            migrationBuilder.InsertData(
                table: "Defects",
                columns: new[] { "Id", "Defect" },
                values: new object[,]
                {
                    { new Guid("03143806-7dee-4ee0-b48c-2c956980bef2"), "Be defetkų" },
                    { new Guid("68c409ec-e7b1-42a9-9dd4-483a36191814"), "Degęs" }
                });

            migrationBuilder.InsertData(
                table: "Diameters",
                columns: new[] { "Id", "TireDiameter" },
                values: new object[,]
                {
                    { new Guid("dacee200-121a-4123-ad4d-c782d8f4a5de"), 17m },
                    { new Guid("e534d088-2337-42a9-a05f-efb9cb441038"), 18m }
                });

            migrationBuilder.InsertData(
                table: "Doors",
                columns: new[] { "Id", "DoorCount" },
                values: new object[,]
                {
                    { new Guid("3204ee63-01bf-427b-9dd0-ddaa92e73635"), "2/3" },
                    { new Guid("104966ef-9988-40bd-8532-2a54c51b7f8e"), "4/5" }
                });

            migrationBuilder.InsertData(
                table: "FrameTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("5c5ba7f9-4503-400f-bf00-737be7b2e3b8"), "Universalas" },
                    { new Guid("f820e4f3-3c17-4542-906e-e4310fff835c"), "Sedanas" }
                });

            migrationBuilder.InsertData(
                table: "FuelTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("cb872ce2-077b-4609-909c-45449e7d637b"), "Benzinas" },
                    { new Guid("a183bf42-42bc-4eb5-88fb-49fbca21055f"), "Dyzelinas" }
                });

            migrationBuilder.InsertData(
                table: "Heights",
                columns: new[] { "Id", "TireHeight" },
                values: new object[,]
                {
                    { new Guid("9861948a-528e-4b49-84a4-0f94cb79e210"), 205m },
                    { new Guid("46f2b539-819d-4171-9d40-ce47763ebff2"), 215m }
                });

            migrationBuilder.InsertData(
                table: "ManufacturerModels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("911663cc-09ab-403c-b51b-d9c17e58b6b3"), "RS6" },
                    { new Guid("dbc3cf1f-0e71-48d8-8692-48bd83e50ef8"), "E60" }
                });

            migrationBuilder.InsertData(
                table: "SteeringWheelPos",
                columns: new[] { "Id", "Position" },
                values: new object[,]
                {
                    { new Guid("dc9b894d-b2b3-4eaa-bab2-d3a7441390df"), "Kairė" },
                    { new Guid("4fc2925d-b369-40c9-8570-4e935fc86856"), "Dešinė" }
                });

            migrationBuilder.InsertData(
                table: "Transmissions",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("7a20609e-d43f-403d-b943-8e49b99e09e3"), "Automatinė" },
                    { new Guid("c2c5ef44-a50f-41fa-8d4e-d3d7fb6ddf83"), "Mechaninė" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Users_UserId",
                table: "Cars",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
