using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init32 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GBMSUsers",
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
                    XGrossPay = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    XBasicPay = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
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
                    IpMod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastSync = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GBMSUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "GBMSUsers");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IpAdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IpMod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastSync = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XAccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XAdvLimit = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    XBankName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XBankNameDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XBasicPay = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    XBloodGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XCadre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XCadreDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XCard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XCategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XCnic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XContractDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XDateOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XDepartment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XDepartmentDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XDesignation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XDesignationDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XEobi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XExpiryDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XFatherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XGender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XGrade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XGradeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XGrossPay = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    XHusbandName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XJoiningDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XLocationDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XNa1 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    XNa2 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    XNa3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    XName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XNtn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XOfficialEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XOfficialMobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XPayMode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XPersonalEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XPersonalMobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XProject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XProjectDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XReference1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XReference2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XReligion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XReligionDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XRemarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XSection = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XSectionDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XShift = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XShiftDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XSocialSecurity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XrowId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }
    }
}
