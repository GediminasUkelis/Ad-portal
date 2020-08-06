using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class AdingImagesToOtherModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2a66039e-f447-4348-969d-5d09a735d5dc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a5556584-f587-4680-acd9-7ee6c5ddbca6"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("4af062a9-2439-4f28-b075-6634ac20bce8"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("4f0dbef2-b49c-4396-b3de-b9d4694cfa6b"));

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: new Guid("1dd774d1-097d-4bdc-ab83-43442f77b7f8"));

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: new Guid("e30056bc-1b6e-44f5-9de2-7255381430c8"));

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: new Guid("3d04b4af-bff0-443e-9f8f-271e7da967b8"));

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: new Guid("655bcc53-053d-43fc-bae1-035ad524901b"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("a6e612ba-b37c-4329-8c6e-d415ae9520e9"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("e041a12b-f267-4ab3-9a8d-0c6dd7d63118"));

            migrationBuilder.DeleteData(
                table: "Diameters",
                keyColumn: "Id",
                keyValue: new Guid("5c3d7b5b-f8e3-4eb6-9a2c-601aa44ef77c"));

            migrationBuilder.DeleteData(
                table: "Diameters",
                keyColumn: "Id",
                keyValue: new Guid("feb2f9bc-567a-4ebe-ab54-2d39dec5979f"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("1b3988c1-e392-45f3-bcf5-bdb1b59b85f8"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("fa7a0b4c-bc01-479a-8b3d-c137d67c0b29"));

            migrationBuilder.DeleteData(
                table: "FrameTypes",
                keyColumn: "Id",
                keyValue: new Guid("1fc67b35-c6b7-427f-aaf5-2d71ff1bdf1b"));

            migrationBuilder.DeleteData(
                table: "FrameTypes",
                keyColumn: "Id",
                keyValue: new Guid("aa1fc47f-1753-4ea5-a4d5-43c811586c83"));

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: new Guid("703cd7e6-65d7-4a47-9aef-07bae4b3465c"));

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: new Guid("e184a9c5-e2e9-4700-b847-47811f98a7c7"));

            migrationBuilder.DeleteData(
                table: "Heights",
                keyColumn: "Id",
                keyValue: new Guid("d9afc208-90ef-4b15-b085-2596b6444a7d"));

            migrationBuilder.DeleteData(
                table: "Heights",
                keyColumn: "Id",
                keyValue: new Guid("fb98e7ea-7d0f-47bc-bcef-420730ef9ad3"));

            migrationBuilder.DeleteData(
                table: "ManufacturerModels",
                keyColumn: "Id",
                keyValue: new Guid("61871236-0fd8-4b84-a34b-8e7d14309786"));

            migrationBuilder.DeleteData(
                table: "ManufacturerModels",
                keyColumn: "Id",
                keyValue: new Guid("7a5a818c-6106-4ac0-9a7e-c9450027291d"));

            migrationBuilder.DeleteData(
                table: "SteeringWheelPos",
                keyColumn: "Id",
                keyValue: new Guid("63108cc8-ab64-4aa3-9cc7-92f5e2187d26"));

            migrationBuilder.DeleteData(
                table: "SteeringWheelPos",
                keyColumn: "Id",
                keyValue: new Guid("a678f96e-a02f-4ba9-a30a-538baf703c67"));

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: new Guid("6edbb704-a7a3-4f69-8f0e-429727f50adc"));

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: new Guid("8dfc58e4-0d53-4e66-98b8-9117ebf76391"));

            migrationBuilder.CreateTable(
                name: "CarImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Path = table.Column<string>(nullable: true),
                    CarId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarImages_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MotorbikeImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Path = table.Column<string>(nullable: true),
                    MotorbikeId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotorbikeImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MotorbikeImages_Motorbikes_MotorbikeId",
                        column: x => x.MotorbikeId,
                        principalTable: "Motorbikes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TireImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Path = table.Column<string>(nullable: true),
                    TireId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TireImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TireImages_Tires_TireId",
                        column: x => x.TireId,
                        principalTable: "Tires",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("5498def1-1ca3-42c9-bfe1-64019412bc49"), "Automobilis" },
                    { new Guid("24f5190a-b8cd-494a-a750-a7ac2da0d7d1"), "Motociklas" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("14fcd99c-3593-40be-b132-5465c9edefaf"), "Balta" },
                    { new Guid("d88635dc-678d-4700-8340-83eaab0b7a84"), "Juoda" }
                });

            migrationBuilder.InsertData(
                table: "Conditions",
                columns: new[] { "Id", "VehicCondition" },
                values: new object[,]
                {
                    { new Guid("87d02b16-711e-408c-9c46-028deb30c505"), "Naudota" },
                    { new Guid("8c9aadf1-76d1-42c4-bf12-7f4203f6f348"), "Nauja" }
                });

            migrationBuilder.InsertData(
                table: "Coolings",
                columns: new[] { "Id", "CoolingType" },
                values: new object[,]
                {
                    { new Guid("15ffe8aa-2b9a-4106-a09b-5be4d1ff145d"), "Oru" },
                    { new Guid("4edb5c1b-f59a-4247-9edd-12825e8c9280"), "Vandeniu" }
                });

            migrationBuilder.InsertData(
                table: "Defects",
                columns: new[] { "Id", "Defect" },
                values: new object[,]
                {
                    { new Guid("46e32ac2-1470-4cbf-bccf-bcd30de9707b"), "Be defetkų" },
                    { new Guid("cb4c8b85-7ee8-4e27-8a0f-9e0854a5eace"), "Degęs" }
                });

            migrationBuilder.InsertData(
                table: "Diameters",
                columns: new[] { "Id", "TireDiameter" },
                values: new object[,]
                {
                    { new Guid("92d169fb-19b6-4725-902c-55512ea2a5b9"), 17m },
                    { new Guid("f4eddc26-d1bc-495e-a3a5-597d7b3c58dd"), 18m }
                });

            migrationBuilder.InsertData(
                table: "Doors",
                columns: new[] { "Id", "DoorCount" },
                values: new object[,]
                {
                    { new Guid("ba9dfc3a-4478-4536-95b1-e5135c2d3060"), "2/3" },
                    { new Guid("93cb3b17-8b07-4a8f-9cd4-eafbfd23bc21"), "4/5" }
                });

            migrationBuilder.InsertData(
                table: "FrameTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("5d53e8e3-3dab-4e94-ab7a-57c1cee47c8f"), "Universalas" },
                    { new Guid("3f78b537-7d01-4bde-bfdc-81d62bfcfc68"), "Sedanas" }
                });

            migrationBuilder.InsertData(
                table: "FuelTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("8700eacf-bb3c-42f4-9c76-40708bdf2af7"), "Benzinas" },
                    { new Guid("adb92f27-86d5-4ad2-a8da-fee07844bf22"), "Dyzelinas" }
                });

            migrationBuilder.InsertData(
                table: "Heights",
                columns: new[] { "Id", "TireHeight" },
                values: new object[,]
                {
                    { new Guid("bd10d612-fcbd-4df0-8c86-f46f7e4ce19e"), 205m },
                    { new Guid("95f0b057-15d6-43bc-ac0c-289a717f995c"), 215m }
                });

            migrationBuilder.InsertData(
                table: "ManufacturerModels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("f6a9907d-12b7-403d-8eec-df80d56d623d"), "RS6" },
                    { new Guid("a57722b2-e538-47bd-b712-e5a38bb5035d"), "E60" }
                });

            migrationBuilder.InsertData(
                table: "SteeringWheelPos",
                columns: new[] { "Id", "Position" },
                values: new object[,]
                {
                    { new Guid("6e2a17a0-5f03-45a7-97ef-a710a35547e8"), "Kairė" },
                    { new Guid("90011866-1c58-4c40-aaed-ded1114e6d9c"), "Dešinė" }
                });

            migrationBuilder.InsertData(
                table: "Transmissions",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("2012170e-9df6-4aef-9652-3180fec0df5b"), "Automatinė" },
                    { new Guid("373e19e0-5c4e-48ad-b6e8-f5b240b4359f"), "Mechaninė" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarImages_CarId",
                table: "CarImages",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_MotorbikeImages_MotorbikeId",
                table: "MotorbikeImages",
                column: "MotorbikeId");

            migrationBuilder.CreateIndex(
                name: "IX_TireImages_TireId",
                table: "TireImages",
                column: "TireId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarImages");

            migrationBuilder.DropTable(
                name: "MotorbikeImages");

            migrationBuilder.DropTable(
                name: "TireImages");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("24f5190a-b8cd-494a-a750-a7ac2da0d7d1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5498def1-1ca3-42c9-bfe1-64019412bc49"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("14fcd99c-3593-40be-b132-5465c9edefaf"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: new Guid("d88635dc-678d-4700-8340-83eaab0b7a84"));

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: new Guid("87d02b16-711e-408c-9c46-028deb30c505"));

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: new Guid("8c9aadf1-76d1-42c4-bf12-7f4203f6f348"));

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: new Guid("15ffe8aa-2b9a-4106-a09b-5be4d1ff145d"));

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: new Guid("4edb5c1b-f59a-4247-9edd-12825e8c9280"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("46e32ac2-1470-4cbf-bccf-bcd30de9707b"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("cb4c8b85-7ee8-4e27-8a0f-9e0854a5eace"));

            migrationBuilder.DeleteData(
                table: "Diameters",
                keyColumn: "Id",
                keyValue: new Guid("92d169fb-19b6-4725-902c-55512ea2a5b9"));

            migrationBuilder.DeleteData(
                table: "Diameters",
                keyColumn: "Id",
                keyValue: new Guid("f4eddc26-d1bc-495e-a3a5-597d7b3c58dd"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("93cb3b17-8b07-4a8f-9cd4-eafbfd23bc21"));

            migrationBuilder.DeleteData(
                table: "Doors",
                keyColumn: "Id",
                keyValue: new Guid("ba9dfc3a-4478-4536-95b1-e5135c2d3060"));

            migrationBuilder.DeleteData(
                table: "FrameTypes",
                keyColumn: "Id",
                keyValue: new Guid("3f78b537-7d01-4bde-bfdc-81d62bfcfc68"));

            migrationBuilder.DeleteData(
                table: "FrameTypes",
                keyColumn: "Id",
                keyValue: new Guid("5d53e8e3-3dab-4e94-ab7a-57c1cee47c8f"));

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: new Guid("8700eacf-bb3c-42f4-9c76-40708bdf2af7"));

            migrationBuilder.DeleteData(
                table: "FuelTypes",
                keyColumn: "Id",
                keyValue: new Guid("adb92f27-86d5-4ad2-a8da-fee07844bf22"));

            migrationBuilder.DeleteData(
                table: "Heights",
                keyColumn: "Id",
                keyValue: new Guid("95f0b057-15d6-43bc-ac0c-289a717f995c"));

            migrationBuilder.DeleteData(
                table: "Heights",
                keyColumn: "Id",
                keyValue: new Guid("bd10d612-fcbd-4df0-8c86-f46f7e4ce19e"));

            migrationBuilder.DeleteData(
                table: "ManufacturerModels",
                keyColumn: "Id",
                keyValue: new Guid("a57722b2-e538-47bd-b712-e5a38bb5035d"));

            migrationBuilder.DeleteData(
                table: "ManufacturerModels",
                keyColumn: "Id",
                keyValue: new Guid("f6a9907d-12b7-403d-8eec-df80d56d623d"));

            migrationBuilder.DeleteData(
                table: "SteeringWheelPos",
                keyColumn: "Id",
                keyValue: new Guid("6e2a17a0-5f03-45a7-97ef-a710a35547e8"));

            migrationBuilder.DeleteData(
                table: "SteeringWheelPos",
                keyColumn: "Id",
                keyValue: new Guid("90011866-1c58-4c40-aaed-ded1114e6d9c"));

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: new Guid("2012170e-9df6-4aef-9652-3180fec0df5b"));

            migrationBuilder.DeleteData(
                table: "Transmissions",
                keyColumn: "Id",
                keyValue: new Guid("373e19e0-5c4e-48ad-b6e8-f5b240b4359f"));

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CarId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2a66039e-f447-4348-969d-5d09a735d5dc"), "Automobilis" },
                    { new Guid("a5556584-f587-4680-acd9-7ee6c5ddbca6"), "Motociklas" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("4f0dbef2-b49c-4396-b3de-b9d4694cfa6b"), "Balta" },
                    { new Guid("4af062a9-2439-4f28-b075-6634ac20bce8"), "Juoda" }
                });

            migrationBuilder.InsertData(
                table: "Conditions",
                columns: new[] { "Id", "VehicCondition" },
                values: new object[,]
                {
                    { new Guid("1dd774d1-097d-4bdc-ab83-43442f77b7f8"), "Naudota" },
                    { new Guid("e30056bc-1b6e-44f5-9de2-7255381430c8"), "Nauja" }
                });

            migrationBuilder.InsertData(
                table: "Coolings",
                columns: new[] { "Id", "CoolingType" },
                values: new object[,]
                {
                    { new Guid("3d04b4af-bff0-443e-9f8f-271e7da967b8"), "Oru" },
                    { new Guid("655bcc53-053d-43fc-bae1-035ad524901b"), "Vandeniu" }
                });

            migrationBuilder.InsertData(
                table: "Defects",
                columns: new[] { "Id", "Defect" },
                values: new object[,]
                {
                    { new Guid("e041a12b-f267-4ab3-9a8d-0c6dd7d63118"), "Be defetkų" },
                    { new Guid("a6e612ba-b37c-4329-8c6e-d415ae9520e9"), "Degęs" }
                });

            migrationBuilder.InsertData(
                table: "Diameters",
                columns: new[] { "Id", "TireDiameter" },
                values: new object[,]
                {
                    { new Guid("5c3d7b5b-f8e3-4eb6-9a2c-601aa44ef77c"), 17m },
                    { new Guid("feb2f9bc-567a-4ebe-ab54-2d39dec5979f"), 18m }
                });

            migrationBuilder.InsertData(
                table: "Doors",
                columns: new[] { "Id", "DoorCount" },
                values: new object[,]
                {
                    { new Guid("1b3988c1-e392-45f3-bcf5-bdb1b59b85f8"), "2/3" },
                    { new Guid("fa7a0b4c-bc01-479a-8b3d-c137d67c0b29"), "4/5" }
                });

            migrationBuilder.InsertData(
                table: "FrameTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("1fc67b35-c6b7-427f-aaf5-2d71ff1bdf1b"), "Universalas" },
                    { new Guid("aa1fc47f-1753-4ea5-a4d5-43c811586c83"), "Sedanas" }
                });

            migrationBuilder.InsertData(
                table: "FuelTypes",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("703cd7e6-65d7-4a47-9aef-07bae4b3465c"), "Benzinas" },
                    { new Guid("e184a9c5-e2e9-4700-b847-47811f98a7c7"), "Dyzelinas" }
                });

            migrationBuilder.InsertData(
                table: "Heights",
                columns: new[] { "Id", "TireHeight" },
                values: new object[,]
                {
                    { new Guid("fb98e7ea-7d0f-47bc-bcef-420730ef9ad3"), 205m },
                    { new Guid("d9afc208-90ef-4b15-b085-2596b6444a7d"), 215m }
                });

            migrationBuilder.InsertData(
                table: "ManufacturerModels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("61871236-0fd8-4b84-a34b-8e7d14309786"), "RS6" },
                    { new Guid("7a5a818c-6106-4ac0-9a7e-c9450027291d"), "E60" }
                });

            migrationBuilder.InsertData(
                table: "SteeringWheelPos",
                columns: new[] { "Id", "Position" },
                values: new object[,]
                {
                    { new Guid("63108cc8-ab64-4aa3-9cc7-92f5e2187d26"), "Kairė" },
                    { new Guid("a678f96e-a02f-4ba9-a30a-538baf703c67"), "Dešinė" }
                });

            migrationBuilder.InsertData(
                table: "Transmissions",
                columns: new[] { "Id", "Type" },
                values: new object[,]
                {
                    { new Guid("8dfc58e4-0d53-4e66-98b8-9117ebf76391"), "Automatinė" },
                    { new Guid("6edbb704-a7a3-4f69-8f0e-429727f50adc"), "Mechaninė" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Images_CarId",
                table: "Images",
                column: "CarId");
        }
    }
}
