using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class OneToOneRelationBetweenDetailsAndVehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_BikeDetails_BikeDetailsId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_CarDetails_CarDetailsId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_BikeDetailsId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_CarDetailsId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "BikeDetailsId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "CarDetailsId",
                table: "Product");

            migrationBuilder.AddColumn<Guid>(
                name: "VehicleId",
                table: "CarDetails",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "VehicleId",
                table: "BikeDetails",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_CarDetails_VehicleId",
                table: "CarDetails",
                column: "VehicleId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BikeDetails_Product_Id",
                table: "BikeDetails",
                column: "Id",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarDetails_Product_VehicleId",
                table: "CarDetails",
                column: "VehicleId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BikeDetails_Product_Id",
                table: "BikeDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_CarDetails_Product_VehicleId",
                table: "CarDetails");

            migrationBuilder.DropIndex(
                name: "IX_CarDetails_VehicleId",
                table: "CarDetails");

            migrationBuilder.DropColumn(
                name: "VehicleId",
                table: "CarDetails");

            migrationBuilder.DropColumn(
                name: "VehicleId",
                table: "BikeDetails");

            migrationBuilder.AddColumn<Guid>(
                name: "BikeDetailsId",
                table: "Product",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CarDetailsId",
                table: "Product",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_BikeDetailsId",
                table: "Product",
                column: "BikeDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CarDetailsId",
                table: "Product",
                column: "CarDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_BikeDetails_BikeDetailsId",
                table: "Product",
                column: "BikeDetailsId",
                principalTable: "BikeDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_CarDetails_CarDetailsId",
                table: "Product",
                column: "CarDetailsId",
                principalTable: "CarDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
