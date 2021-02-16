using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FMSAccounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Role = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FMSUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FMSAccounts");

            migrationBuilder.DropTable(
                name: "FMSRoles");
        }
    }
}
