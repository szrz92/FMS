using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Breakdowns",
                table: "FMSVehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "CostThisMonth",
                table: "FMSVehicles",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "FuelAverage",
                table: "FMSVehicles",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "Ranking",
                table: "FMSVehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Breakdowns",
                table: "FMSVehicles");

            migrationBuilder.DropColumn(
                name: "CostThisMonth",
                table: "FMSVehicles");

            migrationBuilder.DropColumn(
                name: "FuelAverage",
                table: "FMSVehicles");

            migrationBuilder.DropColumn(
                name: "Ranking",
                table: "FMSVehicles");
        }
    }
}
