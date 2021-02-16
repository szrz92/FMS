using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init18 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VehicleId",
                table: "FMSAccidentalCheckList",
                newName: "FMSVehicleId");

            migrationBuilder.RenameColumn(
                name: "AccidentId",
                table: "FMSAccidentalCheckList",
                newName: "FMSAccidentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FMSVehicleId",
                table: "FMSAccidentalCheckList",
                newName: "VehicleId");

            migrationBuilder.RenameColumn(
                name: "FMSAccidentId",
                table: "FMSAccidentalCheckList",
                newName: "AccidentId");
        }
    }
}
