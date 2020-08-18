using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class UnifiedVehicleModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Image_Cars_CarId",
                table: "Image");

            migrationBuilder.DropForeignKey(
                name: "FK_Image_Motorbikes_MotorbikeId",
                table: "Image");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Motorbikes");

            migrationBuilder.DropIndex(
                name: "IX_Image_CarId",
                table: "Image");

            migrationBuilder.DropIndex(
                name: "IX_Image_MotorbikeId",
                table: "Image");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "Image");

            migrationBuilder.DropColumn(
                name: "MotorbikeId",
                table: "Image");

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "Image",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "BikeDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    BikeType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BikeDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    SteeringWheelPos = table.Column<bool>(nullable: false),
                    Seats = table.Column<short>(nullable: false),
                    Doors = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<float>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    Condition = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    ManufacturerModel = table.Column<string>(nullable: true),
                    ManufactureDate = table.Column<DateTime>(nullable: true),
                    Registration = table.Column<bool>(nullable: true),
                    Engine = table.Column<short>(nullable: true),
                    Category = table.Column<int>(nullable: true),
                    Frame = table.Column<int>(nullable: true),
                    Fuel = table.Column<int>(nullable: true),
                    Cooling = table.Column<int>(nullable: true),
                    Transmission = table.Column<int>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    VehicleInspection = table.Column<DateTime>(nullable: true),
                    Defects = table.Column<int>(nullable: true),
                    TireWearOut = table.Column<float>(nullable: true),
                    Power = table.Column<short>(nullable: true),
                    CarDetailsId = table.Column<Guid>(nullable: true),
                    BikeDetailsId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_BikeDetails_BikeDetailsId",
                        column: x => x.BikeDetailsId,
                        principalTable: "BikeDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_CarDetails_CarDetailsId",
                        column: x => x.CarDetailsId,
                        principalTable: "CarDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Image_ProductId",
                table: "Image",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_BikeDetailsId",
                table: "Product",
                column: "BikeDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CarDetailsId",
                table: "Product",
                column: "CarDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_UserId",
                table: "Product",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Product_ProductId",
                table: "Image",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Image_Product_ProductId",
                table: "Image");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "BikeDetails");

            migrationBuilder.DropTable(
                name: "CarDetails");

            migrationBuilder.DropIndex(
                name: "IX_Image_ProductId",
                table: "Image");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Image");

            migrationBuilder.AddColumn<Guid>(
                name: "CarId",
                table: "Image",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "MotorbikeId",
                table: "Image",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Condition = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Defects = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Doors = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Engine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Frame = table.Column<int>(type: "int", nullable: false),
                    Fuel = table.Column<int>(type: "int", nullable: false),
                    ManufactureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufacturerModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Seats = table.Column<short>(type: "smallint", nullable: false),
                    SteeringWheelPos = table.Column<bool>(type: "bit", nullable: false),
                    Transmission = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VehicleInspection = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Motorbikes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BikeType = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false),
                    Condition = table.Column<int>(type: "int", nullable: false),
                    Cooling = table.Column<int>(type: "int", nullable: false),
                    Defects = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngineCapacity = table.Column<short>(type: "smallint", nullable: false),
                    Fuel = table.Column<int>(type: "int", nullable: false),
                    ManufactureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufacturerModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Power = table.Column<short>(type: "smallint", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Registration = table.Column<bool>(type: "bit", nullable: false),
                    TireWearOut = table.Column<float>(type: "real", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motorbikes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Motorbikes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Image_CarId",
                table: "Image",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_MotorbikeId",
                table: "Image",
                column: "MotorbikeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_UserId",
                table: "Cars",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Motorbikes_UserId",
                table: "Motorbikes",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Cars_CarId",
                table: "Image",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Image_Motorbikes_MotorbikeId",
                table: "Image",
                column: "MotorbikeId",
                principalTable: "Motorbikes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
