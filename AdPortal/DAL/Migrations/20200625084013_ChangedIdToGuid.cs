using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class ChangedIdToGuid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Conditions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    VehicCondition = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conditions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Coolings",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CoolingType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coolings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Defects",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    Defect = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Defects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Diameters",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    TireDiameter = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diameters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Doors",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    DoorCount = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FrameTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FrameTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FuelTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Heights",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    TireHeight = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heights", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seasons",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    SeasonName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seasons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SteeringWheelPos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    Position = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SteeringWheelPos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TirePurposes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TirePurposes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transmissions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transmissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Widths",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    TireWidth = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Widths", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    CategoryId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleTypes_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ManufacturerModels",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ManufacturerId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManufacturerModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ManufacturerModels_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CategoryId = table.Column<Guid>(nullable: true),
                    ManufacturerId = table.Column<Guid>(nullable: true),
                    ManufactureDate = table.Column<DateTime>(nullable: false),
                    Engine = table.Column<string>(nullable: true),
                    FuelTypeId = table.Column<Guid>(nullable: true),
                    FrameTypeId = table.Column<Guid>(nullable: true),
                    ColorId = table.Column<Guid>(nullable: true),
                    TransmissionId = table.Column<Guid>(nullable: true),
                    DefectsId = table.Column<Guid>(nullable: true),
                    SteeringWheelPosId = table.Column<Guid>(nullable: true),
                    DoorsId = table.Column<Guid>(nullable: true),
                    Seats = table.Column<int>(nullable: false),
                    VehicleInspection = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cars_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cars_Defects_DefectsId",
                        column: x => x.DefectsId,
                        principalTable: "Defects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cars_Doors_DoorsId",
                        column: x => x.DoorsId,
                        principalTable: "Doors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cars_FrameTypes_FrameTypeId",
                        column: x => x.FrameTypeId,
                        principalTable: "FrameTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cars_FuelTypes_FuelTypeId",
                        column: x => x.FuelTypeId,
                        principalTable: "FuelTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cars_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cars_SteeringWheelPos_SteeringWheelPosId",
                        column: x => x.SteeringWheelPosId,
                        principalTable: "SteeringWheelPos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cars_Transmissions_TransmissionId",
                        column: x => x.TransmissionId,
                        principalTable: "Transmissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tires",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ConditionId = table.Column<Guid>(nullable: true),
                    DiameterId = table.Column<Guid>(nullable: true),
                    WidthId = table.Column<Guid>(nullable: true),
                    HeightId = table.Column<Guid>(nullable: true),
                    SeasonId = table.Column<Guid>(nullable: true),
                    TirePurposeId = table.Column<Guid>(nullable: true),
                    ManufactureDate = table.Column<DateTime>(nullable: false),
                    TireWearOut = table.Column<decimal>(nullable: false),
                    ManufacturerId = table.Column<Guid>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false)
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
                        name: "FK_Tires_Widths_WidthId",
                        column: x => x.WidthId,
                        principalTable: "Widths",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Motorbikes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ManufacturerId = table.Column<Guid>(nullable: true),
                    CategoryId = table.Column<Guid>(nullable: true),
                    ConditionId = table.Column<Guid>(nullable: true),
                    ManufactureDate = table.Column<DateTime>(nullable: false),
                    VehicleTypeId = table.Column<Guid>(nullable: true),
                    EngineCapacity = table.Column<int>(nullable: false),
                    FuelTypeId = table.Column<Guid>(nullable: true),
                    TireWearOut = table.Column<decimal>(nullable: false),
                    Power = table.Column<int>(nullable: false),
                    CoolingId = table.Column<Guid>(nullable: true),
                    DefectsId = table.Column<Guid>(nullable: true),
                    Registration = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motorbikes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Motorbikes_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Motorbikes_Conditions_ConditionId",
                        column: x => x.ConditionId,
                        principalTable: "Conditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Motorbikes_Coolings_CoolingId",
                        column: x => x.CoolingId,
                        principalTable: "Coolings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Motorbikes_Defects_DefectsId",
                        column: x => x.DefectsId,
                        principalTable: "Defects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Motorbikes_FuelTypes_FuelTypeId",
                        column: x => x.FuelTypeId,
                        principalTable: "FuelTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Motorbikes_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Motorbikes_VehicleTypes_VehicleTypeId",
                        column: x => x.VehicleTypeId,
                        principalTable: "VehicleTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CarFeatures",
                columns: table => new
                {
                    CarId = table.Column<Guid>(nullable: false),
                    FeatureId = table.Column<Guid>(nullable: false)
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
                    MotorbikeId = table.Column<Guid>(nullable: false),
                    FeatureId = table.Column<Guid>(nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_CarFeatures_FeatureId",
                table: "CarFeatures",
                column: "FeatureId");

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
                name: "IX_Cars_SteeringWheelPosId",
                table: "Cars",
                column: "SteeringWheelPosId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_TransmissionId",
                table: "Cars",
                column: "TransmissionId");

            migrationBuilder.CreateIndex(
                name: "IX_ManufacturerModels_ManufacturerId",
                table: "ManufacturerModels",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_MotorbikeFeatures_FeatureId",
                table: "MotorbikeFeatures",
                column: "FeatureId");

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
                name: "IX_Tires_WidthId",
                table: "Tires",
                column: "WidthId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleTypes_CategoryId",
                table: "VehicleTypes",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarFeatures");

            migrationBuilder.DropTable(
                name: "ManufacturerModels");

            migrationBuilder.DropTable(
                name: "MotorbikeFeatures");

            migrationBuilder.DropTable(
                name: "Tires");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropTable(
                name: "Motorbikes");

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

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Doors");

            migrationBuilder.DropTable(
                name: "FrameTypes");

            migrationBuilder.DropTable(
                name: "SteeringWheelPos");

            migrationBuilder.DropTable(
                name: "Transmissions");

            migrationBuilder.DropTable(
                name: "Conditions");

            migrationBuilder.DropTable(
                name: "Coolings");

            migrationBuilder.DropTable(
                name: "Defects");

            migrationBuilder.DropTable(
                name: "FuelTypes");

            migrationBuilder.DropTable(
                name: "Manufacturers");

            migrationBuilder.DropTable(
                name: "VehicleTypes");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
