using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init61 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CheckPoint = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e516c4b3-1c39-401f-8691-eaa19be0121d", "AQAAAAEAACcQAAAAEJhOs6vkXI9q0xNGoFR8pJZfIRGSJFULinsyrx3coL7lmJk1CYi8FF2v3lV7pWBUcg==", "28834d68-7ba6-4b3e-b6f8-a7afd34f3020" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13c2aa9f-8710-4431-9301-e0a8191986c6", "AQAAAAEAACcQAAAAEEzczxGkLA63d64HToArzY6X+FQqY++/hsA8CCFVROhANHciTHCi/Q2bD1DWyqXeIw==", "67b72bbd-5a12-46e0-8926-5e36f8157137" });
        }
    }
}
