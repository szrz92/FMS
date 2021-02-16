using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init33 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FMSAccounts");

            migrationBuilder.DropTable(
                name: "FMSRoles");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "SA", null, "SA", "SA" },
                    { "HMT", null, "HMT", "HMT" },
                    { "MTAM", null, "MTAM", "MTAM" },
                    { "CIM", null, "CIM", "CIM" },
                    { "CPM", null, "CPM", "CPM" },
                    { "RMTO", null, "RMTO", "RMTO" },
                    { "RAO", null, "RAO", "RAO" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c58e1a9d-1c28-46db-830a-7b3f0b9663f1", 0, "ca7f8d68-6b79-45f0-9298-232a38adbae3", "z.raza@batech.com.pk", true, true, null, "Zain Raza", "Z.RAZA@BATECH.COM.PK", "Z.RAZA@BATECH.COM.PK", "AQAAAAEAACcQAAAAEDA1sox7YuY5I+fv2ZftbxsS63AZDgRA5v+yTn6ck2KBgHz0Bj9g005M1g7V54TGhA==", null, true, "baddb3e2-e144-4d3e-9ad7-5fda3b7e56b7", false, "z.raza@batech.com.pk" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "SA", "c58e1a9d-1c28-46db-830a-7b3f0b9663f1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "CIM");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "CPM");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "HMT");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "MTAM");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "RAO");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "RMTO");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "SA", "c58e1a9d-1c28-46db-830a-7b3f0b9663f1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "SA");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "FMSAccounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FMSUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FMSAccounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FMSRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FMSRoles", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "FMSAccounts",
                columns: new[] { "Id", "FMSUserId", "Password", "Role", "UserName" },
                values: new object[] { new Guid("3288dfef-b2ae-43ee-b719-4636519f0ed9"), new Guid("3288dfef-b2ae-43ee-b719-4636519f0ed9"), "sa", new Guid("a05d85e6-9d62-457d-9496-615daba5901b"), "sa" });

            migrationBuilder.InsertData(
                table: "FMSRoles",
                columns: new[] { "Id", "Description", "Role" },
                values: new object[,]
                {
                    { new Guid("a05d85e6-9d62-457d-9496-615daba5901b"), "Super Admin", "SA" },
                    { new Guid("2423c92a-5af1-4612-b2bd-73e6ea702b8e"), "Head Of MT", "HMT" },
                    { new Guid("7b02511e-379b-47d2-b5ee-8b38de4292ba"), "MT Accounts Manager", "MTAM" },
                    { new Guid("d255348b-a180-45a2-9cb6-6dbbdc222711"), "Coordinator Emergency , Routine / Accidental maintenance", "CIM" },
                    { new Guid("0280b129-4d31-4cc3-bdfb-e70eaa381953"), "Coordinator Periodic Maintenance", "CPM" },
                    { new Guid("363ab761-9106-42c5-99d0-00d94ead6166"), "Regional MTO", "RMTO" },
                    { new Guid("29d9c3cf-40d1-47e1-80b3-c100058be7c0"), "Regional Accounts Officer", "RAO" }
                });
        }
    }
}
