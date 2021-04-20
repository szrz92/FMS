using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class BillDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DriverName",
                table: "EmergencyBillDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Odometer",
                table: "EmergencyBillDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Region",
                table: "EmergencyBillDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Station",
                table: "EmergencyBillDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subregion",
                table: "EmergencyBillDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VehicleNumber",
                table: "EmergencyBillDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DriverName",
                table: "AccidentalBillDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Odometer",
                table: "AccidentalBillDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Region",
                table: "AccidentalBillDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Station",
                table: "AccidentalBillDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subregion",
                table: "AccidentalBillDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VehicleNumber",
                table: "AccidentalBillDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BillDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubServiceType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Odometer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DriverName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subregion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Station = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillDetails", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9987bc8e-7f86-454b-a242-b37adeef3b6f", "AQAAAAEAACcQAAAAEMaVt+OKBidgCayiLlvyEueoEtdijAPPH01g+lDeNrxwDUorzt4+2CXbjob+0Dvbng==", "bcbef37f-775e-4488-bec4-8c574583a453" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BillDetails");

            migrationBuilder.DropColumn(
                name: "DriverName",
                table: "EmergencyBillDetails");

            migrationBuilder.DropColumn(
                name: "Odometer",
                table: "EmergencyBillDetails");

            migrationBuilder.DropColumn(
                name: "Region",
                table: "EmergencyBillDetails");

            migrationBuilder.DropColumn(
                name: "Station",
                table: "EmergencyBillDetails");

            migrationBuilder.DropColumn(
                name: "Subregion",
                table: "EmergencyBillDetails");

            migrationBuilder.DropColumn(
                name: "VehicleNumber",
                table: "EmergencyBillDetails");

            migrationBuilder.DropColumn(
                name: "DriverName",
                table: "AccidentalBillDetails");

            migrationBuilder.DropColumn(
                name: "Odometer",
                table: "AccidentalBillDetails");

            migrationBuilder.DropColumn(
                name: "Region",
                table: "AccidentalBillDetails");

            migrationBuilder.DropColumn(
                name: "Station",
                table: "AccidentalBillDetails");

            migrationBuilder.DropColumn(
                name: "Subregion",
                table: "AccidentalBillDetails");

            migrationBuilder.DropColumn(
                name: "VehicleNumber",
                table: "AccidentalBillDetails");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "387df01a-846f-4db7-8ff3-c15b1a72143a", "AQAAAAEAACcQAAAAECaR3d3W/r/qcWYHcPw0a2mAZGr7FrU7efXh4N2TqvLlaLSXYKVr6g5TRPilmhmd6A==", "bd2a4bd2-ac63-464f-8d4d-5303a4bb97a6" });
        }
    }
}
