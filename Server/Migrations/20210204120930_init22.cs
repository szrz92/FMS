using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "FMSUserId",
                table: "FMSAccidentalCheckComments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Mentions",
                table: "FMSAccidentalCheckComments",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FMSUserId",
                table: "FMSAccidentalCheckComments");

            migrationBuilder.DropColumn(
                name: "Mentions",
                table: "FMSAccidentalCheckComments");
        }
    }
}
