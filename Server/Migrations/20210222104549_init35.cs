using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init35 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Station",
                table: "AspNetUsers",
                newName: "SubRegion");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ce32c28-363a-4163-9376-ec936adc304e", "AQAAAAEAACcQAAAAEGcE5aeS1g7bd8XRwuRqwESrYMcO9WEC21sqCA6sMHAiopGWLIiwoeEIsOXHwtDZXg==", "4e798820-3ed2-4ac3-848a-e3d3533a3b57" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SubRegion",
                table: "AspNetUsers",
                newName: "Station");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d40547fc-b4ae-45e7-b11f-04e8d046ad3a", "AQAAAAEAACcQAAAAEIJGu2lF6ikwcApP8/RWPImDSfPZLFLzM1DG0Im39GPj3FoOZ3EMgtl5ZcLbLLTWEg==", "22e0ddea-aa5c-42f8-bb76-11369ffd4c6a" });
        }
    }
}
