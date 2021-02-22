using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class Init34 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Region",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Station",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d40547fc-b4ae-45e7-b11f-04e8d046ad3a", "AQAAAAEAACcQAAAAEIJGu2lF6ikwcApP8/RWPImDSfPZLFLzM1DG0Im39GPj3FoOZ3EMgtl5ZcLbLLTWEg==", "22e0ddea-aa5c-42f8-bb76-11369ffd4c6a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Region",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Station",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca7f8d68-6b79-45f0-9298-232a38adbae3", "AQAAAAEAACcQAAAAEDA1sox7YuY5I+fv2ZftbxsS63AZDgRA5v+yTn6ck2KBgHz0Bj9g005M1g7V54TGhA==", "baddb3e2-e144-4d3e-9ad7-5fda3b7e56b7" });
        }
    }
}
