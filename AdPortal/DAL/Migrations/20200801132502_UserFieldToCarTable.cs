using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class UserFieldToCarTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
