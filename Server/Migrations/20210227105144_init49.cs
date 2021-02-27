using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init49 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastCheckMonth",
                table: "PeriodicHistories");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastCheckTime",
                table: "PeriodicHistories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73f7a868-8035-407f-b322-1f2caaa90188", "AQAAAAEAACcQAAAAEBLshyyA4AZhKNeBKXe4nfdIgPGDoyykBYrFUj1QlG2RhdHN4kkPLV4+dR9+1rxi2g==", "aacf597b-a57f-4738-8b89-8e700509ecef" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastCheckTime",
                table: "PeriodicHistories");

            migrationBuilder.AddColumn<int>(
                name: "LastCheckMonth",
                table: "PeriodicHistories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ead1a3de-791c-43c1-a7c9-3c6d51547350", "AQAAAAEAACcQAAAAEAf+dwnPue81P0DpP401n+SRQeq+ckvB6Vl5ZAPkXjrJI1JLtC8g4WF7/pLUAJYjmA==", "97abc198-b498-4e23-8d0d-3a4079b52078" });
        }
    }
}
