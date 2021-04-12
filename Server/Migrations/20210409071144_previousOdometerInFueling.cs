using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class previousOdometerInFueling : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PreviousOdometer",
                table: "FuelingInfo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "387df01a-846f-4db7-8ff3-c15b1a72143a", "AQAAAAEAACcQAAAAECaR3d3W/r/qcWYHcPw0a2mAZGr7FrU7efXh4N2TqvLlaLSXYKVr6g5TRPilmhmd6A==", "bd2a4bd2-ac63-464f-8d4d-5303a4bb97a6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PreviousOdometer",
                table: "FuelingInfo");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "163b8072-2535-4fa9-9e70-94f4de4e557e", "AQAAAAEAACcQAAAAEBm88kAAnMyBrDVTIgQQVkMJd/TE5zqTWrhpWOfCJlnesRqXmNxqZIqYA6dIcKIcpw==", "d3e7fee6-d443-496d-ba71-47499f655681" });
        }
    }
}
