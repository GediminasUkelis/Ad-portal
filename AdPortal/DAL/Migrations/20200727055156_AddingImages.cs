using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class AddingImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d30bbb50-ff6c-4b55-a141-6559e781a853"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e526195e-dacc-4b7e-bf9b-b02144f305d1"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("10af77ae-eb15-4f39-abbb-27cf4e9c5d92"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("539154a5-87b2-4ac0-bba7-df334fb29f82"));

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: new Guid("202caf59-0e97-421f-a7ec-7a5ee9d7e1df"));

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: new Guid("dcdbc2b8-2b73-432f-9a99-a1775ac88446"));

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: new Guid("84a64bc5-1aef-4906-84a3-c6fdf12b21c8"));

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: new Guid("d09d3d7e-be41-435c-ad80-4e9ec6076eea"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("35578b12-b6c5-4579-b819-13578c94257e"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("4210b410-3bc4-4117-8f30-7e371c086ea5"));

            migrationBuilder.DeleteData(
                table: "Diameters",
                keyColumn: "Id",
                keyValue: new Guid("0abf991f-56ac-4452-8413-f9c551fd68be"));

            migrationBuilder.DeleteData(
                table: "Diameters",
                keyColumn: "Id",
                keyValue: new Guid("bec0415f-c9a4-4817-b2d7-fe6b83742d79"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("1278cdec-d576-495f-a455-e17f5e422559"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("f787004d-8785-4ac7-9d05-b9de40adfc00"));

            migrationBuilder.DeleteData(
                table: "FrameTypes",
                keyColumn: "Id",
                keyValue: new Guid("708d0b54-bd6b-4525-b6d5-b8509751db96"));

            migrationBuilder.DeleteData(
                table: "FrameTypes",
                keyColumn: "Id",
                keyValue: new Guid("8dd54ba0-77d9-477e-9359-c4e1e2b32e40"));

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: new Guid("2a9fc8b9-89e6-41e6-b8bc-47eaf63c81ad"));

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: new Guid("e1a42d40-43d2-4bb4-b306-bbaf8bcc15c8"));

            migrationBuilder.DeleteData(
                table: "Heights",
                keyColumn: "Id",
                keyValue: new Guid("6e61bca7-2aeb-4873-8d0c-dd7520b52e4b"));

            migrationBuilder.DeleteData(
                table: "Heights",
                keyColumn: "Id",
                keyValue: new Guid("f4d1026e-bc6e-4a19-9093-809335887abb"));

            migrationBuilder.DeleteData(
                table: "ManufacturerModels",
                keyColumn: "Id",
                keyValue: new Guid("01ba5fae-1f42-4293-933c-990cf9c3a978"));

            migrationBuilder.DeleteData(
                table: "ManufacturerModels",
                keyColumn: "Id",
                keyValue: new Guid("72119bd5-6b8d-4767-92c2-272ad72409bc"));

            migrationBuilder.DeleteData(
                table: "SteeringWheelPos",
                keyColumn: "Id",
                keyValue: new Guid("19e0895d-533b-4245-b8ef-3c426dcfba23"));

            migrationBuilder.DeleteData(
                table: "SteeringWheelPos",
                keyColumn: "Id",
                keyValue: new Guid("711c0c2b-b3b7-4f4f-9b3d-6cd4a7b03d02"));

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: new Guid("743492d4-b11d-40c1-9e45-970a6ed824fa"));

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: new Guid("93f18b0d-fe91-46f3-b173-e2869a91ca89"));

            migrationBuilder.AddColumn<Guid>(
                name: "ImageId",
                table: "Cars",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Bytes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Images_ImageId",
                table: "Cars");

            migrationBuilder.DropTable(
                name: "Images");

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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("e526195e-dacc-4b7e-bf9b-b02144f305d1"), "Automobilis" },
                    { new Guid("d30bbb50-ff6c-4b55-a141-6559e781a853"), "Motociklas" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("10af77ae-eb15-4f39-abbb-27cf4e9c5d92"), "Balta" },
                    { new Guid("539154a5-87b2-4ac0-bba7-df334fb29f82"), "Juoda" }
                });

            migrationBuilder.InsertData(
                table: "Conditions",
                columns: new[] { "Id", "VehicCondition" },
                values: new object[,]
                {
                    { new Guid("202caf59-0e97-421f-a7ec-7a5ee9d7e1df"), "Naudota" },
                    { new Guid("dcdbc2b8-2b73-432f-9a99-a1775ac88446"), "Nauja" }
                });

            migrationBuilder.InsertData(
                table: "Coolings",
                columns: new[] { "Id", "CoolingType" },
                values: new object[,]
                {
                    { new Guid("d09d3d7e-be41-435c-ad80-4e9ec6076eea"), "Oru" },
                    { new Guid("84a64bc5-1aef-4906-84a3-c6fdf12b21c8"), "Vandeniu" }
                });

            migrationBuilder.InsertData(
                table: "Defects",
                columns: new[] { "Id", "Defect" },
                values: new object[,]
                {
                    { new Guid("4210b410-3bc4-4117-8f30-7e371c086ea5"), "Be defetkų" },
                    { new Guid("35578b12-b6c5-4579-b819-13578c94257e"), "Degęs" }
                });

            migrationBuilder.InsertData(
                table: "Diameters",
                columns: new[] { "Id", "TireDiameter" },
                values: new object[,]
                {
                    { new Guid("bec0415f-c9a4-4817-b2d7-fe6b83742d79"), 17m },
                    { new Guid("0abf991f-56ac-4452-8413-f9c551fd68be"), 18m }
                });

            migrationBuilder.InsertData(
                table: "Doors",
                columns: new[] { "Id", "DoorCount" },
                values: new object[,]
                {
                    { new Guid("1278cdec-d576-495f-a455-e17f5e422559"), "2/3" },
                    { new Guid("f787004d-8785-4ac7-9d05-b9de40adfc00"), "4/5" }
                });

            migrationBuilder.InsertData(
                table: "FrameTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("708d0b54-bd6b-4525-b6d5-b8509751db96"), "Universalas" },
                    { new Guid("8dd54ba0-77d9-477e-9359-c4e1e2b32e40"), "Sedanas" }
                });

            migrationBuilder.InsertData(
                table: "FuelTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("2a9fc8b9-89e6-41e6-b8bc-47eaf63c81ad"), "Benzinas" },
                    { new Guid("e1a42d40-43d2-4bb4-b306-bbaf8bcc15c8"), "Dyzelinas" }
                });

            migrationBuilder.InsertData(
                table: "Heights",
                columns: new[] { "Id", "TireHeight" },
                values: new object[,]
                {
                    { new Guid("6e61bca7-2aeb-4873-8d0c-dd7520b52e4b"), 205m },
                    { new Guid("f4d1026e-bc6e-4a19-9093-809335887abb"), 215m }
                });

            migrationBuilder.InsertData(
                table: "ManufacturerModels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("72119bd5-6b8d-4767-92c2-272ad72409bc"), "RS6" },
                    { new Guid("01ba5fae-1f42-4293-933c-990cf9c3a978"), "E60" }
                });

            migrationBuilder.InsertData(
                table: "SteeringWheelPos",
                columns: new[] { "Id", "Position" },
                values: new object[,]
                {
                    { new Guid("711c0c2b-b3b7-4f4f-9b3d-6cd4a7b03d02"), "Kairė" },
                    { new Guid("19e0895d-533b-4245-b8ef-3c426dcfba23"), "Dešinė" }
                });

            migrationBuilder.InsertData(
                table: "Transmissions",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("93f18b0d-fe91-46f3-b173-e2869a91ca89"), "Automatinė" },
                    { new Guid("743492d4-b11d-40c1-9e45-970a6ed824fa"), "Mechaninė" }
                });
        }
    }
}
