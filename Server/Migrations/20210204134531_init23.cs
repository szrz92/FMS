using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VehicleNumber",
                table: "FMSAccidents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VehicleNumber",
                table: "FMSAccidentalCheckList",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VehicleNumber",
                table: "FMSAccidentalCheckComments",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VehicleNumber",
                table: "FMSAccidents");

            migrationBuilder.DropColumn(
                name: "VehicleNumber",
                table: "FMSAccidentalCheckList");

            migrationBuilder.DropColumn(
                name: "VehicleNumber",
                table: "FMSAccidentalCheckComments");
        }
    }
}
