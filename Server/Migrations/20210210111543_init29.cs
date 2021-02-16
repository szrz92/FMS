using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init29 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FMSDailyEveningChecks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VehicleNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EE1 = table.Column<bool>(type: "bit", nullable: false),
                    EE2 = table.Column<bool>(type: "bit", nullable: false),
                    EE3 = table.Column<bool>(type: "bit", nullable: false),
                    EE4 = table.Column<bool>(type: "bit", nullable: false),
                    EE5 = table.Column<bool>(type: "bit", nullable: false),
                    EE6 = table.Column<bool>(type: "bit", nullable: false),
                    EE7 = table.Column<bool>(type: "bit", nullable: false),
                    EE8 = table.Column<bool>(type: "bit", nullable: false),
                    EE9 = table.Column<bool>(type: "bit", nullable: false),
                    EE10 = table.Column<bool>(type: "bit", nullable: false),
                    EE11 = table.Column<bool>(type: "bit", nullable: false),
                    EB1 = table.Column<bool>(type: "bit", nullable: false),
                    EB2 = table.Column<bool>(type: "bit", nullable: false),
                    EB3 = table.Column<bool>(type: "bit", nullable: false),
                    EB4 = table.Column<bool>(type: "bit", nullable: false),
                    EB5 = table.Column<bool>(type: "bit", nullable: false),
                    EB6 = table.Column<bool>(type: "bit", nullable: false),
                    EB7 = table.Column<bool>(type: "bit", nullable: false),
                    EI1 = table.Column<bool>(type: "bit", nullable: false),
                    EI2 = table.Column<bool>(type: "bit", nullable: false),
                    EI3 = table.Column<bool>(type: "bit", nullable: false),
                    EI4 = table.Column<bool>(type: "bit", nullable: false),
                    EI5 = table.Column<bool>(type: "bit", nullable: false),
                    EI6 = table.Column<bool>(type: "bit", nullable: false),
                    EI7 = table.Column<bool>(type: "bit", nullable: false),
                    EI8 = table.Column<bool>(type: "bit", nullable: false),
                    EI9 = table.Column<bool>(type: "bit", nullable: false),
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
                    EI20 = table.Column<bool>(type: "bit", nullable: false),
                    EI21 = table.Column<bool>(type: "bit", nullable: false),
                    EI22 = table.Column<bool>(type: "bit", nullable: false),
                    EI23 = table.Column<bool>(type: "bit", nullable: false),
                    EA1 = table.Column<bool>(type: "bit", nullable: false),
                    EA2 = table.Column<bool>(type: "bit", nullable: false),
                    EA3 = table.Column<bool>(type: "bit", nullable: false),
                    EA4 = table.Column<bool>(type: "bit", nullable: false),
                    EA5 = table.Column<bool>(type: "bit", nullable: false),
                    EA6 = table.Column<bool>(type: "bit", nullable: false),
                    EG1 = table.Column<bool>(type: "bit", nullable: false),
                    EG2 = table.Column<bool>(type: "bit", nullable: false),
                    EG3 = table.Column<bool>(type: "bit", nullable: false),
                    EG4 = table.Column<bool>(type: "bit", nullable: false),
                    EG5 = table.Column<bool>(type: "bit", nullable: false),
                    EG6 = table.Column<bool>(type: "bit", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FMSDailyEveningChecks", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FMSDailyEveningChecks");
        }
    }
}
