using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init31 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Region",
                table: "FMSDailyMorningChecks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subregion",
                table: "FMSDailyMorningChecks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Region",
                table: "FMSDailyEveningChecks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subregion",
                table: "FMSDailyEveningChecks",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Region",
                table: "FMSDailyMorningChecks");

            migrationBuilder.DropColumn(
                name: "Subregion",
                table: "FMSDailyMorningChecks");

            migrationBuilder.DropColumn(
                name: "Region",
                table: "FMSDailyEveningChecks");

            migrationBuilder.DropColumn(
                name: "Subregion",
                table: "FMSDailyEveningChecks");
        }
    }
}
