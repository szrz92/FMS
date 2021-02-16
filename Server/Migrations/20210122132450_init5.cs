using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Inicidents",
                table: "FMSDrivers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Ranking",
                table: "FMSDrivers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Score",
                table: "FMSDrivers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Violations",
                table: "FMSDrivers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Inicidents",
                table: "FMSDrivers");

            migrationBuilder.DropColumn(
                name: "Ranking",
                table: "FMSDrivers");

            migrationBuilder.DropColumn(
                name: "Score",
                table: "FMSDrivers");

            migrationBuilder.DropColumn(
                name: "Violations",
                table: "FMSDrivers");
        }
    }
}
