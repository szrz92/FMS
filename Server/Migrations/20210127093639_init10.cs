using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FMSVehicle",
                table: "FMSVehicle");

            migrationBuilder.RenameTable(
                name: "FMSVehicle",
                newName: "FMSVehicles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FMSVehicles",
                table: "FMSVehicles",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "FMSVehiclesDev",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VehicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DriverId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IMEI = table.Column<int>(type: "int", nullable: false),
                    SIM = table.Column<int>(type: "int", nullable: false),
                    Region = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubRegion = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Breakdowns = table.Column<int>(type: "int", nullable: false),
                    FuelAverage = table.Column<double>(type: "float", nullable: false),
                    CostThisMonth = table.Column<double>(type: "float", nullable: false),
                    Ranking = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FMSVehiclesDev", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FMSVehiclesDev");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FMSVehicles",
                table: "FMSVehicles");

            migrationBuilder.RenameTable(
                name: "FMSVehicles",
                newName: "FMSVehicle");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FMSVehicle",
                table: "FMSVehicle",
                column: "Id");
        }
    }
}
