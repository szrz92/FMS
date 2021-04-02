using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class stationInEverything : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "StationId",
                table: "Emergencies",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Station",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Station",
                table: "DailyMorningChecks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Station",
                table: "DailyEveningChecks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Station",
                table: "Complaints",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Station",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "StationId",
                table: "Accidents",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "163b8072-2535-4fa9-9e70-94f4de4e557e", "AQAAAAEAACcQAAAAEBm88kAAnMyBrDVTIgQQVkMJd/TE5zqTWrhpWOfCJlnesRqXmNxqZIqYA6dIcKIcpw==", "d3e7fee6-d443-496d-ba71-47499f655681" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StationId",
                table: "Emergencies");

            migrationBuilder.DropColumn(
                name: "Station",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "Station",
                table: "DailyMorningChecks");

            migrationBuilder.DropColumn(
                name: "Station",
                table: "DailyEveningChecks");

            migrationBuilder.DropColumn(
                name: "Station",
                table: "Complaints");

            migrationBuilder.DropColumn(
                name: "Station",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "StationId",
                table: "Accidents");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d2d66c3-71fd-4de2-ae12-0ce0191b2b9d", "AQAAAAEAACcQAAAAEDNd4jXtuW2u0Irtx+eVFnisnqC8BYCY6zWFGNDz6yaVseIcbo0uJebPUqjatUyvSQ==", "b9a2ebb9-2d1b-47a6-a908-c8fffbe14195" });
        }
    }
}
