using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RegionalOffices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    XCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XrowId = table.Column<long>(type: "bigint", nullable: true),
                    XDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XAbbrevation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XRegion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XRegionDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XRemarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IpAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IpMod = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegionalOffices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    XCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XrowId = table.Column<long>(type: "bigint", nullable: true),
                    XDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XAbbrevation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XRemarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IpAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IpMod = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    XCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XrowId = table.Column<long>(type: "bigint", nullable: true),
                    XDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XAbbrevation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XVaultStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XRemarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IpAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IpMod = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubRegions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    XCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XrowId = table.Column<long>(type: "bigint", nullable: true),
                    XDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XAbbrevation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XRegion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XRegionDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XRevenueAuthroity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XRevenueAuthroityDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XRemarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IpAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IpMod = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubRegions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    XCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XrowId = table.Column<long>(type: "bigint", nullable: true),
                    XDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XVehicleType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XVehicleTypeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XGasolineType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XGasolineTypeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XLocationDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XStation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XStationDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XMake = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XCapacity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XOrigin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XChasisNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XEngineNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XRegistration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XLeasingCompany = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XTagNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XPurchaseDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XPurchasePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    XRegistrationCost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    XOtherCosts = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    XTotalCost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    XRemarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IpAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IpMod = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    XCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XrowId = table.Column<long>(type: "bigint", nullable: true),
                    XDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XAbbreviation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XRemarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IpAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IpMod = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Zones",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    XCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XrowId = table.Column<long>(type: "bigint", nullable: true),
                    XDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XAbbrevation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XRegion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XRegionDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XRemarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IpAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IpMod = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zones", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegionalOffices");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.DropTable(
                name: "Stations");

            migrationBuilder.DropTable(
                name: "SubRegions");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "VehicleTypes");

            migrationBuilder.DropTable(
                name: "Zones");
        }
    }
}
