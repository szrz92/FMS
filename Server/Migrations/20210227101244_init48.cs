using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init48 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Timestamp",
                table: "PeriodicHistories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ead1a3de-791c-43c1-a7c9-3c6d51547350", "AQAAAAEAACcQAAAAEAf+dwnPue81P0DpP401n+SRQeq+ckvB6Vl5ZAPkXjrJI1JLtC8g4WF7/pLUAJYjmA==", "97abc198-b498-4e23-8d0d-3a4079b52078" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "PeriodicHistories");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1270c01b-7775-4e6d-a5e3-280828afdc4b", "AQAAAAEAACcQAAAAEKZ5Ogx8cWRZquZ7UJ+JzyoCpcDOkypIqvfDM8VescxUEXMXG1XhiWf4sf1yGewauA==", "b120eecd-102f-4d9e-9783-daf9dc840f8a" });
        }
    }
}
