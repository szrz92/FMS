using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init36 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CrewDrivers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    VehicleNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DriverName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrewDrivers", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ad616ae-e059-4360-842f-afc7496ef504", "AQAAAAEAACcQAAAAEOxjwQThmmAwwxXXM0uQ0/C/3gqj2rU84iP3LGMGDyUDKrgNwKfQwksNkwpZws4xuw==", "4cdb8e2f-e2d4-47f9-a3a0-d6169de8f998" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CrewDrivers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ce32c28-363a-4163-9376-ec936adc304e", "AQAAAAEAACcQAAAAEGcE5aeS1g7bd8XRwuRqwESrYMcO9WEC21sqCA6sMHAiopGWLIiwoeEIsOXHwtDZXg==", "4e798820-3ed2-4ac3-848a-e3d3533a3b57" });
        }
    }
}
