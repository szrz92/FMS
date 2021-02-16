using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FMSVehicles",
                table: "FMSVehicles");

            migrationBuilder.RenameTable(
                name: "FMSVehicles",
                newName: "FMSVehicle");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "FMSVehicleAccidents",
                newName: "TimeStamp");

            migrationBuilder.AddColumn<Guid>(
                name: "Region",
                table: "FMSVehicleAccidents",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ReportedBy",
                table: "FMSVehicleAccidents",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "FMSVehicleAccidents",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "SubRegion",
                table: "FMSVehicleAccidents",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<Guid>(
                name: "SubRegion",
                table: "FMSVehicle",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Region",
                table: "FMSVehicle",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DriverId",
                table: "FMSVehicle",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_FMSVehicle",
                table: "FMSVehicle",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FMSVehicle",
                table: "FMSVehicle");

            migrationBuilder.DropColumn(
                name: "Region",
                table: "FMSVehicleAccidents");

            migrationBuilder.DropColumn(
                name: "ReportedBy",
                table: "FMSVehicleAccidents");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "FMSVehicleAccidents");

            migrationBuilder.DropColumn(
                name: "SubRegion",
                table: "FMSVehicleAccidents");

            migrationBuilder.DropColumn(
                name: "DriverId",
                table: "FMSVehicle");

            migrationBuilder.RenameTable(
                name: "FMSVehicle",
                newName: "FMSVehicles");

            migrationBuilder.RenameColumn(
                name: "TimeStamp",
                table: "FMSVehicleAccidents",
                newName: "Date");

            migrationBuilder.AlterColumn<string>(
                name: "SubRegion",
                table: "FMSVehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "Region",
                table: "FMSVehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FMSVehicles",
                table: "FMSVehicles",
                column: "Id");
        }
    }
}
