using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init27 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FMSEmergencyCheckComments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FMSEmergencyCheckId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FMSEmergencyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FMSVehicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VehicleNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mentions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FMSUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FMSEmergencyCheckComments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FMSEmergencyCheckImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FMSEmergencyCheckId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FMSEmergencyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FMSVehicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FMSEmergencyCheckImages", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FMSEmergencyCheckComments");

            migrationBuilder.DropTable(
                name: "FMSEmergencyCheckImages");
        }
    }
}
