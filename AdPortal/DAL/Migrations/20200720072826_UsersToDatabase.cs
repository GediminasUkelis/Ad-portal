using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class UsersToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("824eaa93-dc1b-46b5-beaa-cba572ae685c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f00ed0a1-228d-4386-b782-fb0319b520d7"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("91427245-8e04-4002-818b-5b0c743a78f3"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("9357bfed-0658-49ab-9867-3731256bab7f"));

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: new Guid("041370ca-2a04-4729-9738-629cc758b8ef"));

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: new Guid("132de1f8-87d6-48aa-8c8a-ef6c94d2ce39"));

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: new Guid("6305e236-c730-444f-a8b6-dd6e4a217e11"));

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: new Guid("ad2915d7-7dd0-4625-b36f-993e02a37120"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("1c01774a-a8b6-40c3-aa4c-338e10c6da22"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("ac8b537c-6c5c-4b41-87cb-637374e05d44"));

            migrationBuilder.DeleteData(
                table: "Diameters",
                keyColumn: "Id",
                keyValue: new Guid("0ed21dba-16e6-48da-b339-3f14d381b08d"));

            migrationBuilder.DeleteData(
                table: "Diameters",
                keyColumn: "Id",
                keyValue: new Guid("59f9183d-06ae-4079-959c-6f51aa629276"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("666f969f-c5bf-4b55-b083-9258476c647c"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("c92a06cb-ab30-4b60-8f0a-4f8413612033"));

            migrationBuilder.DeleteData(
                table: "FrameTypes",
                keyColumn: "Id",
                keyValue: new Guid("65755425-7185-4a9f-beec-d3ce050c0b45"));

            migrationBuilder.DeleteData(
                table: "FrameTypes",
                keyColumn: "Id",
                keyValue: new Guid("fc76f8bd-fac6-4c78-bd4d-8c2cb663c9d4"));

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: new Guid("b093661f-ec50-44b2-9097-08381f9fd44c"));

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: new Guid("b5f33837-6a4a-4a24-a7bb-e26bda91e42f"));

            migrationBuilder.DeleteData(
                table: "Heights",
                keyColumn: "Id",
                keyValue: new Guid("4f94f2f8-014b-48db-b73f-b4a836441b51"));

            migrationBuilder.DeleteData(
                table: "Heights",
                keyColumn: "Id",
                keyValue: new Guid("eb01720b-12c2-4f39-95e4-c43a2be14ecb"));

            migrationBuilder.DeleteData(
                table: "ManufacturerModels",
                keyColumn: "Id",
                keyValue: new Guid("60bb4f06-5ac9-49d1-aa83-4bada54b9214"));

            migrationBuilder.DeleteData(
                table: "ManufacturerModels",
                keyColumn: "Id",
                keyValue: new Guid("9eba9262-944b-41e2-96b9-03f2f3e562f3"));

            migrationBuilder.DeleteData(
                table: "SteeringWheelPos",
                keyColumn: "Id",
                keyValue: new Guid("12d2a2e4-dfeb-4c72-896b-0e40ffc0f243"));

            migrationBuilder.DeleteData(
                table: "SteeringWheelPos",
                keyColumn: "Id",
                keyValue: new Guid("3b1a061a-bc87-4df9-8ef1-c558650fb0ec"));

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: new Guid("774fc6ad-66ee-47dc-87b4-04a23d4e9af4"));

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: new Guid("92d450a4-09b9-4b3e-87cd-67f5956b6590"));

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Username = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("824eaa93-dc1b-46b5-beaa-cba572ae685c"), "Automobilis" },
                    { new Guid("f00ed0a1-228d-4386-b782-fb0319b520d7"), "Motociklas" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("9357bfed-0658-49ab-9867-3731256bab7f"), "Balta" },
                    { new Guid("91427245-8e04-4002-818b-5b0c743a78f3"), "Juoda" }
                });

            migrationBuilder.InsertData(
                table: "Conditions",
                columns: new[] { "Id", "VehicCondition" },
                values: new object[,]
                {
                    { new Guid("132de1f8-87d6-48aa-8c8a-ef6c94d2ce39"), "Naudota" },
                    { new Guid("041370ca-2a04-4729-9738-629cc758b8ef"), "Nauja" }
                });

            migrationBuilder.InsertData(
                table: "Coolings",
                columns: new[] { "Id", "CoolingType" },
                values: new object[,]
                {
                    { new Guid("6305e236-c730-444f-a8b6-dd6e4a217e11"), "Oru" },
                    { new Guid("ad2915d7-7dd0-4625-b36f-993e02a37120"), "Vandeniu" }
                });

            migrationBuilder.InsertData(
                table: "Defects",
                columns: new[] { "Id", "Defect" },
                values: new object[,]
                {
                    { new Guid("1c01774a-a8b6-40c3-aa4c-338e10c6da22"), "Be defetkų" },
                    { new Guid("ac8b537c-6c5c-4b41-87cb-637374e05d44"), "Degęs" }
                });

            migrationBuilder.InsertData(
                table: "Diameters",
                columns: new[] { "Id", "TireDiameter" },
                values: new object[,]
                {
                    { new Guid("0ed21dba-16e6-48da-b339-3f14d381b08d"), 17m },
                    { new Guid("59f9183d-06ae-4079-959c-6f51aa629276"), 18m }
                });

            migrationBuilder.InsertData(
                table: "Doors",
                columns: new[] { "Id", "DoorCount" },
                values: new object[,]
                {
                    { new Guid("666f969f-c5bf-4b55-b083-9258476c647c"), "2/3" },
                    { new Guid("c92a06cb-ab30-4b60-8f0a-4f8413612033"), "4/5" }
                });

            migrationBuilder.InsertData(
                table: "FrameTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("fc76f8bd-fac6-4c78-bd4d-8c2cb663c9d4"), "Universalas" },
                    { new Guid("65755425-7185-4a9f-beec-d3ce050c0b45"), "Sedanas" }
                });

            migrationBuilder.InsertData(
                table: "FuelTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("b093661f-ec50-44b2-9097-08381f9fd44c"), "Benzinas" },
                    { new Guid("b5f33837-6a4a-4a24-a7bb-e26bda91e42f"), "Dyzelinas" }
                });

            migrationBuilder.InsertData(
                table: "Heights",
                columns: new[] { "Id", "TireHeight" },
                values: new object[,]
                {
                    { new Guid("4f94f2f8-014b-48db-b73f-b4a836441b51"), 205m },
                    { new Guid("eb01720b-12c2-4f39-95e4-c43a2be14ecb"), 215m }
                });

            migrationBuilder.InsertData(
                table: "ManufacturerModels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("9eba9262-944b-41e2-96b9-03f2f3e562f3"), "RS6" },
                    { new Guid("60bb4f06-5ac9-49d1-aa83-4bada54b9214"), "E60" }
                });

            migrationBuilder.InsertData(
                table: "SteeringWheelPos",
                columns: new[] { "Id", "Position" },
                values: new object[,]
                {
                    { new Guid("12d2a2e4-dfeb-4c72-896b-0e40ffc0f243"), "Kairė" },
                    { new Guid("3b1a061a-bc87-4df9-8ef1-c558650fb0ec"), "Dešinė" }
                });

            migrationBuilder.InsertData(
                table: "Transmissions",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("92d450a4-09b9-4b3e-87cd-67f5956b6590"), "Automatinė" },
                    { new Guid("774fc6ad-66ee-47dc-87b4-04a23d4e9af4"), "Mechaninė" }
                });
        }
    }
}
