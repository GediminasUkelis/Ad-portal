using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class RoleFieldToUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6ee67200-5218-4889-b54f-2a22f69bb8db"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e6200641-2c57-4f62-aab6-ad4ca3c5c8b2"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("4ef44737-8d32-4952-bc8e-0c055b17a7a4"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("92c027ad-0895-4eb8-b9c5-15d9474a1a16"));

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: new Guid("2fffd170-8e08-4936-9f62-0a4ad0d80d75"));

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: new Guid("6f50a987-9407-4466-93b3-968e0af5cb11"));

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: new Guid("0f8163cd-12c1-4953-b058-3bfd2b72e0e8"));

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: new Guid("5319ecf4-54f1-4468-8880-412d1344a2df"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("2b3d5db1-991a-4aac-9cbe-cc5054e92fce"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("f9806ca6-381d-4b3f-8bb9-9789627a0797"));

            migrationBuilder.DeleteData(
                table: "Diameters",
                keyColumn: "Id",
                keyValue: new Guid("3913d28e-d14d-4dcd-b120-5165f43eb777"));

            migrationBuilder.DeleteData(
                table: "Diameters",
                keyColumn: "Id",
                keyValue: new Guid("8ce940fb-1e7e-4bdd-8ae3-99ec594694e9"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("3ad9de2e-8699-40fa-8564-62fe6a8eed22"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("773543ec-b705-452d-adcd-c21a795366a0"));

            migrationBuilder.DeleteData(
                table: "FrameTypes",
                keyColumn: "Id",
                keyValue: new Guid("53a56779-26fc-4035-8eb1-925f62d8a002"));

            migrationBuilder.DeleteData(
                table: "FrameTypes",
                keyColumn: "Id",
                keyValue: new Guid("c043b622-b880-4bb3-aa7c-32784738a925"));

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: new Guid("d826b520-5015-44bc-b243-6c036ffb6209"));

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: new Guid("f83b0a39-29b2-4939-86ea-d8d3f8d07d88"));

            migrationBuilder.DeleteData(
                table: "Heights",
                keyColumn: "Id",
                keyValue: new Guid("380311e8-bb47-42c5-ac95-e66e7ae97a39"));

            migrationBuilder.DeleteData(
                table: "Heights",
                keyColumn: "Id",
                keyValue: new Guid("3f66ddc9-56c7-402a-8af9-f39899bdf03a"));

            migrationBuilder.DeleteData(
                table: "ManufacturerModels",
                keyColumn: "Id",
                keyValue: new Guid("26a455fc-f04b-42e0-87df-c1e89d7cfd75"));

            migrationBuilder.DeleteData(
                table: "ManufacturerModels",
                keyColumn: "Id",
                keyValue: new Guid("7d12e494-870b-4400-9ff8-f932bea09714"));

            migrationBuilder.DeleteData(
                table: "SteeringWheelPos",
                keyColumn: "Id",
                keyValue: new Guid("5dfd4b38-42aa-4cb1-91d0-d26f0ff77ced"));

            migrationBuilder.DeleteData(
                table: "SteeringWheelPos",
                keyColumn: "Id",
                keyValue: new Guid("79b417ce-c90f-4987-8fd0-ce4debc57438"));

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: new Guid("06cf0d68-12c3-4b16-a58c-a68bb02f458d"));

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: new Guid("1671b8e1-0c82-4f1c-af6c-6f6ccef130ba"));

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Users",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Users");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("6ee67200-5218-4889-b54f-2a22f69bb8db"), "Automobilis" },
                    { new Guid("e6200641-2c57-4f62-aab6-ad4ca3c5c8b2"), "Motociklas" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("92c027ad-0895-4eb8-b9c5-15d9474a1a16"), "Balta" },
                    { new Guid("4ef44737-8d32-4952-bc8e-0c055b17a7a4"), "Juoda" }
                });

            migrationBuilder.InsertData(
                table: "Conditions",
                columns: new[] { "Id", "VehicCondition" },
                values: new object[,]
                {
                    { new Guid("2fffd170-8e08-4936-9f62-0a4ad0d80d75"), "Naudota" },
                    { new Guid("6f50a987-9407-4466-93b3-968e0af5cb11"), "Nauja" }
                });

            migrationBuilder.InsertData(
                table: "Coolings",
                columns: new[] { "Id", "CoolingType" },
                values: new object[,]
                {
                    { new Guid("0f8163cd-12c1-4953-b058-3bfd2b72e0e8"), "Oru" },
                    { new Guid("5319ecf4-54f1-4468-8880-412d1344a2df"), "Vandeniu" }
                });

            migrationBuilder.InsertData(
                table: "Defects",
                columns: new[] { "Id", "Defect" },
                values: new object[,]
                {
                    { new Guid("f9806ca6-381d-4b3f-8bb9-9789627a0797"), "Be defetkų" },
                    { new Guid("2b3d5db1-991a-4aac-9cbe-cc5054e92fce"), "Degęs" }
                });

            migrationBuilder.InsertData(
                table: "Diameters",
                columns: new[] { "Id", "TireDiameter" },
                values: new object[,]
                {
                    { new Guid("3913d28e-d14d-4dcd-b120-5165f43eb777"), 17m },
                    { new Guid("8ce940fb-1e7e-4bdd-8ae3-99ec594694e9"), 18m }
                });

            migrationBuilder.InsertData(
                table: "Doors",
                columns: new[] { "Id", "DoorCount" },
                values: new object[,]
                {
                    { new Guid("773543ec-b705-452d-adcd-c21a795366a0"), "2/3" },
                    { new Guid("3ad9de2e-8699-40fa-8564-62fe6a8eed22"), "4/5" }
                });

            migrationBuilder.InsertData(
                table: "FrameTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("c043b622-b880-4bb3-aa7c-32784738a925"), "Universalas" },
                    { new Guid("53a56779-26fc-4035-8eb1-925f62d8a002"), "Sedanas" }
                });

            migrationBuilder.InsertData(
                table: "FuelTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("f83b0a39-29b2-4939-86ea-d8d3f8d07d88"), "Benzinas" },
                    { new Guid("d826b520-5015-44bc-b243-6c036ffb6209"), "Dyzelinas" }
                });

            migrationBuilder.InsertData(
                table: "Heights",
                columns: new[] { "Id", "TireHeight" },
                values: new object[,]
                {
                    { new Guid("3f66ddc9-56c7-402a-8af9-f39899bdf03a"), 205m },
                    { new Guid("380311e8-bb47-42c5-ac95-e66e7ae97a39"), 215m }
                });

            migrationBuilder.InsertData(
                table: "ManufacturerModels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("26a455fc-f04b-42e0-87df-c1e89d7cfd75"), "RS6" },
                    { new Guid("7d12e494-870b-4400-9ff8-f932bea09714"), "E60" }
                });

            migrationBuilder.InsertData(
                table: "SteeringWheelPos",
                columns: new[] { "Id", "Position" },
                values: new object[,]
                {
                    { new Guid("79b417ce-c90f-4987-8fd0-ce4debc57438"), "Kairė" },
                    { new Guid("5dfd4b38-42aa-4cb1-91d0-d26f0ff77ced"), "Dešinė" }
                });

            migrationBuilder.InsertData(
                table: "Transmissions",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("06cf0d68-12c3-4b16-a58c-a68bb02f458d"), "Automatinė" },
                    { new Guid("1671b8e1-0c82-4f1c-af6c-6f6ccef130ba"), "Mechaninė" }
                });
        }
    }
}
