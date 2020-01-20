using Microsoft.EntityFrameworkCore.Migrations;

namespace Zad7JakubKazimierski.Migrations
{
    public partial class Zad7JakubKazimierskiModelsVehicleContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarModel = table.Column<string>(nullable: true),
                    CarProducer = table.Column<string>(nullable: true),
                    DateOfProduction = table.Column<int>(nullable: false),
                    CarPrice = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarId);
                });

            migrationBuilder.CreateTable(
                name: "MBikes",
                columns: table => new
                {
                    MBikeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MBikeModel = table.Column<string>(nullable: true),
                    MBikeProducer = table.Column<string>(nullable: true),
                    DateOfProduction = table.Column<int>(nullable: false),
                    MBikePrice = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MBikes", x => x.MBikeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "MBikes");
        }
    }
}
