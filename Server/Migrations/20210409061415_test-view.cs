using Microsoft.EntityFrameworkCore.Migrations;
using SOS.FMS.Server.Models;

namespace SOS.FMS.Server.Migrations
{
    public partial class testview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string script =
           @"
            CREATE VIEW dbo.testview AS 
            SELECT A.VehicleNumber, A.FuelAverage, A.GasolineType, A.Region , A.SubRegion, A.Station ,  B.Make, B.Model, B.VehicleType
            FROM [SOSFMS].[dbo].[Vehicles] A
            INNER JOIN GBMSVehicles B ON A.VehicleNumber = B.Description";
            migrationBuilder.Sql(script);
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b552956c-30f8-4892-ac23-0abb4e43b90d", "AQAAAAEAACcQAAAAEPqGjyWhn7HeDz3YPIN5kcGk006FtbiCV6yrzmNKni5qCKeNw9xO3ipaDlRjAe8zHg==", "7d94d7f9-5e11-45d2-8698-3d7aeaf4f142" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW dbo.testview");
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "163b8072-2535-4fa9-9e70-94f4de4e557e", "AQAAAAEAACcQAAAAEBm88kAAnMyBrDVTIgQQVkMJd/TE5zqTWrhpWOfCJlnesRqXmNxqZIqYA6dIcKIcpw==", "d3e7fee6-d443-496d-ba71-47499f655681" });
        }
    }
}
