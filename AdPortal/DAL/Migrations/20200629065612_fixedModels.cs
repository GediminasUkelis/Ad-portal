using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class fixedModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarFeatures");

            migrationBuilder.DropTable(
                name: "MotorbikeFeatures");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("00d6e706-796a-4f31-b67f-268a54ed6214"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("37cb6c15-d2a8-4014-8e32-714960d94a98"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("000c8e1a-634e-417a-93b5-20f1988f38db"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("a8b1912f-fd7a-4f0a-854b-826647b7b751"));

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: new Guid("4accde61-fa49-4b36-92c6-5da804871157"));

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: new Guid("64cc1fe3-828c-440b-8bf0-da5b724dfeea"));

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: new Guid("9300e26c-33bf-4916-87a4-936cb6854220"));

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: new Guid("ae8db698-6a0d-488e-b4e0-02fceac72488"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("111ce923-5ff8-4f90-8327-4b3af451505a"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("5abdaced-5867-44ec-a519-18a6335481ba"));

            migrationBuilder.DeleteData(
                table: "Diameters",
                keyColumn: "Id",
                keyValue: new Guid("0ac83b71-2d70-4a3b-80e3-a49ba873bf69"));

            migrationBuilder.DeleteData(
                table: "Diameters",
                keyColumn: "Id",
                keyValue: new Guid("3f9f8c27-184d-412e-b467-9e2aebe4f1c7"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("7254b27a-b186-431c-a05a-f99527636d5b"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("cb4652ff-ddf6-4f5f-b692-2d2d1d04b241"));

            migrationBuilder.DeleteData(
                table: "FrameTypes",
                keyColumn: "Id",
                keyValue: new Guid("962419fd-6cc1-4800-b7d2-6467fc86b1af"));

            migrationBuilder.DeleteData(
                table: "FrameTypes",
                keyColumn: "Id",
                keyValue: new Guid("db571b79-ff10-4b06-a801-84300c7e3d89"));

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: new Guid("813e7104-a375-494d-ad23-d24597a99235"));

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: new Guid("9209291d-fce2-451f-84db-c6bea335d611"));

            migrationBuilder.DeleteData(
                table: "Heights",
                keyColumn: "Id",
                keyValue: new Guid("af48e64f-92da-456c-a2e6-15c656de06e3"));

            migrationBuilder.DeleteData(
                table: "Heights",
                keyColumn: "Id",
                keyValue: new Guid("c49fe6e3-1ce1-4ac4-ac4e-138d00c0b374"));

            migrationBuilder.DeleteData(
                table: "SteeringWheelPos",
                keyColumn: "Id",
                keyValue: new Guid("52e5b297-a282-488f-b210-f1608d787b27"));

            migrationBuilder.DeleteData(
                table: "SteeringWheelPos",
                keyColumn: "Id",
                keyValue: new Guid("a36ec75d-8854-4b6a-8ab9-f3dfeebc8954"));

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: new Guid("141de44f-1259-443f-9f09-0223925e4e63"));

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: new Guid("a37485b2-1228-4389-b97d-e2ce95fdb0e8"));

            migrationBuilder.AddColumn<Guid>(
                name: "ManufacturerModelId",
                table: "Cars",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("07c9f122-9ed4-4817-baf0-c96e86c00fba"), new DateTime(2020, 6, 29, 9, 56, 11, 686, DateTimeKind.Local).AddTicks(6815), "Automobilis" },
                    { new Guid("11f0d61a-389a-404c-99da-945455174517"), new DateTime(2020, 6, 29, 9, 56, 11, 686, DateTimeKind.Local).AddTicks(7428), "Motociklas" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "CreatedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("1aee93b0-52d4-4e8d-99ff-a3ef50f37786"), new DateTime(2020, 6, 29, 9, 56, 11, 688, DateTimeKind.Local).AddTicks(643), "Balta" },
                    { new Guid("6ee2d1c4-2644-4c0c-93bf-e987e375665e"), new DateTime(2020, 6, 29, 9, 56, 11, 688, DateTimeKind.Local).AddTicks(1176), "Juoda" }
                });

            migrationBuilder.InsertData(
                table: "Conditions",
                columns: new[] { "Id", "CreatedOn", "VehicCondition" },
                values: new object[,]
                {
                    { new Guid("3b2e5af9-2577-4716-ac85-45870748bb09"), new DateTime(2020, 6, 29, 9, 56, 11, 688, DateTimeKind.Local).AddTicks(1934), "Naudota" },
                    { new Guid("35cde63b-fd75-46b7-9166-7d886e593c61"), new DateTime(2020, 6, 29, 9, 56, 11, 688, DateTimeKind.Local).AddTicks(2420), "Nauja" }
                });

            migrationBuilder.InsertData(
                table: "Coolings",
                columns: new[] { "Id", "CoolingType", "CreatedOn" },
                values: new object[,]
                {
                    { new Guid("3a76f8f9-39e9-48d4-9a4d-aa12cb6d7446"), "Oru", new DateTime(2020, 6, 29, 9, 56, 11, 688, DateTimeKind.Local).AddTicks(3069) },
                    { new Guid("a2647fe7-0323-4909-a2b2-5f057a404368"), "Vandeniu", new DateTime(2020, 6, 29, 9, 56, 11, 688, DateTimeKind.Local).AddTicks(3530) }
                });

            migrationBuilder.InsertData(
                table: "Defects",
                columns: new[] { "Id", "CreatedOn", "Defect" },
                values: new object[,]
                {
                    { new Guid("3ed762df-f262-4dfc-8451-93f3c751d6b8"), new DateTime(2020, 6, 29, 9, 56, 11, 688, DateTimeKind.Local).AddTicks(4147), "Be defetkų" },
                    { new Guid("d604d43a-41cd-46a8-bba8-ee9277ac8bad"), new DateTime(2020, 6, 29, 9, 56, 11, 688, DateTimeKind.Local).AddTicks(4598), "Degęs" }
                });

            migrationBuilder.InsertData(
                table: "Diameters",
                columns: new[] { "Id", "CreatedOn", "TireDiameter" },
                values: new object[,]
                {
                    { new Guid("aba3cd9a-8fc2-48d6-9b11-aa64a3d3f323"), new DateTime(2020, 6, 29, 9, 56, 11, 688, DateTimeKind.Local).AddTicks(5766), 18m },
                    { new Guid("f6efea31-ec9b-4996-a518-3d5f0e3366cb"), new DateTime(2020, 6, 29, 9, 56, 11, 688, DateTimeKind.Local).AddTicks(5208), 17m }
                });

            migrationBuilder.InsertData(
                table: "Doors",
                columns: new[] { "Id", "CreatedOn", "DoorCount" },
                values: new object[,]
                {
                    { new Guid("168071b7-2ae9-41a4-bd4e-3a01de3c8e86"), new DateTime(2020, 6, 29, 9, 56, 11, 688, DateTimeKind.Local).AddTicks(6380), "4/5" },
                    { new Guid("f9622ec0-d8d8-42d4-aa00-96eea4cb5b0c"), new DateTime(2020, 6, 29, 9, 56, 11, 688, DateTimeKind.Local).AddTicks(6837), "2/3" }
                });

            migrationBuilder.InsertData(
                table: "FrameTypes",
                columns: new[] { "Id", "CreatedOn", "Type" },
                values: new object[,]
                {
                    { new Guid("5bbcb97c-bc96-4307-b2c4-4969baad050e"), new DateTime(2020, 6, 29, 9, 56, 11, 688, DateTimeKind.Local).AddTicks(7441), "Universalas" },
                    { new Guid("7e9530be-adef-47f7-a51c-b74f3c984738"), new DateTime(2020, 6, 29, 9, 56, 11, 688, DateTimeKind.Local).AddTicks(7881), "Sedanas" }
                });

            migrationBuilder.InsertData(
                table: "FuelTypes",
                columns: new[] { "Id", "CreatedOn", "Type" },
                values: new object[,]
                {
                    { new Guid("b7264173-e312-4ffe-8b2f-d25b4381e28c"), new DateTime(2020, 6, 29, 9, 56, 11, 688, DateTimeKind.Local).AddTicks(8502), "Benzinas" },
                    { new Guid("969500b9-10a6-4aea-89ac-e9e94e952dd6"), new DateTime(2020, 6, 29, 9, 56, 11, 688, DateTimeKind.Local).AddTicks(8942), "Dyzelinas" }
                });

            migrationBuilder.InsertData(
                table: "Heights",
                columns: new[] { "Id", "CreatedOn", "TireHeight" },
                values: new object[,]
                {
                    { new Guid("2a053391-fb74-40af-9c6d-e3f267f7f78c"), new DateTime(2020, 6, 29, 9, 56, 11, 688, DateTimeKind.Local).AddTicks(9526), 205m },
                    { new Guid("af25eaa6-59cf-4b79-907c-5888581859c2"), new DateTime(2020, 6, 29, 9, 56, 11, 689, DateTimeKind.Local).AddTicks(41), 215m }
                });

            migrationBuilder.InsertData(
                table: "SteeringWheelPos",
                columns: new[] { "Id", "CreatedOn", "Position" },
                values: new object[,]
                {
                    { new Guid("3d43717f-73ac-4b00-972d-06c54ecdba4e"), new DateTime(2020, 6, 29, 9, 56, 11, 689, DateTimeKind.Local).AddTicks(650), "Kairė" },
                    { new Guid("ae426667-da14-4195-85dd-25d3234fb7db"), new DateTime(2020, 6, 29, 9, 56, 11, 689, DateTimeKind.Local).AddTicks(1097), "Dešinė" }
                });

            migrationBuilder.InsertData(
                table: "Transmissions",
                columns: new[] { "Id", "CreatedOn", "Type" },
                values: new object[,]
                {
                    { new Guid("00333bb9-afb1-42e3-a19c-ff3634474fda"), new DateTime(2020, 6, 29, 9, 56, 11, 689, DateTimeKind.Local).AddTicks(1692), "Automatinė" },
                    { new Guid("d47d6670-2577-48d7-89e0-1dd0e92d5fe4"), new DateTime(2020, 6, 29, 9, 56, 11, 689, DateTimeKind.Local).AddTicks(2289), "Mechaninė" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ManufacturerModelId",
                table: "Cars",
                column: "ManufacturerModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_ManufacturerModels_ManufacturerModelId",
                table: "Cars",
                column: "ManufacturerModelId",
                principalTable: "ManufacturerModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_ManufacturerModels_ManufacturerModelId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_ManufacturerModelId",
                table: "Cars");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("07c9f122-9ed4-4817-baf0-c96e86c00fba"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("11f0d61a-389a-404c-99da-945455174517"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("1aee93b0-52d4-4e8d-99ff-a3ef50f37786"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("6ee2d1c4-2644-4c0c-93bf-e987e375665e"));

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: new Guid("35cde63b-fd75-46b7-9166-7d886e593c61"));

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: new Guid("3b2e5af9-2577-4716-ac85-45870748bb09"));

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: new Guid("3a76f8f9-39e9-48d4-9a4d-aa12cb6d7446"));

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: new Guid("a2647fe7-0323-4909-a2b2-5f057a404368"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("3ed762df-f262-4dfc-8451-93f3c751d6b8"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("d604d43a-41cd-46a8-bba8-ee9277ac8bad"));

            migrationBuilder.DeleteData(
                table: "Diameters",
                keyColumn: "Id",
                keyValue: new Guid("aba3cd9a-8fc2-48d6-9b11-aa64a3d3f323"));

            migrationBuilder.DeleteData(
                table: "Diameters",
                keyColumn: "Id",
                keyValue: new Guid("f6efea31-ec9b-4996-a518-3d5f0e3366cb"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("168071b7-2ae9-41a4-bd4e-3a01de3c8e86"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("f9622ec0-d8d8-42d4-aa00-96eea4cb5b0c"));

            migrationBuilder.DeleteData(
                table: "FrameTypes",
                keyColumn: "Id",
                keyValue: new Guid("5bbcb97c-bc96-4307-b2c4-4969baad050e"));

            migrationBuilder.DeleteData(
                table: "FrameTypes",
                keyColumn: "Id",
                keyValue: new Guid("7e9530be-adef-47f7-a51c-b74f3c984738"));

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: new Guid("969500b9-10a6-4aea-89ac-e9e94e952dd6"));

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: new Guid("b7264173-e312-4ffe-8b2f-d25b4381e28c"));

            migrationBuilder.DeleteData(
                table: "Heights",
                keyColumn: "Id",
                keyValue: new Guid("2a053391-fb74-40af-9c6d-e3f267f7f78c"));

            migrationBuilder.DeleteData(
                table: "Heights",
                keyColumn: "Id",
                keyValue: new Guid("af25eaa6-59cf-4b79-907c-5888581859c2"));

            migrationBuilder.DeleteData(
                table: "SteeringWheelPos",
                keyColumn: "Id",
                keyValue: new Guid("3d43717f-73ac-4b00-972d-06c54ecdba4e"));

            migrationBuilder.DeleteData(
                table: "SteeringWheelPos",
                keyColumn: "Id",
                keyValue: new Guid("ae426667-da14-4195-85dd-25d3234fb7db"));

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: new Guid("00333bb9-afb1-42e3-a19c-ff3634474fda"));

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: new Guid("d47d6670-2577-48d7-89e0-1dd0e92d5fe4"));

            migrationBuilder.DropColumn(
                name: "ManufacturerModelId",
                table: "Cars");

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarFeatures",
                columns: table => new
                {
                    CarId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FeatureId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarFeatures", x => new { x.CarId, x.FeatureId });
                    table.ForeignKey(
                        name: "FK_CarFeatures_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarFeatures_Features_FeatureId",
                        column: x => x.FeatureId,
                        principalTable: "Features",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MotorbikeFeatures",
                columns: table => new
                {
                    MotorbikeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FeatureId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotorbikeFeatures", x => new { x.MotorbikeId, x.FeatureId });
                    table.ForeignKey(
                        name: "FK_MotorbikeFeatures_Features_FeatureId",
                        column: x => x.FeatureId,
                        principalTable: "Features",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MotorbikeFeatures_Motorbikes_MotorbikeId",
                        column: x => x.MotorbikeId,
                        principalTable: "Motorbikes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("37cb6c15-d2a8-4014-8e32-714960d94a98"), new DateTime(2020, 6, 27, 13, 56, 35, 538, DateTimeKind.Local).AddTicks(871), "Automobilis" },
                    { new Guid("00d6e706-796a-4f31-b67f-268a54ed6214"), new DateTime(2020, 6, 27, 13, 56, 35, 538, DateTimeKind.Local).AddTicks(1825), "Motociklas" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "CreatedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("a8b1912f-fd7a-4f0a-854b-826647b7b751"), new DateTime(2020, 6, 27, 13, 56, 35, 539, DateTimeKind.Local).AddTicks(9059), "Balta" },
                    { new Guid("000c8e1a-634e-417a-93b5-20f1988f38db"), new DateTime(2020, 6, 27, 13, 56, 35, 539, DateTimeKind.Local).AddTicks(9921), "Juoda" }
                });

            migrationBuilder.InsertData(
                table: "Conditions",
                columns: new[] { "Id", "CreatedOn", "VehicCondition" },
                values: new object[,]
                {
                    { new Guid("4accde61-fa49-4b36-92c6-5da804871157"), new DateTime(2020, 6, 27, 13, 56, 35, 540, DateTimeKind.Local).AddTicks(1063), "Naudota" },
                    { new Guid("64cc1fe3-828c-440b-8bf0-da5b724dfeea"), new DateTime(2020, 6, 27, 13, 56, 35, 540, DateTimeKind.Local).AddTicks(1887), "Nauja" }
                });

            migrationBuilder.InsertData(
                table: "Coolings",
                columns: new[] { "Id", "CoolingType", "CreatedOn" },
                values: new object[,]
                {
                    { new Guid("ae8db698-6a0d-488e-b4e0-02fceac72488"), "Oru", new DateTime(2020, 6, 27, 13, 56, 35, 540, DateTimeKind.Local).AddTicks(3020) },
                    { new Guid("9300e26c-33bf-4916-87a4-936cb6854220"), "Vandeniu", new DateTime(2020, 6, 27, 13, 56, 35, 540, DateTimeKind.Local).AddTicks(3836) }
                });

            migrationBuilder.InsertData(
                table: "Defects",
                columns: new[] { "Id", "CreatedOn", "Defect" },
                values: new object[,]
                {
                    { new Guid("111ce923-5ff8-4f90-8327-4b3af451505a"), new DateTime(2020, 6, 27, 13, 56, 35, 540, DateTimeKind.Local).AddTicks(4930), "Be defetkų" },
                    { new Guid("5abdaced-5867-44ec-a519-18a6335481ba"), new DateTime(2020, 6, 27, 13, 56, 35, 540, DateTimeKind.Local).AddTicks(5724), "Degęs" }
                });

            migrationBuilder.InsertData(
                table: "Diameters",
                columns: new[] { "Id", "CreatedOn", "TireDiameter" },
                values: new object[,]
                {
                    { new Guid("0ac83b71-2d70-4a3b-80e3-a49ba873bf69"), new DateTime(2020, 6, 27, 13, 56, 35, 540, DateTimeKind.Local).AddTicks(7767), 18m },
                    { new Guid("3f9f8c27-184d-412e-b467-9e2aebe4f1c7"), new DateTime(2020, 6, 27, 13, 56, 35, 540, DateTimeKind.Local).AddTicks(6828), 17m }
                });

            migrationBuilder.InsertData(
                table: "Doors",
                columns: new[] { "Id", "CreatedOn", "DoorCount" },
                values: new object[,]
                {
                    { new Guid("cb4652ff-ddf6-4f5f-b692-2d2d1d04b241"), new DateTime(2020, 6, 27, 13, 56, 35, 540, DateTimeKind.Local).AddTicks(8846), "4/5" },
                    { new Guid("7254b27a-b186-431c-a05a-f99527636d5b"), new DateTime(2020, 6, 27, 13, 56, 35, 540, DateTimeKind.Local).AddTicks(9632), "2/3" }
                });

            migrationBuilder.InsertData(
                table: "FrameTypes",
                columns: new[] { "Id", "CreatedOn", "Type" },
                values: new object[,]
                {
                    { new Guid("962419fd-6cc1-4800-b7d2-6467fc86b1af"), new DateTime(2020, 6, 27, 13, 56, 35, 541, DateTimeKind.Local).AddTicks(710), "Universalas" },
                    { new Guid("db571b79-ff10-4b06-a801-84300c7e3d89"), new DateTime(2020, 6, 27, 13, 56, 35, 541, DateTimeKind.Local).AddTicks(1490), "Sedanas" }
                });

            migrationBuilder.InsertData(
                table: "FuelTypes",
                columns: new[] { "Id", "CreatedOn", "Type" },
                values: new object[,]
                {
                    { new Guid("9209291d-fce2-451f-84db-c6bea335d611"), new DateTime(2020, 6, 27, 13, 56, 35, 541, DateTimeKind.Local).AddTicks(2548), "Benzinas" },
                    { new Guid("813e7104-a375-494d-ad23-d24597a99235"), new DateTime(2020, 6, 27, 13, 56, 35, 541, DateTimeKind.Local).AddTicks(3346), "Dyzelinas" }
                });

            migrationBuilder.InsertData(
                table: "Heights",
                columns: new[] { "Id", "CreatedOn", "TireHeight" },
                values: new object[,]
                {
                    { new Guid("af48e64f-92da-456c-a2e6-15c656de06e3"), new DateTime(2020, 6, 27, 13, 56, 35, 541, DateTimeKind.Local).AddTicks(4490), 205m },
                    { new Guid("c49fe6e3-1ce1-4ac4-ac4e-138d00c0b374"), new DateTime(2020, 6, 27, 13, 56, 35, 541, DateTimeKind.Local).AddTicks(5376), 215m }
                });

            migrationBuilder.InsertData(
                table: "SteeringWheelPos",
                columns: new[] { "Id", "CreatedOn", "Position" },
                values: new object[,]
                {
                    { new Guid("a36ec75d-8854-4b6a-8ab9-f3dfeebc8954"), new DateTime(2020, 6, 27, 13, 56, 35, 541, DateTimeKind.Local).AddTicks(6428), "Kairė" },
                    { new Guid("52e5b297-a282-488f-b210-f1608d787b27"), new DateTime(2020, 6, 27, 13, 56, 35, 541, DateTimeKind.Local).AddTicks(7198), "Dešinė" }
                });

            migrationBuilder.InsertData(
                table: "Transmissions",
                columns: new[] { "Id", "CreatedOn", "Type" },
                values: new object[,]
                {
                    { new Guid("a37485b2-1228-4389-b97d-e2ce95fdb0e8"), new DateTime(2020, 6, 27, 13, 56, 35, 541, DateTimeKind.Local).AddTicks(8238), "Automatinė" },
                    { new Guid("141de44f-1259-443f-9f09-0223925e4e63"), new DateTime(2020, 6, 27, 13, 56, 35, 541, DateTimeKind.Local).AddTicks(8997), "Mechaninė" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarFeatures_FeatureId",
                table: "CarFeatures",
                column: "FeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_MotorbikeFeatures_FeatureId",
                table: "MotorbikeFeatures",
                column: "FeatureId");
        }
    }
}
