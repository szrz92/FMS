using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init67 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Remarks",
                table: "EmergencyBills",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EmergencyBillDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CheckPointId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubServiceType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmergencyBillDetails", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc69ee5b-84f4-4a0c-80e2-8ce8da1ff776", "AQAAAAEAACcQAAAAELjSnD44ZoWZYhs5SByYLk/O+29edAZEFzDfPNaz1tWaHPZIuEySIVKsKVw+HXHUXQ==", "686ef493-82df-4187-885f-40c9cf8b3e2d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmergencyBillDetails");

            migrationBuilder.DropColumn(
                name: "Remarks",
                table: "EmergencyBills");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8cf0719-e4d7-4351-809f-ff25eb7b8788", "AQAAAAEAACcQAAAAEO+u7pNJgAMvS1LwR+FTal2K522ga23Fz8dYRVXvigQsSWwM0R6xwTSWJbFNKKX6aA==", "67871256-0c12-4e1c-979f-c43f7c9f36a3" });
        }
    }
}
