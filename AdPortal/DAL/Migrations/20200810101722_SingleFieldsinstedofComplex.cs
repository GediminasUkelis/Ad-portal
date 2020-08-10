using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class SingleFieldsinstedofComplex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Categories_CategoryId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Colors_ColorId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Defects_DefectsId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Doors_DoorsId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_FrameTypes_FrameTypeId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_FuelTypes_FuelTypeId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Manufacturers_ManufacturerId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_ManufacturerModels_ManufacturerModelId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_SteeringWheelPos_SteeringWheelPosId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Transmissions_TransmissionId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Image_Tires_TireId",
                table: "Image");

            migrationBuilder.DropForeignKey(
                name: "FK_Motorbikes_Categories_CategoryId",
                table: "Motorbikes");

            migrationBuilder.DropForeignKey(
                name: "FK_Motorbikes_Conditions_ConditionId",
                table: "Motorbikes");

            migrationBuilder.DropForeignKey(
                name: "FK_Motorbikes_Coolings_CoolingId",
                table: "Motorbikes");

            migrationBuilder.DropForeignKey(
                name: "FK_Motorbikes_Defects_DefectsId",
                table: "Motorbikes");

            migrationBuilder.DropForeignKey(
                name: "FK_Motorbikes_FuelTypes_FuelTypeId",
                table: "Motorbikes");

            migrationBuilder.DropForeignKey(
                name: "FK_Motorbikes_Manufacturers_ManufacturerId",
                table: "Motorbikes");

            migrationBuilder.DropForeignKey(
                name: "FK_Motorbikes_VehicleTypes_VehicleTypeId",
                table: "Motorbikes");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Coolings");

            migrationBuilder.DropTable(
                name: "Defects");

            migrationBuilder.DropTable(
                name: "Doors");

            migrationBuilder.DropTable(
                name: "FrameTypes");

            migrationBuilder.DropTable(
                name: "FuelTypes");

            migrationBuilder.DropTable(
                name: "SteeringWheelPos");

            migrationBuilder.DropTable(
                name: "Tires");

            migrationBuilder.DropTable(
                name: "Transmissions");

            migrationBuilder.DropTable(
                name: "VehicleTypes");

            migrationBuilder.DropTable(
                name: "Conditions");

            migrationBuilder.DropTable(
                name: "Diameters");

            migrationBuilder.DropTable(
                name: "Heights");

            migrationBuilder.DropTable(
                name: "Seasons");

            migrationBuilder.DropTable(
                name: "TirePurposes");

            migrationBuilder.DropTable(
                name: "Widths");

            migrationBuilder.DropIndex(
                name: "IX_Motorbikes_CategoryId",
                table: "Motorbikes");

            migrationBuilder.DropIndex(
                name: "IX_Motorbikes_ConditionId",
                table: "Motorbikes");

            migrationBuilder.DropIndex(
                name: "IX_Motorbikes_CoolingId",
                table: "Motorbikes");

            migrationBuilder.DropIndex(
                name: "IX_Motorbikes_DefectsId",
                table: "Motorbikes");

            migrationBuilder.DropIndex(
                name: "IX_Motorbikes_FuelTypeId",
                table: "Motorbikes");

            migrationBuilder.DropIndex(
                name: "IX_Motorbikes_ManufacturerId",
                table: "Motorbikes");

            migrationBuilder.DropIndex(
                name: "IX_Motorbikes_VehicleTypeId",
                table: "Motorbikes");

            migrationBuilder.DropIndex(
                name: "IX_Image_TireId",
                table: "Image");

            migrationBuilder.DropIndex(
                name: "IX_Cars_CategoryId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_ColorId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_DefectsId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_DoorsId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_FrameTypeId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_FuelTypeId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_ManufacturerId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_ManufacturerModelId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_SteeringWheelPosId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_TransmissionId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Motorbikes");

            migrationBuilder.DropColumn(
                name: "ConditionId",
                table: "Motorbikes");

            migrationBuilder.DropColumn(
                name: "CoolingId",
                table: "Motorbikes");

            migrationBuilder.DropColumn(
                name: "DefectsId",
                table: "Motorbikes");

            migrationBuilder.DropColumn(
                name: "FuelTypeId",
                table: "Motorbikes");

            migrationBuilder.DropColumn(
                name: "ManufacturerId",
                table: "Motorbikes");

            migrationBuilder.DropColumn(
                name: "VehicleTypeId",
                table: "Motorbikes");

            migrationBuilder.DropColumn(
                name: "TireId",
                table: "Image");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "ColorId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "DefectsId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "DoorsId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "FrameTypeId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "FuelTypeId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "ManufacturerId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "ManufacturerModelId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "SteeringWheelPosId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "TransmissionId",
                table: "Cars");

            migrationBuilder.AlterColumn<float>(
                name: "TireWearOut",
                table: "Motorbikes",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<float>(
                name: "Price",
                table: "Motorbikes",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<short>(
                name: "Power",
                table: "Motorbikes",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<short>(
                name: "EngineCapacity",
                table: "Motorbikes",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "BikeType",
                table: "Motorbikes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Category",
                table: "Motorbikes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Condition",
                table: "Motorbikes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Cooling",
                table: "Motorbikes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Defects",
                table: "Motorbikes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Fuel",
                table: "Motorbikes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Manufacturer",
                table: "Motorbikes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ManufacturerModel",
                table: "Motorbikes",
                nullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "Seats",
                table: "Cars",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<float>(
                name: "Price",
                table: "Cars",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<int>(
                name: "Category",
                table: "Cars",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Cars",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Condition",
                table: "Cars",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Defects",
                table: "Cars",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Doors",
                table: "Cars",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Frame",
                table: "Cars",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Fuel",
                table: "Cars",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Manufacturer",
                table: "Cars",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ManufacturerModel",
                table: "Cars",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "SteeringWheelPos",
                table: "Cars",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Transmission",
                table: "Cars",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BikeType",
                table: "Motorbikes");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Motorbikes");

            migrationBuilder.DropColumn(
                name: "Condition",
                table: "Motorbikes");

            migrationBuilder.DropColumn(
                name: "Cooling",
                table: "Motorbikes");

            migrationBuilder.DropColumn(
                name: "Defects",
                table: "Motorbikes");

            migrationBuilder.DropColumn(
                name: "Fuel",
                table: "Motorbikes");

            migrationBuilder.DropColumn(
                name: "Manufacturer",
                table: "Motorbikes");

            migrationBuilder.DropColumn(
                name: "ManufacturerModel",
                table: "Motorbikes");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Condition",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Defects",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Doors",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Frame",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Fuel",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Manufacturer",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "ManufacturerModel",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "SteeringWheelPos",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Transmission",
                table: "Cars");

            migrationBuilder.AlterColumn<decimal>(
                name: "TireWearOut",
                table: "Motorbikes",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Motorbikes",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<int>(
                name: "Power",
                table: "Motorbikes",
                type: "int",
                nullable: false,
                oldClrType: typeof(short));

            migrationBuilder.AlterColumn<int>(
                name: "EngineCapacity",
                table: "Motorbikes",
                type: "int",
                nullable: false,
                oldClrType: typeof(short));

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "Motorbikes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ConditionId",
                table: "Motorbikes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CoolingId",
                table: "Motorbikes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DefectsId",
                table: "Motorbikes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FuelTypeId",
                table: "Motorbikes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ManufacturerId",
                table: "Motorbikes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "VehicleTypeId",
                table: "Motorbikes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TireId",
                table: "Image",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Seats",
                table: "Cars",
                type: "int",
                nullable: false,
                oldClrType: typeof(short));

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Cars",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "Cars",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ColorId",
                table: "Cars",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DefectsId",
                table: "Cars",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DoorsId",
                table: "Cars",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FrameTypeId",
                table: "Cars",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FuelTypeId",
                table: "Cars",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ManufacturerId",
                table: "Cars",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ManufacturerModelId",
                table: "Cars",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SteeringWheelPosId",
                table: "Cars",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TransmissionId",
                table: "Cars",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Conditions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VehicCondition = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conditions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Coolings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CoolingType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coolings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Defects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Defect = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Defects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Diameters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TireDiameter = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diameters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Doors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DoorCount = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FrameTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FrameTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FuelTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Heights",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TireHeight = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heights", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seasons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SeasonName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seasons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SteeringWheelPos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SteeringWheelPos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TirePurposes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TirePurposes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transmissions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transmissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Widths",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TireWidth = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Widths", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tires",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConditionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiameterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    HeightId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ManufactureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ManufacturerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    SeasonId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TirePurposeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TireWearOut = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WidthId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tires", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tires_Conditions_ConditionId",
                        column: x => x.ConditionId,
                        principalTable: "Conditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tires_Diameters_DiameterId",
                        column: x => x.DiameterId,
                        principalTable: "Diameters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tires_Heights_HeightId",
                        column: x => x.HeightId,
                        principalTable: "Heights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tires_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tires_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tires_TirePurposes_TirePurposeId",
                        column: x => x.TirePurposeId,
                        principalTable: "TirePurposes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tires_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tires_Widths_WidthId",
                        column: x => x.WidthId,
                        principalTable: "Widths",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Motorbikes_CategoryId",
                table: "Motorbikes",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Motorbikes_ConditionId",
                table: "Motorbikes",
                column: "ConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_Motorbikes_CoolingId",
                table: "Motorbikes",
                column: "CoolingId");

            migrationBuilder.CreateIndex(
                name: "IX_Motorbikes_DefectsId",
                table: "Motorbikes",
                column: "DefectsId");

            migrationBuilder.CreateIndex(
                name: "IX_Motorbikes_FuelTypeId",
                table: "Motorbikes",
                column: "FuelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Motorbikes_ManufacturerId",
                table: "Motorbikes",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Motorbikes_VehicleTypeId",
                table: "Motorbikes",
                column: "VehicleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_TireId",
                table: "Image",
                column: "TireId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CategoryId",
                table: "Cars",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ColorId",
                table: "Cars",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_DefectsId",
                table: "Cars",
                column: "DefectsId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_DoorsId",
                table: "Cars",
                column: "DoorsId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_FrameTypeId",
                table: "Cars",
                column: "FrameTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_FuelTypeId",
                table: "Cars",
                column: "FuelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ManufacturerId",
                table: "Cars",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ManufacturerModelId",
                table: "Cars",
                column: "ManufacturerModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_SteeringWheelPosId",
                table: "Cars",
                column: "SteeringWheelPosId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_TransmissionId",
                table: "Cars",
                column: "TransmissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Tires_ConditionId",
                table: "Tires",
                column: "ConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_Tires_DiameterId",
                table: "Tires",
                column: "DiameterId");

            migrationBuilder.CreateIndex(
                name: "IX_Tires_HeightId",
                table: "Tires",
                column: "HeightId");

            migrationBuilder.CreateIndex(
                name: "IX_Tires_ManufacturerId",
                table: "Tires",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Tires_SeasonId",
                table: "Tires",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Tires_TirePurposeId",
                table: "Tires",
                column: "TirePurposeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tires_UserId",
                table: "Tires",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tires_WidthId",
                table: "Tires",
                column: "WidthId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Categories_CategoryId",
                table: "Cars",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Colors_ColorId",
                table: "Cars",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Defects_DefectsId",
                table: "Cars",
                column: "DefectsId",
                principalTable: "Defects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Doors_DoorsId",
                table: "Cars",
                column: "DoorsId",
                principalTable: "Doors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_FrameTypes_FrameTypeId",
                table: "Cars",
                column: "FrameTypeId",
                principalTable: "FrameTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_FuelTypes_FuelTypeId",
                table: "Cars",
                column: "FuelTypeId",
                principalTable: "FuelTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Manufacturers_ManufacturerId",
                table: "Cars",
                column: "ManufacturerId",
                principalTable: "Manufacturers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_ManufacturerModels_ManufacturerModelId",
                table: "Cars",
                column: "ManufacturerModelId",
                principalTable: "ManufacturerModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_SteeringWheelPos_SteeringWheelPosId",
                table: "Cars",
                column: "SteeringWheelPosId",
                principalTable: "SteeringWheelPos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Transmissions_TransmissionId",
                table: "Cars",
                column: "TransmissionId",
                principalTable: "Transmissions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Tires_TireId",
                table: "Image",
                column: "TireId",
                principalTable: "Tires",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Motorbikes_Categories_CategoryId",
                table: "Motorbikes",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Motorbikes_Conditions_ConditionId",
                table: "Motorbikes",
                column: "ConditionId",
                principalTable: "Conditions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Motorbikes_Coolings_CoolingId",
                table: "Motorbikes",
                column: "CoolingId",
                principalTable: "Coolings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Motorbikes_Defects_DefectsId",
                table: "Motorbikes",
                column: "DefectsId",
                principalTable: "Defects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Motorbikes_FuelTypes_FuelTypeId",
                table: "Motorbikes",
                column: "FuelTypeId",
                principalTable: "FuelTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Motorbikes_Manufacturers_ManufacturerId",
                table: "Motorbikes",
                column: "ManufacturerId",
                principalTable: "Manufacturers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Motorbikes_VehicleTypes_VehicleTypeId",
                table: "Motorbikes",
                column: "VehicleTypeId",
                principalTable: "VehicleTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
