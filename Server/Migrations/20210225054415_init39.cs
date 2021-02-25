using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init39 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.CreateTable(
                name: "GBMSVehicles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GasolineType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Station = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChasisNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngineNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastSync = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GBMSVehicles", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db4e5b56-06b2-442f-8b68-cf51fb0d36f6", "AQAAAAEAACcQAAAAEFAWZPRDYXzdDoDkhHUjy5NmZVVQuv/JWcfqsE7Ee0diswFyJjCupJIf1SntSfa0UQ==", "d52850ff-8c7f-451d-a0be-3b31888def73" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GBMSVehicles");

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IpAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IpMod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastSync = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XCapacity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XChasisNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XEngineNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XGasolineType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XGasolineTypeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XLeasingCompany = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XLocationDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XMake = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XOrigin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XOtherCosts = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    XPurchaseDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XPurchasePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    XRegistration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XRegistrationCost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    XRemarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XStation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XStationDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XTagNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XTotalCost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    XVehicleType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XVehicleTypeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XrowId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ee9bc86-fe8f-41c9-9528-888e3172d9f1", "AQAAAAEAACcQAAAAEK0uXwc1yg1yuyXGSwo3ccvPZjrgzizGh3qYzz23M3Aq0dSC+RDlT4fydylpqKatfg==", "bcde8141-e841-4a85-a6d0-3a63dfd7ea57" });
        }
    }
}
