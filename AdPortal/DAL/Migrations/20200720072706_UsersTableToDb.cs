using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class UsersTableToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("70532b44-8670-4482-901d-30704eb6019d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bf3c1b95-d3fc-46fc-b515-bf954f9b36ee"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("5fb4051b-e9a0-483b-a411-97797a9a6035"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("df5ed3b2-066b-4ff2-b994-07875bb43f72"));

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: new Guid("7402a87c-c0b1-4753-9150-135d3324f688"));

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: new Guid("fb3f67d6-cb5f-4b23-a8f9-3c5a9bc9c29b"));

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: new Guid("2bbf0c2a-e41e-459a-b09e-10136daf8877"));

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: new Guid("e43fdcba-5511-44c7-839d-c3d36e5e9b1e"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("17df7aa2-18f6-4e81-8d24-a53a9931d270"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("563ae722-b1eb-47b2-96a8-5e60fec462d1"));

            migrationBuilder.DeleteData(
                table: "Diameters",
                keyColumn: "Id",
                keyValue: new Guid("207d3f8b-1e3f-4095-9f6b-24e242b45f1a"));

            migrationBuilder.DeleteData(
                table: "Diameters",
                keyColumn: "Id",
                keyValue: new Guid("be58a811-b442-4cd1-a57d-94a49983cb85"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("2d386750-0d6e-46f5-b780-7840fd066d92"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("3d693106-8da0-41e9-8660-761d0c3ca4a9"));

            migrationBuilder.DeleteData(
                table: "FrameTypes",
                keyColumn: "Id",
                keyValue: new Guid("2a625ece-c532-4532-8037-ce537c26c705"));

            migrationBuilder.DeleteData(
                table: "FrameTypes",
                keyColumn: "Id",
                keyValue: new Guid("ff93822b-b78a-41ee-84c3-adf7c09465c2"));

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: new Guid("0b9c8854-b5f3-4c0e-9017-50c0385d6695"));

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: new Guid("95a07031-6fc6-4d68-8b64-f6174fdeb863"));

            migrationBuilder.DeleteData(
                table: "Heights",
                keyColumn: "Id",
                keyValue: new Guid("bb3d8b5a-da15-4f8d-a4e9-2a940c18bdb3"));

            migrationBuilder.DeleteData(
                table: "Heights",
                keyColumn: "Id",
                keyValue: new Guid("f4d1145c-6671-4b91-8471-495ab9be6f89"));

            migrationBuilder.DeleteData(
                table: "ManufacturerModels",
                keyColumn: "Id",
                keyValue: new Guid("d834208c-39c9-4063-b1c0-d73ae625ba6b"));

            migrationBuilder.DeleteData(
                table: "ManufacturerModels",
                keyColumn: "Id",
                keyValue: new Guid("de31ecc7-2cf0-40e1-a618-2edb64d9924b"));

            migrationBuilder.DeleteData(
                table: "SteeringWheelPos",
                keyColumn: "Id",
                keyValue: new Guid("9349925a-99a8-4d1a-87db-e3299ee27d83"));

            migrationBuilder.DeleteData(
                table: "SteeringWheelPos",
                keyColumn: "Id",
                keyValue: new Guid("c9db4a18-119f-4216-baa2-6fa19d1496e4"));

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: new Guid("10680b85-e829-433b-90e1-26cea400c5a2"));

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: new Guid("7ddc1b3c-8f38-4c8c-b823-437af74e6fcf"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("70532b44-8670-4482-901d-30704eb6019d"), "Automobilis" },
                    { new Guid("bf3c1b95-d3fc-46fc-b515-bf954f9b36ee"), "Motociklas" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("df5ed3b2-066b-4ff2-b994-07875bb43f72"), "Balta" },
                    { new Guid("5fb4051b-e9a0-483b-a411-97797a9a6035"), "Juoda" }
                });

            migrationBuilder.InsertData(
                table: "Conditions",
                columns: new[] { "Id", "VehicCondition" },
                values: new object[,]
                {
                    { new Guid("7402a87c-c0b1-4753-9150-135d3324f688"), "Naudota" },
                    { new Guid("fb3f67d6-cb5f-4b23-a8f9-3c5a9bc9c29b"), "Nauja" }
                });

            migrationBuilder.InsertData(
                table: "Coolings",
                columns: new[] { "Id", "CoolingType" },
                values: new object[,]
                {
                    { new Guid("e43fdcba-5511-44c7-839d-c3d36e5e9b1e"), "Oru" },
                    { new Guid("2bbf0c2a-e41e-459a-b09e-10136daf8877"), "Vandeniu" }
                });

            migrationBuilder.InsertData(
                table: "Defects",
                columns: new[] { "Id", "Defect" },
                values: new object[,]
                {
                    { new Guid("563ae722-b1eb-47b2-96a8-5e60fec462d1"), "Be defetkų" },
                    { new Guid("17df7aa2-18f6-4e81-8d24-a53a9931d270"), "Degęs" }
                });

            migrationBuilder.InsertData(
                table: "Diameters",
                columns: new[] { "Id", "TireDiameter" },
                values: new object[,]
                {
                    { new Guid("be58a811-b442-4cd1-a57d-94a49983cb85"), 17m },
                    { new Guid("207d3f8b-1e3f-4095-9f6b-24e242b45f1a"), 18m }
                });

            migrationBuilder.InsertData(
                table: "Doors",
                columns: new[] { "Id", "DoorCount" },
                values: new object[,]
                {
                    { new Guid("3d693106-8da0-41e9-8660-761d0c3ca4a9"), "2/3" },
                    { new Guid("2d386750-0d6e-46f5-b780-7840fd066d92"), "4/5" }
                });

            migrationBuilder.InsertData(
                table: "FrameTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("2a625ece-c532-4532-8037-ce537c26c705"), "Universalas" },
                    { new Guid("ff93822b-b78a-41ee-84c3-adf7c09465c2"), "Sedanas" }
                });

            migrationBuilder.InsertData(
                table: "FuelTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("95a07031-6fc6-4d68-8b64-f6174fdeb863"), "Benzinas" },
                    { new Guid("0b9c8854-b5f3-4c0e-9017-50c0385d6695"), "Dyzelinas" }
                });

            migrationBuilder.InsertData(
                table: "Heights",
                columns: new[] { "Id", "TireHeight" },
                values: new object[,]
                {
                    { new Guid("bb3d8b5a-da15-4f8d-a4e9-2a940c18bdb3"), 205m },
                    { new Guid("f4d1145c-6671-4b91-8471-495ab9be6f89"), 215m }
                });

            migrationBuilder.InsertData(
                table: "ManufacturerModels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("de31ecc7-2cf0-40e1-a618-2edb64d9924b"), "RS6" },
                    { new Guid("d834208c-39c9-4063-b1c0-d73ae625ba6b"), "E60" }
                });

            migrationBuilder.InsertData(
                table: "SteeringWheelPos",
                columns: new[] { "Id", "Position" },
                values: new object[,]
                {
                    { new Guid("c9db4a18-119f-4216-baa2-6fa19d1496e4"), "Kairė" },
                    { new Guid("9349925a-99a8-4d1a-87db-e3299ee27d83"), "Dešinė" }
                });

            migrationBuilder.InsertData(
                table: "Transmissions",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("10680b85-e829-433b-90e1-26cea400c5a2"), "Automatinė" },
                    { new Guid("7ddc1b3c-8f38-4c8c-b823-437af74e6fcf"), "Mechaninė" }
                });
        }
    }
}
