using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init30 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DriverName",
                table: "FMSDailyMorningChecks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DriverName",
                table: "FMSDailyEveningChecks",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DriverName",
                table: "FMSDailyMorningChecks");

            migrationBuilder.DropColumn(
                name: "DriverName",
                table: "FMSDailyEveningChecks");
        }
    }
}
