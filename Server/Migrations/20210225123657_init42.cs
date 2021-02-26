using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init42 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VehicleConfigurations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Distance = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    PenalityPoints = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleConfigurations", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2eb2d6e9-2e52-4085-a708-654c7411d722", "AQAAAAEAACcQAAAAEPSRuK4BFvaFTC0OtBMtZiI4riVT4qIr8dNauGgipn/RQUmWgUUXiUBeJYfXdkd0RQ==", "dab0249f-4b71-4d59-9532-e7f0a6103266" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VehicleConfigurations");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b21727a-305e-46c5-8f59-00633425556f", "AQAAAAEAACcQAAAAEBU88vzVCq4e1EbugCZbYM4guwSlKqT5emeCfPAC2Z5jX7iA5Fza68S8AB3XmGTVsA==", "92e3d001-864d-4887-9cdc-49a166975646" });
        }
    }
}
