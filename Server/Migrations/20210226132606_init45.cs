using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init45 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PeriodicHistories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConfigurationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DriverName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DriverCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastCheckMonth = table.Column<int>(type: "int", nullable: false),
                    LastCheckDistance = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeriodicHistories", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18b2ee9a-57e8-49e0-a197-3123529cba35", "AQAAAAEAACcQAAAAEP9+Rk21v66kKwhOij3A/UJi3rigicD6pP5SEuOHRiHqOxQw4QYRwQG4CLmcXmKk9A==", "5ef74521-4172-43b0-acf7-25a8cbe1b0a9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PeriodicHistories");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "049db42b-2272-40cb-b818-5bd119433378", "AQAAAAEAACcQAAAAEOZUGAyJDlbG9xxGUpf4haiYDcTt4MBXsxBtNnBP0lB7rQznKNh9kB4GeztZHx9UNg==", "136beed2-143e-471e-a2b6-68c25e6c2e67" });
        }
    }
}
