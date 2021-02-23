using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init37 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FMSDrivers");

            migrationBuilder.DropColumn(
                name: "AddDate",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "AddId",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "IpAdd",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "IpMod",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "ModDate",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "ModId",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XAccountNumber",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XAddress",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XAdvLimit",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XBankName",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XBankNameDescription",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XBloodGroup",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XCadre",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XCadreDescription",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XCalculationMode",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XCalculationModeDescription",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XCard",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XCategory",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XCategoryDescription",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XCity",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XCnic",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XCode",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XContractDate",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XDateOfBirth",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XDepartment",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XDepartmentDescription",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XDesignation",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XDesignationDescription",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XEobi",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XExpiryDate",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XFatherName",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XGender",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XGrade",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XGradeDescription",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XHusbandName",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XJoiningDate",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XLocation",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XLocationDescription",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XNa1",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XNa2",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XNa3",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XName",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XNtn",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XOfficialEmail",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XOfficialMobile",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XPayMode",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XPayRate",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XPersonalEmail",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XPersonalMobile",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XProject",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XProjectDescription",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XReference1",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XReference2",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XReligion",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XReligionDescription",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XRemarks",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XSection",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "XrowId",
                table: "Drivers");

            migrationBuilder.RenameColumn(
                name: "XStatus",
                table: "Drivers",
                newName: "VehicleNumber");

            migrationBuilder.RenameColumn(
                name: "XSocialSecurity",
                table: "Drivers",
                newName: "SubRegion");

            migrationBuilder.RenameColumn(
                name: "XShiftDescription",
                table: "Drivers",
                newName: "Region");

            migrationBuilder.RenameColumn(
                name: "XShift",
                table: "Drivers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "XSectionDescription",
                table: "Drivers",
                newName: "Code");

            migrationBuilder.AddColumn<int>(
                name: "Absents",
                table: "Drivers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Accidents",
                table: "Drivers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Emergencies",
                table: "Drivers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Points",
                table: "Drivers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Ranking",
                table: "Drivers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Trips",
                table: "Drivers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Violations",
                table: "Drivers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2795de4f-9f0d-42bb-87aa-cedd71ac4060", "AQAAAAEAACcQAAAAEL6gx/+USDoCf7IInVpHZevyBQG40FGAZJ02iqW5iJ9yZTxOc8Znf9VY7hnnH6VBKg==", "e4569b38-347b-4804-9a5b-5ec7373841ab" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Absents",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "Accidents",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "Emergencies",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "Points",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "Ranking",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "Trips",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "Violations",
                table: "Drivers");

            migrationBuilder.RenameColumn(
                name: "VehicleNumber",
                table: "Drivers",
                newName: "XStatus");

            migrationBuilder.RenameColumn(
                name: "SubRegion",
                table: "Drivers",
                newName: "XSocialSecurity");

            migrationBuilder.RenameColumn(
                name: "Region",
                table: "Drivers",
                newName: "XShiftDescription");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Drivers",
                newName: "XShift");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "Drivers",
                newName: "XSectionDescription");

            migrationBuilder.AddColumn<DateTime>(
                name: "AddDate",
                table: "Drivers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddId",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IpAdd",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IpMod",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModDate",
                table: "Drivers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModId",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XAccountNumber",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XAddress",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "XAdvLimit",
                table: "Drivers",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XBankName",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XBankNameDescription",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XBloodGroup",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XCadre",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XCadreDescription",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XCalculationMode",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XCalculationModeDescription",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XCard",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XCategory",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XCategoryDescription",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XCity",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XCnic",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XCode",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XContractDate",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XDateOfBirth",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XDepartment",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XDepartmentDescription",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XDesignation",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XDesignationDescription",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XEobi",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XExpiryDate",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XFatherName",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XGender",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XGrade",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XGradeDescription",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XHusbandName",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XJoiningDate",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XLocation",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XLocationDescription",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "XNa1",
                table: "Drivers",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "XNa2",
                table: "Drivers",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "XNa3",
                table: "Drivers",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XName",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XNtn",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XOfficialEmail",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XOfficialMobile",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XPayMode",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "XPayRate",
                table: "Drivers",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XPersonalEmail",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XPersonalMobile",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XProject",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XProjectDescription",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XReference1",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XReference2",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XReligion",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XReligionDescription",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XRemarks",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "XSection",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "XrowId",
                table: "Drivers",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "FMSDrivers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DriverId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DriverName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inicidents = table.Column<int>(type: "int", nullable: false),
                    JoiningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastSync = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ranking = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false),
                    Station = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalTrips = table.Column<int>(type: "int", nullable: false),
                    Violations = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FMSDrivers", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ad616ae-e059-4360-842f-afc7496ef504", "AQAAAAEAACcQAAAAEOxjwQThmmAwwxXXM0uQ0/C/3gqj2rU84iP3LGMGDyUDKrgNwKfQwksNkwpZws4xuw==", "4cdb8e2f-e2d4-47f9-a3a0-d6169de8f998" });
        }
    }
}
