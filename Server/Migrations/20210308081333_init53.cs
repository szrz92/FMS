using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init53 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FMSDailyEveningChecks");

            migrationBuilder.DropTable(
                name: "FMSDailyMorningChecks");

            migrationBuilder.CreateTable(
                name: "DailyEveningChecks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VehicleNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DriverName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subregion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EE1 = table.Column<int>(type: "int", nullable: false),
                    EE2 = table.Column<int>(type: "int", nullable: false),
                    EE3 = table.Column<int>(type: "int", nullable: false),
                    EE4 = table.Column<int>(type: "int", nullable: false),
                    EE5 = table.Column<int>(type: "int", nullable: false),
                    EE6 = table.Column<int>(type: "int", nullable: false),
                    EE7 = table.Column<int>(type: "int", nullable: false),
                    EE8 = table.Column<int>(type: "int", nullable: false),
                    EE9 = table.Column<int>(type: "int", nullable: false),
                    EE10 = table.Column<int>(type: "int", nullable: false),
                    EE11 = table.Column<int>(type: "int", nullable: false),
                    EB1 = table.Column<int>(type: "int", nullable: false),
                    EB2 = table.Column<int>(type: "int", nullable: false),
                    EB3 = table.Column<int>(type: "int", nullable: false),
                    EB4 = table.Column<int>(type: "int", nullable: false),
                    EB5 = table.Column<int>(type: "int", nullable: false),
                    EB6 = table.Column<int>(type: "int", nullable: false),
                    EB7 = table.Column<int>(type: "int", nullable: false),
                    EI1 = table.Column<int>(type: "int", nullable: false),
                    EI2 = table.Column<int>(type: "int", nullable: false),
                    EI3 = table.Column<int>(type: "int", nullable: false),
                    EI4 = table.Column<int>(type: "int", nullable: false),
                    EI5 = table.Column<int>(type: "int", nullable: false),
                    EI6 = table.Column<int>(type: "int", nullable: false),
                    EI7 = table.Column<int>(type: "int", nullable: false),
                    EI8 = table.Column<int>(type: "int", nullable: false),
                    EI9 = table.Column<int>(type: "int", nullable: false),
                    EI10 = table.Column<int>(type: "int", nullable: false),
                    EI11 = table.Column<int>(type: "int", nullable: false),
                    EI12 = table.Column<int>(type: "int", nullable: false),
                    EI13 = table.Column<int>(type: "int", nullable: false),
                    EI14 = table.Column<int>(type: "int", nullable: false),
                    EI15 = table.Column<int>(type: "int", nullable: false),
                    EI16 = table.Column<int>(type: "int", nullable: false),
                    EI17 = table.Column<int>(type: "int", nullable: false),
                    EI18 = table.Column<int>(type: "int", nullable: false),
                    EI19 = table.Column<int>(type: "int", nullable: false),
                    EI20 = table.Column<int>(type: "int", nullable: false),
                    EI21 = table.Column<int>(type: "int", nullable: false),
                    EI22 = table.Column<int>(type: "int", nullable: false),
                    EI23 = table.Column<int>(type: "int", nullable: false),
                    EA1 = table.Column<int>(type: "int", nullable: false),
                    EA2 = table.Column<int>(type: "int", nullable: false),
                    EA3 = table.Column<int>(type: "int", nullable: false),
                    EA4 = table.Column<int>(type: "int", nullable: false),
                    EA5 = table.Column<int>(type: "int", nullable: false),
                    EA6 = table.Column<int>(type: "int", nullable: false),
                    EG1 = table.Column<int>(type: "int", nullable: false),
                    EG2 = table.Column<int>(type: "int", nullable: false),
                    EG3 = table.Column<int>(type: "int", nullable: false),
                    EG4 = table.Column<int>(type: "int", nullable: false),
                    EG5 = table.Column<int>(type: "int", nullable: false),
                    EG6 = table.Column<int>(type: "int", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyEveningChecks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DailyMorningChecks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VehicleNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DriverName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subregion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M1 = table.Column<int>(type: "int", nullable: false),
                    M2 = table.Column<int>(type: "int", nullable: false),
                    M3 = table.Column<int>(type: "int", nullable: false),
                    M4 = table.Column<int>(type: "int", nullable: false),
                    M5 = table.Column<int>(type: "int", nullable: false),
                    M6 = table.Column<int>(type: "int", nullable: false),
                    M7 = table.Column<int>(type: "int", nullable: false),
                    M8 = table.Column<int>(type: "int", nullable: false),
                    M9 = table.Column<int>(type: "int", nullable: false),
                    M10 = table.Column<int>(type: "int", nullable: false),
                    M11 = table.Column<int>(type: "int", nullable: false),
                    M12 = table.Column<int>(type: "int", nullable: false),
                    M13 = table.Column<int>(type: "int", nullable: false),
                    M14 = table.Column<int>(type: "int", nullable: false),
                    M15 = table.Column<int>(type: "int", nullable: false),
                    M16 = table.Column<int>(type: "int", nullable: false),
                    M17 = table.Column<int>(type: "int", nullable: false),
                    M18 = table.Column<int>(type: "int", nullable: false),
                    M19 = table.Column<int>(type: "int", nullable: false),
                    M20 = table.Column<int>(type: "int", nullable: false),
                    M21 = table.Column<int>(type: "int", nullable: false),
                    M22 = table.Column<int>(type: "int", nullable: false),
                    M23 = table.Column<int>(type: "int", nullable: false),
                    M24 = table.Column<int>(type: "int", nullable: false),
                    M25 = table.Column<int>(type: "int", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyMorningChecks", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc3389d0-35ab-4878-a5ce-1852e4226b0a", "AQAAAAEAACcQAAAAEOtXG+mX62rK+0Dy0IxRmuBu5YOL0hK+ocTqytKUrcgFFoJZo2wwchBtsJImPSMdaQ==", "f7c7281e-5c1f-45a5-a440-907b9f81eb94" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DailyEveningChecks");

            migrationBuilder.DropTable(
                name: "DailyMorningChecks");

            migrationBuilder.CreateTable(
                name: "FMSDailyEveningChecks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DriverName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EA1 = table.Column<bool>(type: "bit", nullable: false),
                    EA2 = table.Column<bool>(type: "bit", nullable: false),
                    EA3 = table.Column<bool>(type: "bit", nullable: false),
                    EA4 = table.Column<bool>(type: "bit", nullable: false),
                    EA5 = table.Column<bool>(type: "bit", nullable: false),
                    EA6 = table.Column<bool>(type: "bit", nullable: false),
                    EB1 = table.Column<bool>(type: "bit", nullable: false),
                    EB2 = table.Column<bool>(type: "bit", nullable: false),
                    EB3 = table.Column<bool>(type: "bit", nullable: false),
                    EB4 = table.Column<bool>(type: "bit", nullable: false),
                    EB5 = table.Column<bool>(type: "bit", nullable: false),
                    EB6 = table.Column<bool>(type: "bit", nullable: false),
                    EB7 = table.Column<bool>(type: "bit", nullable: false),
                    EE1 = table.Column<bool>(type: "bit", nullable: false),
                    EE10 = table.Column<bool>(type: "bit", nullable: false),
                    EE11 = table.Column<bool>(type: "bit", nullable: false),
                    EE2 = table.Column<bool>(type: "bit", nullable: false),
                    EE3 = table.Column<bool>(type: "bit", nullable: false),
                    EE4 = table.Column<bool>(type: "bit", nullable: false),
                    EE5 = table.Column<bool>(type: "bit", nullable: false),
                    EE6 = table.Column<bool>(type: "bit", nullable: false),
                    EE7 = table.Column<bool>(type: "bit", nullable: false),
                    EE8 = table.Column<bool>(type: "bit", nullable: false),
                    EE9 = table.Column<bool>(type: "bit", nullable: false),
                    EG1 = table.Column<bool>(type: "bit", nullable: false),
                    EG2 = table.Column<bool>(type: "bit", nullable: false),
                    EG3 = table.Column<bool>(type: "bit", nullable: false),
                    EG4 = table.Column<bool>(type: "bit", nullable: false),
                    EG5 = table.Column<bool>(type: "bit", nullable: false),
                    EG6 = table.Column<bool>(type: "bit", nullable: false),
                    EI1 = table.Column<bool>(type: "bit", nullable: false),
                    EI10 = table.Column<bool>(type: "bit", nullable: false),
                    EI11 = table.Column<bool>(type: "bit", nullable: false),
                    EI12 = table.Column<bool>(type: "bit", nullable: false),
                    EI13 = table.Column<bool>(type: "bit", nullable: false),
                    EI14 = table.Column<bool>(type: "bit", nullable: false),
                    EI15 = table.Column<bool>(type: "bit", nullable: false),
                    EI16 = table.Column<bool>(type: "bit", nullable: false),
                    EI17 = table.Column<bool>(type: "bit", nullable: false),
                    EI18 = table.Column<bool>(type: "bit", nullable: false),
                    EI19 = table.Column<bool>(type: "bit", nullable: false),
                    EI2 = table.Column<bool>(type: "bit", nullable: false),
                    EI20 = table.Column<bool>(type: "bit", nullable: false),
                    EI21 = table.Column<bool>(type: "bit", nullable: false),
                    EI22 = table.Column<bool>(type: "bit", nullable: false),
                    EI23 = table.Column<bool>(type: "bit", nullable: false),
                    EI3 = table.Column<bool>(type: "bit", nullable: false),
                    EI4 = table.Column<bool>(type: "bit", nullable: false),
                    EI5 = table.Column<bool>(type: "bit", nullable: false),
                    EI6 = table.Column<bool>(type: "bit", nullable: false),
                    EI7 = table.Column<bool>(type: "bit", nullable: false),
                    EI8 = table.Column<bool>(type: "bit", nullable: false),
                    EI9 = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subregion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FMSDailyEveningChecks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FMSDailyMorningChecks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DriverName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    M1 = table.Column<bool>(type: "bit", nullable: false),
                    M10 = table.Column<bool>(type: "bit", nullable: false),
                    M11 = table.Column<bool>(type: "bit", nullable: false),
                    M12 = table.Column<bool>(type: "bit", nullable: false),
                    M13 = table.Column<bool>(type: "bit", nullable: false),
                    M14 = table.Column<bool>(type: "bit", nullable: false),
                    M15 = table.Column<bool>(type: "bit", nullable: false),
                    M16 = table.Column<bool>(type: "bit", nullable: false),
                    M17 = table.Column<bool>(type: "bit", nullable: false),
                    M18 = table.Column<bool>(type: "bit", nullable: false),
                    M19 = table.Column<bool>(type: "bit", nullable: false),
                    M2 = table.Column<bool>(type: "bit", nullable: false),
                    M20 = table.Column<bool>(type: "bit", nullable: false),
                    M21 = table.Column<bool>(type: "bit", nullable: false),
                    M22 = table.Column<bool>(type: "bit", nullable: false),
                    M23 = table.Column<bool>(type: "bit", nullable: false),
                    M24 = table.Column<bool>(type: "bit", nullable: false),
                    M25 = table.Column<bool>(type: "bit", nullable: false),
                    M3 = table.Column<bool>(type: "bit", nullable: false),
                    M4 = table.Column<bool>(type: "bit", nullable: false),
                    M5 = table.Column<bool>(type: "bit", nullable: false),
                    M6 = table.Column<bool>(type: "bit", nullable: false),
                    M7 = table.Column<bool>(type: "bit", nullable: false),
                    M8 = table.Column<bool>(type: "bit", nullable: false),
                    M9 = table.Column<bool>(type: "bit", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subregion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FMSDailyMorningChecks", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff871840-5158-4bbb-95d4-f12f2a625b6f", "AQAAAAEAACcQAAAAEAfTQi4HkHPDPJsFxSNjpUgmFDVCB3WM10IfLRFO5pL8B7s64lHbMV8dxiEtfQyXmQ==", "af677c1e-5352-4f11-9d76-747604b7873a" });
        }
    }
}
