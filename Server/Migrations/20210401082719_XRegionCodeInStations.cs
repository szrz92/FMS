using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class XRegionCodeInStations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "XRegionCode",
                table: "Stations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "656ab03a-b4bb-48ba-a4b0-056472211dd9", "AQAAAAEAACcQAAAAECRyulqOmK1r8+8B2xVIMuOwB6r4HYgKhJRSi8ZEbOPMf3f2ck0LshQtH5MLtO6dfg==", "5af8bd24-e3da-48e9-ad4f-4fe9841b137e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "XRegionCode",
                table: "Stations");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d2e13f1-b2e5-463a-9387-050cfcac2de4", "AQAAAAEAACcQAAAAEHQ/9skfQclkRSdOfuxoLRwIVj1kSr3necQqQ4lvggm13e0h9rl5yEO6QVD+DyW+uw==", "75784f6e-16c0-42d8-9577-7dccfc8817e4" });
        }
    }
}
