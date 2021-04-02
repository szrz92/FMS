using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class XSubRegionCodeInStations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "XRegionCode",
                table: "Stations",
                newName: "XSubRegionCode");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eed56377-12bf-4ccd-8677-79ccc166ed74", "AQAAAAEAACcQAAAAEN5X13KtAe43q8CLd6N04C1nRp6Hc0KfDDgwkolLT3wjCb7qCg1nKZj/CP4Nodh22Q==", "4a830afe-ada5-42c7-b242-6e0fb061eaae" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "XSubRegionCode",
                table: "Stations",
                newName: "XRegionCode");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "656ab03a-b4bb-48ba-a4b0-056472211dd9", "AQAAAAEAACcQAAAAECRyulqOmK1r8+8B2xVIMuOwB6r4HYgKhJRSi8ZEbOPMf3f2ck0LshQtH5MLtO6dfg==", "5af8bd24-e3da-48e9-ad4f-4fe9841b137e" });
        }
    }
}
