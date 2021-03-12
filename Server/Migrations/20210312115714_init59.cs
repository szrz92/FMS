using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init59 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OdometerIn",
                table: "DailyMorningChecks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OdometerOut",
                table: "DailyMorningChecks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OdometerIn",
                table: "DailyEveningChecks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OdometerOut",
                table: "DailyEveningChecks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6dcb74b1-94c6-4ffe-bdc0-5dc1bc7b4b17", "AQAAAAEAACcQAAAAED2/mtLNs0gXEb8XYMbYwLqPJfHy+BIDo59zViL3U1vgpS4qX3pyCHy2U7qNYhpOHQ==", "493c2869-8b72-4178-8136-f34e3bcdc4ff" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OdometerIn",
                table: "DailyMorningChecks");

            migrationBuilder.DropColumn(
                name: "OdometerOut",
                table: "DailyMorningChecks");

            migrationBuilder.DropColumn(
                name: "OdometerIn",
                table: "DailyEveningChecks");

            migrationBuilder.DropColumn(
                name: "OdometerOut",
                table: "DailyEveningChecks");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e09012d1-8215-45cc-9f89-24d2c9afeb1c", "AQAAAAEAACcQAAAAEKgoADIezcBER66bfr2rp0DTKAmHh5izYBh0WEvZuSf/rBAGdv6zBUg9C0GR+JEQ1w==", "5ebe79ea-1beb-4caf-91d4-616b34227670" });
        }
    }
}
