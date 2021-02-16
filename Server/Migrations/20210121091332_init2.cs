using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FMSVehicleAccidents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VehicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DriverId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FMSVehicleAccidents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FMSVehicles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VehicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IMEI = table.Column<int>(type: "int", nullable: false),
                    SIM = table.Column<int>(type: "int", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubRegion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FMSVehicles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FMSVehicleScoreCards",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VehicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Breakdowns = table.Column<int>(type: "int", nullable: false),
                    FuelAverage = table.Column<double>(type: "float", nullable: false),
                    CostThisMonth = table.Column<double>(type: "float", nullable: false),
                    Ranking = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FMSVehicleScoreCards", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FMSVehicleAccidents");

            migrationBuilder.DropTable(
                name: "FMSVehicles");

            migrationBuilder.DropTable(
                name: "FMSVehicleScoreCards");
        }
    }
}
