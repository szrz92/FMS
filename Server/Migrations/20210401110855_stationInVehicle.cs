using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class stationInVehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Station",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d2d66c3-71fd-4de2-ae12-0ce0191b2b9d", "AQAAAAEAACcQAAAAEDNd4jXtuW2u0Irtx+eVFnisnqC8BYCY6zWFGNDz6yaVseIcbo0uJebPUqjatUyvSQ==", "b9a2ebb9-2d1b-47a6-a908-c8fffbe14195" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Station",
                table: "Vehicles");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c667294-f9ea-4149-9b79-f67f9b9cfa4c", "AQAAAAEAACcQAAAAEI/Rs7khTPc0EzikG/ZD+KJUEvSEkfY1+DV8aqON7qBclAXLcOsPI0JUvqLAziyvTw==", "d47b34e9-f5be-4d75-8d46-b5d75c4108ce" });
        }
    }
}
