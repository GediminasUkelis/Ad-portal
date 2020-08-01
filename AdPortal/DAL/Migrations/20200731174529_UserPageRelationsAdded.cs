using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class UserPageRelationsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Tires",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Motorbikes",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Cars",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("4d7a9ed6-e416-43f9-a7cc-1aa60564782c"), "Automobilis" },
                    { new Guid("9150fdef-12d1-4754-8df7-4d2086aa0778"), "Motociklas" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("262716c3-570c-4d8e-bf9f-aa7a538fb7cc"), "Balta" },
                    { new Guid("c669a814-e508-4920-88f3-dcdcbfc7fd84"), "Juoda" }
                });

            migrationBuilder.InsertData(
                table: "Conditions",
                columns: new[] { "Id", "VehicCondition" },
                values: new object[,]
                {
                    { new Guid("f6b33440-fa6f-458a-94d6-59737953be86"), "Naudota" },
                    { new Guid("f3235042-65b6-48bc-958b-c04d955bdbdb"), "Nauja" }
                });

            migrationBuilder.InsertData(
                table: "Coolings",
                columns: new[] { "Id", "CoolingType" },
                values: new object[,]
                {
                    { new Guid("4ec6d4a5-6a29-43e2-b160-1b32a0d6ee93"), "Oru" },
                    { new Guid("5145d471-31e8-44b8-9ae4-c32d1826c64b"), "Vandeniu" }
                });

            migrationBuilder.InsertData(
                table: "Defects",
                columns: new[] { "Id", "Defect" },
                values: new object[,]
                {
                    { new Guid("5ccbd8dd-3ca2-42aa-9e80-3e3bc4d09414"), "Be defetkų" },
                    { new Guid("147ef79f-dd86-42de-ab28-69258ebe5f29"), "Degęs" }
                });

            migrationBuilder.InsertData(
                table: "Diameters",
                columns: new[] { "Id", "TireDiameter" },
                values: new object[,]
                {
                    { new Guid("6c772385-bab9-4b4d-9902-d99a1ed7097f"), 17m },
                    { new Guid("4bedc2e1-3c49-4950-8698-2bf2f1181607"), 18m }
                });

            migrationBuilder.InsertData(
                table: "Doors",
                columns: new[] { "Id", "DoorCount" },
                values: new object[,]
                {
                    { new Guid("e141847d-24b8-4129-a1ad-23524813e769"), "2/3" },
                    { new Guid("bb4dce6a-d113-455f-8e85-6707dfc0f842"), "4/5" }
                });

            migrationBuilder.InsertData(
                table: "FrameTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("36139097-f98f-4bae-b4ab-5a2bbcddf633"), "Universalas" },
                    { new Guid("d4bb2439-94bb-46cf-9bca-526d555e0de4"), "Sedanas" }
                });

            migrationBuilder.InsertData(
                table: "FuelTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("1f96de24-f0ad-4612-aa6c-3e644117987c"), "Benzinas" },
                    { new Guid("f703c4dd-0844-4212-8b6d-ecf6274d9bd9"), "Dyzelinas" }
                });

            migrationBuilder.InsertData(
                table: "Heights",
                columns: new[] { "Id", "TireHeight" },
                values: new object[,]
                {
                    { new Guid("0a9e1b42-b528-4293-a3e0-5a8b55ef7f82"), 205m },
                    { new Guid("1bda2beb-86d4-415d-b6c3-8afd8565cecb"), 215m }
                });

            migrationBuilder.InsertData(
                table: "ManufacturerModels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("50438d50-964a-43c7-ab7f-a78c37bd5122"), "RS6" },
                    { new Guid("9b75fde8-122e-4057-bf1b-d05b3a1533e6"), "E60" }
                });

            migrationBuilder.InsertData(
                table: "SteeringWheelPos",
                columns: new[] { "Id", "Position" },
                values: new object[,]
                {
                    { new Guid("d17968d7-8b22-42b6-a3aa-f3dd7bce44ea"), "Kairė" },
                    { new Guid("a282628a-5d25-4260-8601-365865031cb6"), "Dešinė" }
                });

            migrationBuilder.InsertData(
                table: "Transmissions",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("ef273948-9993-40cf-8e17-f4ac6cbd6daf"), "Automatinė" },
                    { new Guid("70dc2658-2267-45eb-9a6e-68205175ac9e"), "Mechaninė" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tires_UserId",
                table: "Tires",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Motorbikes_UserId",
                table: "Motorbikes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_UserId",
                table: "Cars",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Users_UserId",
                table: "Cars",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Users_UserId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Motorbikes_Users_UserId",
                table: "Motorbikes");

            migrationBuilder.DropForeignKey(
                name: "FK_Tires_Users_UserId",
                table: "Tires");

            migrationBuilder.DropIndex(
                name: "IX_Tires_UserId",
                table: "Tires");

            migrationBuilder.DropIndex(
                name: "IX_Motorbikes_UserId",
                table: "Motorbikes");

            migrationBuilder.DropIndex(
                name: "IX_Cars_UserId",
                table: "Cars");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4d7a9ed6-e416-43f9-a7cc-1aa60564782c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9150fdef-12d1-4754-8df7-4d2086aa0778"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("262716c3-570c-4d8e-bf9f-aa7a538fb7cc"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("c669a814-e508-4920-88f3-dcdcbfc7fd84"));

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: new Guid("f3235042-65b6-48bc-958b-c04d955bdbdb"));

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: new Guid("f6b33440-fa6f-458a-94d6-59737953be86"));

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: new Guid("4ec6d4a5-6a29-43e2-b160-1b32a0d6ee93"));

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: new Guid("5145d471-31e8-44b8-9ae4-c32d1826c64b"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("147ef79f-dd86-42de-ab28-69258ebe5f29"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("5ccbd8dd-3ca2-42aa-9e80-3e3bc4d09414"));

            migrationBuilder.DeleteData(
                table: "Diameters",
                keyColumn: "Id",
                keyValue: new Guid("4bedc2e1-3c49-4950-8698-2bf2f1181607"));

            migrationBuilder.DeleteData(
                table: "Diameters",
                keyColumn: "Id",
                keyValue: new Guid("6c772385-bab9-4b4d-9902-d99a1ed7097f"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("bb4dce6a-d113-455f-8e85-6707dfc0f842"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("e141847d-24b8-4129-a1ad-23524813e769"));

            migrationBuilder.DeleteData(
                table: "FrameTypes",
                keyColumn: "Id",
                keyValue: new Guid("36139097-f98f-4bae-b4ab-5a2bbcddf633"));

            migrationBuilder.DeleteData(
                table: "FrameTypes",
                keyColumn: "Id",
                keyValue: new Guid("d4bb2439-94bb-46cf-9bca-526d555e0de4"));

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: new Guid("1f96de24-f0ad-4612-aa6c-3e644117987c"));

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: new Guid("f703c4dd-0844-4212-8b6d-ecf6274d9bd9"));

            migrationBuilder.DeleteData(
                table: "Heights",
                keyColumn: "Id",
                keyValue: new Guid("0a9e1b42-b528-4293-a3e0-5a8b55ef7f82"));

            migrationBuilder.DeleteData(
                table: "Heights",
                keyColumn: "Id",
                keyValue: new Guid("1bda2beb-86d4-415d-b6c3-8afd8565cecb"));

            migrationBuilder.DeleteData(
                table: "ManufacturerModels",
                keyColumn: "Id",
                keyValue: new Guid("50438d50-964a-43c7-ab7f-a78c37bd5122"));

            migrationBuilder.DeleteData(
                table: "ManufacturerModels",
                keyColumn: "Id",
                keyValue: new Guid("9b75fde8-122e-4057-bf1b-d05b3a1533e6"));

            migrationBuilder.DeleteData(
                table: "SteeringWheelPos",
                keyColumn: "Id",
                keyValue: new Guid("a282628a-5d25-4260-8601-365865031cb6"));

            migrationBuilder.DeleteData(
                table: "SteeringWheelPos",
                keyColumn: "Id",
                keyValue: new Guid("d17968d7-8b22-42b6-a3aa-f3dd7bce44ea"));

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: new Guid("70dc2658-2267-45eb-9a6e-68205175ac9e"));

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: new Guid("ef273948-9993-40cf-8e17-f4ac6cbd6daf"));

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Tires");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Motorbikes");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Cars");

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
        }
    }
}
