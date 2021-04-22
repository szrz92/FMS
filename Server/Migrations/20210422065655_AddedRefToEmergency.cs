using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class AddedRefToEmergency : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ref",
                table: "Emergencies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0bb70d9e-3013-4ed3-bb76-4d1678943042", "AQAAAAEAACcQAAAAEJPJiEM9N1jqDf6lYIFWHDEI/G6VKYnbtQ2vRpuHWeL84azOy+G8Cbo/NU0k/WQ2SQ==", "914b76a4-730f-4407-bc94-8894951ec6cf" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ref",
                table: "Emergencies");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e1835d8-76e5-413f-a621-db6299256720", "AQAAAAEAACcQAAAAENbAXHFS0GX4JePiq/s2E/SbYhtfgKHDz5yIGqceScQrR1D8+ETg8Ei942gmELVyqg==", "8287231a-f865-49a2-9409-cf53441af3a4" });
        }
    }
}
