using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class stationInVehicleVM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c667294-f9ea-4149-9b79-f67f9b9cfa4c", "AQAAAAEAACcQAAAAEI/Rs7khTPc0EzikG/ZD+KJUEvSEkfY1+DV8aqON7qBclAXLcOsPI0JUvqLAziyvTw==", "d47b34e9-f5be-4d75-8d46-b5d75c4108ce" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eed56377-12bf-4ccd-8677-79ccc166ed74", "AQAAAAEAACcQAAAAEN5X13KtAe43q8CLd6N04C1nRp6Hc0KfDDgwkolLT3wjCb7qCg1nKZj/CP4Nodh22Q==", "4a830afe-ada5-42c7-b242-6e0fb061eaae" });
        }
    }
}
