using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FMSAccidentalCheckComments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FMSAccidentalCheckId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FMSAccidentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FMSVehicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FMSAccidentalCheckComments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FMSAccidentalCheckImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FMSAccidentalCheckId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FMSAccidentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FMSVehicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FMSAccidentalCheckImages", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FMSAccidentalCheckComments");

            migrationBuilder.DropTable(
                name: "FMSAccidentalCheckImages");
        }
    }
}
