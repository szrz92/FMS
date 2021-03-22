using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init65 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FuelingInfo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VehicleNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DriverName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Litres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FillingStation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FillingCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Odometer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Milage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelingInfo", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "889a4256-4c22-45c3-9d48-9b49d6af9c6c", "AQAAAAEAACcQAAAAEF5aBv9U8+vFKIMH2JXZTLlrW5GOBDx8inB1NVUteJuz5xeRb+rea2rN2sfpVvNy8A==", "860e1428-703d-475d-aff9-6c49fcbcd9c1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FuelingInfo");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9621cf15-8edc-4a86-9f28-530efe312849", "AQAAAAEAACcQAAAAEB5ZuMcMPyIdWlzTnryFVivcS+9iwSWiCtU6cI2FIpBoS7l6pLwVQ+lmaRrsbMYZ4Q==", "ae72a0b5-a38e-4fa6-98c2-0d28e00df2b5" });
        }
    }
}
