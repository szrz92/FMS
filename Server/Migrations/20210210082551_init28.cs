using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init28 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FMSDailyMorningChecks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VehicleNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M1 = table.Column<bool>(type: "bit", nullable: false),
                    M2 = table.Column<bool>(type: "bit", nullable: false),
                    M3 = table.Column<bool>(type: "bit", nullable: false),
                    M4 = table.Column<bool>(type: "bit", nullable: false),
                    M5 = table.Column<bool>(type: "bit", nullable: false),
                    M6 = table.Column<bool>(type: "bit", nullable: false),
                    M7 = table.Column<bool>(type: "bit", nullable: false),
                    M8 = table.Column<bool>(type: "bit", nullable: false),
                    M9 = table.Column<bool>(type: "bit", nullable: false),
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
                    M20 = table.Column<bool>(type: "bit", nullable: false),
                    M21 = table.Column<bool>(type: "bit", nullable: false),
                    M22 = table.Column<bool>(type: "bit", nullable: false),
                    M23 = table.Column<bool>(type: "bit", nullable: false),
                    M24 = table.Column<bool>(type: "bit", nullable: false),
                    M25 = table.Column<bool>(type: "bit", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FMSDailyMorningChecks", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FMSDailyMorningChecks");
        }
    }
}
