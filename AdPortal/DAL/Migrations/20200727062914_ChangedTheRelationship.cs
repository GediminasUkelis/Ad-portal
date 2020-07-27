using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class ChangedTheRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Images_ImageId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_ImageId",
                table: "Cars");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0b2f8875-6447-4287-a097-364ca9ecd7ea"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7a65d294-33ba-4248-9a22-b3924d2affec"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("1c8358be-a3ca-4b80-8d8c-9d287f322988"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("c3c3da8c-8eb2-4e0f-b119-b6b019de97af"));

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: new Guid("1e7c6f0a-0bf6-401d-bfa6-75931876e0aa"));

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: new Guid("342033e6-c732-4c77-9113-cc57ef3a71e6"));

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: new Guid("2f37357b-337c-4d28-a257-58f41c9dc7ba"));

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: new Guid("38c5497e-80a4-4bf2-901c-341102017c67"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("1a31482f-75b8-402f-b374-615d58c6d801"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("fdd9999e-775d-479d-8366-45e2241aaca4"));

            migrationBuilder.DeleteData(
                table: "Diameters",
                keyColumn: "Id",
                keyValue: new Guid("038a0aef-2024-475f-833b-c07a4ea2039b"));

            migrationBuilder.DeleteData(
                table: "Diameters",
                keyColumn: "Id",
                keyValue: new Guid("a8a41964-9d2e-46bf-b8b2-58204e816b30"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("998c41ea-4429-477f-b4e4-77e1db845202"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("b3024581-b843-4a31-803d-3915bfa04c8f"));

            migrationBuilder.DeleteData(
                table: "FrameTypes",
                keyColumn: "Id",
                keyValue: new Guid("14559818-5126-4840-b6d4-bb0360d5eff0"));

            migrationBuilder.DeleteData(
                table: "FrameTypes",
                keyColumn: "Id",
                keyValue: new Guid("a251c6ac-d814-476e-9fa5-936532b513be"));

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: new Guid("5162f7d1-dc28-4065-871a-31b32872f165"));

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: new Guid("79257db4-27b6-4d4b-89ad-3a2490653999"));

            migrationBuilder.DeleteData(
                table: "Heights",
                keyColumn: "Id",
                keyValue: new Guid("6079546a-ba39-48d5-8bb6-3bdeeb8728a9"));

            migrationBuilder.DeleteData(
                table: "Heights",
                keyColumn: "Id",
                keyValue: new Guid("72b24c99-6118-4c4e-9ef6-a02279eeb614"));

            migrationBuilder.DeleteData(
                table: "ManufacturerModels",
                keyColumn: "Id",
                keyValue: new Guid("c774f0d9-c45c-47b0-9e85-c039e0cabb50"));

            migrationBuilder.DeleteData(
                table: "ManufacturerModels",
                keyColumn: "Id",
                keyValue: new Guid("dcbf7ebd-7251-422f-b565-aa59629edab9"));

            migrationBuilder.DeleteData(
                table: "SteeringWheelPos",
                keyColumn: "Id",
                keyValue: new Guid("ae7347ba-f93e-47da-9cba-c66c602360e0"));

            migrationBuilder.DeleteData(
                table: "SteeringWheelPos",
                keyColumn: "Id",
                keyValue: new Guid("de1a37dc-95af-462e-b6f6-39c268fd9a12"));

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: new Guid("5d8552c4-43d5-4c9a-ab6a-788b84ee64eb"));

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: new Guid("74106af1-ef9a-41dc-8e66-87881eaeea69"));

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Cars");

            migrationBuilder.AddColumn<Guid>(
                name: "CarsId",
                table: "Images",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("561718c7-a554-4e58-828f-0bb9490694d2"), "Automobilis" },
                    { new Guid("72a8f2d1-a82e-4234-9418-b215c3fae451"), "Motociklas" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1c207fcc-55f0-4d66-90bc-a7975d169654"), "Balta" },
                    { new Guid("ff1b7331-f97a-4c2c-979e-2aefb0e0c765"), "Juoda" }
                });

            migrationBuilder.InsertData(
                table: "Conditions",
                columns: new[] { "Id", "VehicCondition" },
                values: new object[,]
                {
                    { new Guid("ff2bbd22-3ac5-44a6-a43b-a5791f1be29a"), "Naudota" },
                    { new Guid("b423a103-28af-4461-ba48-e8481e324d0f"), "Nauja" }
                });

            migrationBuilder.InsertData(
                table: "Coolings",
                columns: new[] { "Id", "CoolingType" },
                values: new object[,]
                {
                    { new Guid("edfaf6a4-3a5e-4cbf-9ec5-f2699e8245b1"), "Oru" },
                    { new Guid("e1c021ba-8655-4b6d-8270-ef23913fb233"), "Vandeniu" }
                });

            migrationBuilder.InsertData(
                table: "Defects",
                columns: new[] { "Id", "Defect" },
                values: new object[,]
                {
                    { new Guid("a3417e17-46c4-4785-8f1a-b44c69f9d816"), "Be defetkų" },
                    { new Guid("2148286f-93f9-4bfd-abaf-27f24dc11aef"), "Degęs" }
                });

            migrationBuilder.InsertData(
                table: "Diameters",
                columns: new[] { "Id", "TireDiameter" },
                values: new object[,]
                {
                    { new Guid("e113a10b-2b27-41a1-9d02-b454b4984804"), 17m },
                    { new Guid("461201d6-a303-41d1-9342-4c4484dd9138"), 18m }
                });

            migrationBuilder.InsertData(
                table: "Doors",
                columns: new[] { "Id", "DoorCount" },
                values: new object[,]
                {
                    { new Guid("3043ecc5-53be-4e75-9b4f-966a4e65e0ad"), "2/3" },
                    { new Guid("b9a0b9f7-94b8-42f1-b69e-e0bf8fd7ea24"), "4/5" }
                });

            migrationBuilder.InsertData(
                table: "FrameTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("306543ce-ba1b-4b34-827f-2e34185b31e7"), "Universalas" },
                    { new Guid("3866ba2e-1062-4c0b-90eb-e06f38a8ff83"), "Sedanas" }
                });

            migrationBuilder.InsertData(
                table: "FuelTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("b999dd2d-d2eb-41f4-a52d-30498355e4d1"), "Benzinas" },
                    { new Guid("9e9609cc-7af9-455d-9c76-bfa6c1f06c9c"), "Dyzelinas" }
                });

            migrationBuilder.InsertData(
                table: "Heights",
                columns: new[] { "Id", "TireHeight" },
                values: new object[,]
                {
                    { new Guid("34177ec1-3722-494f-9d0e-c01275be6052"), 205m },
                    { new Guid("3dc42c9d-22aa-4047-b0b3-87a50c0fb8a5"), 215m }
                });

            migrationBuilder.InsertData(
                table: "ManufacturerModels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("9369b9a9-a570-44b7-9d0c-ce39d911952a"), "RS6" },
                    { new Guid("f62f9714-b3b4-4b38-bf64-a258d9d343c2"), "E60" }
                });

            migrationBuilder.InsertData(
                table: "SteeringWheelPos",
                columns: new[] { "Id", "Position" },
                values: new object[,]
                {
                    { new Guid("ec625ecb-b0c3-427f-96de-0bb0228ddb0c"), "Kairė" },
                    { new Guid("61e45246-19d5-4f8f-be1d-aae23c6a5cd8"), "Dešinė" }
                });

            migrationBuilder.InsertData(
                table: "Transmissions",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("c032d083-ae4c-4e98-acca-fd355f701699"), "Automatinė" },
                    { new Guid("7f52790d-0a38-4997-a7eb-5103dc1cf411"), "Mechaninė" }
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: new Guid("561718c7-a554-4e58-828f-0bb9490694d2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("72a8f2d1-a82e-4234-9418-b215c3fae451"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("1c207fcc-55f0-4d66-90bc-a7975d169654"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("ff1b7331-f97a-4c2c-979e-2aefb0e0c765"));

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: new Guid("b423a103-28af-4461-ba48-e8481e324d0f"));

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: new Guid("ff2bbd22-3ac5-44a6-a43b-a5791f1be29a"));

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: new Guid("e1c021ba-8655-4b6d-8270-ef23913fb233"));

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: new Guid("edfaf6a4-3a5e-4cbf-9ec5-f2699e8245b1"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("2148286f-93f9-4bfd-abaf-27f24dc11aef"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("a3417e17-46c4-4785-8f1a-b44c69f9d816"));

            migrationBuilder.DeleteData(
                table: "Diameters",
                keyColumn: "Id",
                keyValue: new Guid("461201d6-a303-41d1-9342-4c4484dd9138"));

            migrationBuilder.DeleteData(
                table: "Diameters",
                keyColumn: "Id",
                keyValue: new Guid("e113a10b-2b27-41a1-9d02-b454b4984804"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("3043ecc5-53be-4e75-9b4f-966a4e65e0ad"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("b9a0b9f7-94b8-42f1-b69e-e0bf8fd7ea24"));

            migrationBuilder.DeleteData(
                table: "FrameTypes",
                keyColumn: "Id",
                keyValue: new Guid("306543ce-ba1b-4b34-827f-2e34185b31e7"));

            migrationBuilder.DeleteData(
                table: "FrameTypes",
                keyColumn: "Id",
                keyValue: new Guid("3866ba2e-1062-4c0b-90eb-e06f38a8ff83"));

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: new Guid("9e9609cc-7af9-455d-9c76-bfa6c1f06c9c"));

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: new Guid("b999dd2d-d2eb-41f4-a52d-30498355e4d1"));

            migrationBuilder.DeleteData(
                table: "Heights",
                keyColumn: "Id",
                keyValue: new Guid("34177ec1-3722-494f-9d0e-c01275be6052"));

            migrationBuilder.DeleteData(
                table: "Heights",
                keyColumn: "Id",
                keyValue: new Guid("3dc42c9d-22aa-4047-b0b3-87a50c0fb8a5"));

            migrationBuilder.DeleteData(
                table: "ManufacturerModels",
                keyColumn: "Id",
                keyValue: new Guid("9369b9a9-a570-44b7-9d0c-ce39d911952a"));

            migrationBuilder.DeleteData(
                table: "ManufacturerModels",
                keyColumn: "Id",
                keyValue: new Guid("f62f9714-b3b4-4b38-bf64-a258d9d343c2"));

            migrationBuilder.DeleteData(
                table: "SteeringWheelPos",
                keyColumn: "Id",
                keyValue: new Guid("61e45246-19d5-4f8f-be1d-aae23c6a5cd8"));

            migrationBuilder.DeleteData(
                table: "SteeringWheelPos",
                keyColumn: "Id",
                keyValue: new Guid("ec625ecb-b0c3-427f-96de-0bb0228ddb0c"));

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: new Guid("7f52790d-0a38-4997-a7eb-5103dc1cf411"));

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: new Guid("c032d083-ae4c-4e98-acca-fd355f701699"));

            migrationBuilder.DropColumn(
                name: "CarsId",
                table: "Images");

            migrationBuilder.AddColumn<Guid>(
                name: "ImageId",
                table: "Cars",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("7a65d294-33ba-4248-9a22-b3924d2affec"), "Automobilis" },
                    { new Guid("0b2f8875-6447-4287-a097-364ca9ecd7ea"), "Motociklas" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("c3c3da8c-8eb2-4e0f-b119-b6b019de97af"), "Balta" },
                    { new Guid("1c8358be-a3ca-4b80-8d8c-9d287f322988"), "Juoda" }
                });

            migrationBuilder.InsertData(
                table: "Conditions",
                columns: new[] { "Id", "VehicCondition" },
                values: new object[,]
                {
                    { new Guid("342033e6-c732-4c77-9113-cc57ef3a71e6"), "Naudota" },
                    { new Guid("1e7c6f0a-0bf6-401d-bfa6-75931876e0aa"), "Nauja" }
                });

            migrationBuilder.InsertData(
                table: "Coolings",
                columns: new[] { "Id", "CoolingType" },
                values: new object[,]
                {
                    { new Guid("2f37357b-337c-4d28-a257-58f41c9dc7ba"), "Oru" },
                    { new Guid("38c5497e-80a4-4bf2-901c-341102017c67"), "Vandeniu" }
                });

            migrationBuilder.InsertData(
                table: "Defects",
                columns: new[] { "Id", "Defect" },
                values: new object[,]
                {
                    { new Guid("1a31482f-75b8-402f-b374-615d58c6d801"), "Be defetkų" },
                    { new Guid("fdd9999e-775d-479d-8366-45e2241aaca4"), "Degęs" }
                });

            migrationBuilder.InsertData(
                table: "Diameters",
                columns: new[] { "Id", "TireDiameter" },
                values: new object[,]
                {
                    { new Guid("038a0aef-2024-475f-833b-c07a4ea2039b"), 17m },
                    { new Guid("a8a41964-9d2e-46bf-b8b2-58204e816b30"), 18m }
                });

            migrationBuilder.InsertData(
                table: "Doors",
                columns: new[] { "Id", "DoorCount" },
                values: new object[,]
                {
                    { new Guid("b3024581-b843-4a31-803d-3915bfa04c8f"), "2/3" },
                    { new Guid("998c41ea-4429-477f-b4e4-77e1db845202"), "4/5" }
                });

            migrationBuilder.InsertData(
                table: "FrameTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("a251c6ac-d814-476e-9fa5-936532b513be"), "Universalas" },
                    { new Guid("14559818-5126-4840-b6d4-bb0360d5eff0"), "Sedanas" }
                });

            migrationBuilder.InsertData(
                table: "FuelTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("79257db4-27b6-4d4b-89ad-3a2490653999"), "Benzinas" },
                    { new Guid("5162f7d1-dc28-4065-871a-31b32872f165"), "Dyzelinas" }
                });

            migrationBuilder.InsertData(
                table: "Heights",
                columns: new[] { "Id", "TireHeight" },
                values: new object[,]
                {
                    { new Guid("72b24c99-6118-4c4e-9ef6-a02279eeb614"), 205m },
                    { new Guid("6079546a-ba39-48d5-8bb6-3bdeeb8728a9"), 215m }
                });

            migrationBuilder.InsertData(
                table: "ManufacturerModels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("c774f0d9-c45c-47b0-9e85-c039e0cabb50"), "RS6" },
                    { new Guid("dcbf7ebd-7251-422f-b565-aa59629edab9"), "E60" }
                });

            migrationBuilder.InsertData(
                table: "SteeringWheelPos",
                columns: new[] { "Id", "Position" },
                values: new object[,]
                {
                    { new Guid("ae7347ba-f93e-47da-9cba-c66c602360e0"), "Kairė" },
                    { new Guid("de1a37dc-95af-462e-b6f6-39c268fd9a12"), "Dešinė" }
                });

            migrationBuilder.InsertData(
                table: "Transmissions",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("74106af1-ef9a-41dc-8e66-87881eaeea69"), "Automatinė" },
                    { new Guid("5d8552c4-43d5-4c9a-ab6a-788b84ee64eb"), "Mechaninė" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ImageId",
                table: "Cars",
                column: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Images_ImageId",
                table: "Cars",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
