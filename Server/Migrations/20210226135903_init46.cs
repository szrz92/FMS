using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init46 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Distance",
                table: "Vehicles",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "386716d7-55ca-4fc4-aa0d-f7e3c66f305c", "AQAAAAEAACcQAAAAEDPaFJv6iiLo9cZl15cOr7/GIZkxwUFG/MQDIRlFBCPDdWC0K8psa2lgVo8quziYeQ==", "5800fbe2-9edf-4e7d-8f8e-0b675ee176e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Distance",
                table: "Vehicles");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18b2ee9a-57e8-49e0-a197-3123529cba35", "AQAAAAEAACcQAAAAEP9+Rk21v66kKwhOij3A/UJi3rigicD6pP5SEuOHRiHqOxQw4QYRwQG4CLmcXmKk9A==", "5ef74521-4172-43b0-acf7-25a8cbe1b0a9" });
        }
    }
}
