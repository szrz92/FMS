using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init40 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FMSVehicles");

            migrationBuilder.DropTable(
                name: "FMSVehiclesDev");

            migrationBuilder.CreateTable(
                name: "Vehicles",
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
                    Ranking = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                values: new object[] { "c95d73aa-0058-47cd-a722-f3dbfaadbe26", "AQAAAAEAACcQAAAAEF4LPjAEvsg/pbt+LTIQRmmgJ1gQhUtuGFqHg/d8fhO7xJyZ/IlTnZ24t9aOOgXouA==", "0ae1d986-238f-4b6e-b6e2-c63161917d45" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.CreateTable(
                name: "FMSVehicles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Breakdowns = table.Column<int>(type: "int", nullable: false),
                    CostThisMonth = table.Column<double>(type: "float", nullable: false),
                    DriverId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FuelAverage = table.Column<double>(type: "float", nullable: false),
                    IMEI = table.Column<int>(type: "int", nullable: false),
                    Ranking = table.Column<int>(type: "int", nullable: false),
                    Region = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SIM = table.Column<int>(type: "int", nullable: false),
                    SubRegion = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VehicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FMSVehicles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FMSVehiclesDev",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Breakdowns = table.Column<int>(type: "int", nullable: false),
                    CostThisMonth = table.Column<double>(type: "float", nullable: false),
                    DriverId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FuelAverage = table.Column<double>(type: "float", nullable: false),
                    IMEI = table.Column<long>(type: "bigint", nullable: false),
                    Ranking = table.Column<int>(type: "int", nullable: false),
                    Region = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SIM = table.Column<long>(type: "bigint", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubRegion = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VehicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FMSVehiclesDev", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db4e5b56-06b2-442f-8b68-cf51fb0d36f6", "AQAAAAEAACcQAAAAEFAWZPRDYXzdDoDkhHUjy5NmZVVQuv/JWcfqsE7Ee0diswFyJjCupJIf1SntSfa0UQ==", "d52850ff-8c7f-451d-a0be-3b31888def73" });
        }
    }
}
