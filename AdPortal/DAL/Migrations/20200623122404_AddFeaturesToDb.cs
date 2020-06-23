using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class AddFeaturesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Features_Cars_CarId",
                table: "Features");

            migrationBuilder.DropForeignKey(
                name: "FK_Features_Motorbikes_MotorbikeId",
                table: "Features");

            migrationBuilder.DropIndex(
                name: "IX_Features_CarId",
                table: "Features");

            migrationBuilder.DropIndex(
                name: "IX_Features_MotorbikeId",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "MotorbikeId",
                table: "Features");

            migrationBuilder.CreateTable(
                name: "CarFeatures",
                columns: table => new
                {
                    CarId = table.Column<int>(nullable: false),
                    FeatureId = table.Column<int>(nullable: false)
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
                    MotorbikeId = table.Column<int>(nullable: false),
                    FeatureId = table.Column<int>(nullable: false)
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
                name: "IX_MotorbikeFeatures_FeatureId",
                table: "MotorbikeFeatures",
                column: "FeatureId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarFeatures");

            migrationBuilder.DropTable(
                name: "MotorbikeFeatures");

            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "Features",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MotorbikeId",
                table: "Features",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Features_CarId",
                table: "Features",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Features_MotorbikeId",
                table: "Features",
                column: "MotorbikeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Features_Cars_CarId",
                table: "Features",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Features_Motorbikes_MotorbikeId",
                table: "Features",
                column: "MotorbikeId",
                principalTable: "Motorbikes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
