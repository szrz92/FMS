using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class testview1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "testview",
                columns: table => new
                {
                    VehicleNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FuelAverage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GasolineType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubRegion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Station = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_testview", x => x.VehicleNumber);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b09b54f3-4463-4c09-8de5-f1177fbed0b9", "AQAAAAEAACcQAAAAEAQbA+IFy61x2ntnsPw5t6InZfoMTxw7G66XyLHfjG2TBHUUoHKAkR5D0CPOzZGI9g==", "b49b37cb-24fc-47ad-a18c-3afe91492c8f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "testview");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b552956c-30f8-4892-ac23-0abb4e43b90d", "AQAAAAEAACcQAAAAEPqGjyWhn7HeDz3YPIN5kcGk006FtbiCV6yrzmNKni5qCKeNw9xO3ipaDlRjAe8zHg==", "7d94d7f9-5e11-45d2-8698-3d7aeaf4f142" });
        }
    }
}
