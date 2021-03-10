using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init56 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Region",
                table: "Complaints",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subregion",
                table: "Complaints",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd4e8ecf-1e64-42e1-8a63-ac875b5d48e4", "AQAAAAEAACcQAAAAEHOmAT1kJJfbj/EuFwJYY2E+/cZOusctcZi7SJlNbu88MYLv/0mDE+u3eui9UZGV7w==", "58949ec0-0314-443e-a5b7-672419662ad2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Region",
                table: "Complaints");

            migrationBuilder.DropColumn(
                name: "Subregion",
                table: "Complaints");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a25f580e-d89b-46d9-8a25-cc0eb03d54df", "AQAAAAEAACcQAAAAENUHL8mxEasBnukdUbxSeeuWRHDaRiVEn5L0w9gMj+Z0G5pwaOfwuZxTDueqX6sV4Q==", "e294de0d-6c3e-40be-a3e9-1a4fafbbf36c" });
        }
    }
}
