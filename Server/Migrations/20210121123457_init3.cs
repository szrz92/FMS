using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    XCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XrowId = table.Column<long>(type: "bigint", nullable: true),
                    XName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XGender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XFatherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XHusbandName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XCalculationMode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XCalculationModeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XPayRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    XAdvLimit = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    XShift = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XShiftDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XReligion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XReligionDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XDateOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XJoiningDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XContractDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XExpiryDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XCard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XCnic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XNtn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XEobi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XSocialSecurity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XDesignation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XDesignationDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XCadre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XCadreDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XGrade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XGradeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XCategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XLocationDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XDepartment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XDepartmentDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XSection = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XSectionDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XProject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XProjectDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XPayMode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XBankName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XBankNameDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XAccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XPersonalMobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XOfficialMobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XPersonalEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XOfficialEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XReference1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XReference2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XBloodGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XNa1 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    XNa2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    XNa3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    XRemarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IpAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IpMod = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drivers");
        }
    }
}
