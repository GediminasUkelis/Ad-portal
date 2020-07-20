using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class AddSaltToUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1d8eb3e2-5a2a-4cc6-9e49-0de530a18aa8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b7b433ca-bcef-4e6b-843c-57691d2663c5"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("05a712a4-d682-4b2b-8db3-91874b4fda58"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("4614c6ba-ed02-4bd0-9534-c01e98182666"));

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: new Guid("2e8256d7-afe5-4161-812f-ef66e6f94997"));

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: new Guid("eaf5b012-fefc-4e40-8534-75809c211e33"));

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: new Guid("53812453-0de5-4b4c-985b-b161e557951d"));

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: new Guid("ebe33cde-2c25-433f-9200-5b3489e62bf1"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("c146f288-0085-49ca-a43d-15e4638b3d61"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("cb8acbd3-d09d-49c9-909e-27c399c7b30b"));

            migrationBuilder.DeleteData(
                table: "Diameters",
                keyColumn: "Id",
                keyValue: new Guid("08ee46f2-7b32-4b3a-a7f5-2a5e1c4ba733"));

            migrationBuilder.DeleteData(
                table: "Diameters",
                keyColumn: "Id",
                keyValue: new Guid("ce46390f-6477-4f30-9f95-ae211c31202e"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("040ff127-2655-490a-8d02-014b4da67f53"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("7d01dbf7-233f-435d-a6ef-73bf50c69aad"));

            migrationBuilder.DeleteData(
                table: "FrameTypes",
                keyColumn: "Id",
                keyValue: new Guid("0d23e388-418f-4b52-966e-796f903b6e7e"));

            migrationBuilder.DeleteData(
                table: "FrameTypes",
                keyColumn: "Id",
                keyValue: new Guid("42d814c5-b6e2-48be-beea-4affb2c28dc1"));

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: new Guid("7b5118a2-4e4a-4660-8b04-cc9e1bd04d62"));

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: new Guid("88a3f009-d21b-4c2c-a92e-19643b992015"));

            migrationBuilder.DeleteData(
                table: "Heights",
                keyColumn: "Id",
                keyValue: new Guid("2df9f80c-3207-47c4-ad7c-f078c9a8eec8"));

            migrationBuilder.DeleteData(
                table: "Heights",
                keyColumn: "Id",
                keyValue: new Guid("c7fac864-3670-4db6-90a1-f3deec955a90"));

            migrationBuilder.DeleteData(
                table: "ManufacturerModels",
                keyColumn: "Id",
                keyValue: new Guid("12fd3b39-7d20-47f8-b848-5af9fe224b20"));

            migrationBuilder.DeleteData(
                table: "ManufacturerModels",
                keyColumn: "Id",
                keyValue: new Guid("9e9dfa28-6410-4993-95db-486b993e3261"));

            migrationBuilder.DeleteData(
                table: "SteeringWheelPos",
                keyColumn: "Id",
                keyValue: new Guid("6bf12030-bd07-47ab-bbf9-53fb8b4c27be"));

            migrationBuilder.DeleteData(
                table: "SteeringWheelPos",
                keyColumn: "Id",
                keyValue: new Guid("7268e743-12c9-4a9d-b896-f781485f28c8"));

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: new Guid("288dbe82-41e5-4894-bd65-4226b020e084"));

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: new Guid("96a17649-7df1-4c4f-a7b4-c5199b13871f"));

            migrationBuilder.AddColumn<string>(
                name: "Salt",
                table: "Users",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Salt",
                table: "Users");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("b7b433ca-bcef-4e6b-843c-57691d2663c5"), "Automobilis" },
                    { new Guid("1d8eb3e2-5a2a-4cc6-9e49-0de530a18aa8"), "Motociklas" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("4614c6ba-ed02-4bd0-9534-c01e98182666"), "Balta" },
                    { new Guid("05a712a4-d682-4b2b-8db3-91874b4fda58"), "Juoda" }
                });

            migrationBuilder.InsertData(
                table: "Conditions",
                columns: new[] { "Id", "VehicCondition" },
                values: new object[,]
                {
                    { new Guid("2e8256d7-afe5-4161-812f-ef66e6f94997"), "Naudota" },
                    { new Guid("eaf5b012-fefc-4e40-8534-75809c211e33"), "Nauja" }
                });

            migrationBuilder.InsertData(
                table: "Coolings",
                columns: new[] { "Id", "CoolingType" },
                values: new object[,]
                {
                    { new Guid("ebe33cde-2c25-433f-9200-5b3489e62bf1"), "Oru" },
                    { new Guid("53812453-0de5-4b4c-985b-b161e557951d"), "Vandeniu" }
                });

            migrationBuilder.InsertData(
                table: "Defects",
                columns: new[] { "Id", "Defect" },
                values: new object[,]
                {
                    { new Guid("cb8acbd3-d09d-49c9-909e-27c399c7b30b"), "Be defetkų" },
                    { new Guid("c146f288-0085-49ca-a43d-15e4638b3d61"), "Degęs" }
                });

            migrationBuilder.InsertData(
                table: "Diameters",
                columns: new[] { "Id", "TireDiameter" },
                values: new object[,]
                {
                    { new Guid("08ee46f2-7b32-4b3a-a7f5-2a5e1c4ba733"), 17m },
                    { new Guid("ce46390f-6477-4f30-9f95-ae211c31202e"), 18m }
                });

            migrationBuilder.InsertData(
                table: "Doors",
                columns: new[] { "Id", "DoorCount" },
                values: new object[,]
                {
                    { new Guid("040ff127-2655-490a-8d02-014b4da67f53"), "2/3" },
                    { new Guid("7d01dbf7-233f-435d-a6ef-73bf50c69aad"), "4/5" }
                });

            migrationBuilder.InsertData(
                table: "FrameTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("42d814c5-b6e2-48be-beea-4affb2c28dc1"), "Universalas" },
                    { new Guid("0d23e388-418f-4b52-966e-796f903b6e7e"), "Sedanas" }
                });

            migrationBuilder.InsertData(
                table: "FuelTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("88a3f009-d21b-4c2c-a92e-19643b992015"), "Benzinas" },
                    { new Guid("7b5118a2-4e4a-4660-8b04-cc9e1bd04d62"), "Dyzelinas" }
                });

            migrationBuilder.InsertData(
                table: "Heights",
                columns: new[] { "Id", "TireHeight" },
                values: new object[,]
                {
                    { new Guid("2df9f80c-3207-47c4-ad7c-f078c9a8eec8"), 205m },
                    { new Guid("c7fac864-3670-4db6-90a1-f3deec955a90"), 215m }
                });

            migrationBuilder.InsertData(
                table: "ManufacturerModels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("12fd3b39-7d20-47f8-b848-5af9fe224b20"), "RS6" },
                    { new Guid("9e9dfa28-6410-4993-95db-486b993e3261"), "E60" }
                });

            migrationBuilder.InsertData(
                table: "SteeringWheelPos",
                columns: new[] { "Id", "Position" },
                values: new object[,]
                {
                    { new Guid("7268e743-12c9-4a9d-b896-f781485f28c8"), "Kairė" },
                    { new Guid("6bf12030-bd07-47ab-bbf9-53fb8b4c27be"), "Dešinė" }
                });

            migrationBuilder.InsertData(
                table: "Transmissions",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("96a17649-7df1-4c4f-a7b4-c5199b13871f"), "Automatinė" },
                    { new Guid("288dbe82-41e5-4894-bd65-4226b020e084"), "Mechaninė" }
                });
        }
    }
}
