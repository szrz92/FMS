using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class messageBoxForAssigningVendor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Remarks",
                table: "AssignedWorkshops",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d2e13f1-b2e5-463a-9387-050cfcac2de4", "AQAAAAEAACcQAAAAEHQ/9skfQclkRSdOfuxoLRwIVj1kSr3necQqQ4lvggm13e0h9rl5yEO6QVD+DyW+uw==", "75784f6e-16c0-42d8-9577-7dccfc8817e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Remarks",
                table: "AssignedWorkshops");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4648d5d-37b6-42f9-9e20-552e205a7f8f", "AQAAAAEAACcQAAAAEDgvQEYZ2zo8Qg+JPjBRuy/SGy1+jtND+wDruyg7Jv6e824uOKwWyopJ8bF4YDD6dQ==", "4ae090d9-63dc-4394-b67c-42f6d3655b15" });
        }
    }
}
