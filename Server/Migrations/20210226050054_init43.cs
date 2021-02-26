using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init43 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VehicleSummaries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DriverCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DriverName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssignmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeavingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleSummaries", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41591ac3-7ea0-4c75-8cfb-bad6fc32809c", "AQAAAAEAACcQAAAAED5MrjunlS3UqRt6403N5XXM5JXeVmckQmxP74sIjbD18pN4MiuCCNqUl8D++IbADg==", "100951a3-a41a-44c8-9218-12500d188952" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VehicleSummaries");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2eb2d6e9-2e52-4085-a708-654c7411d722", "AQAAAAEAACcQAAAAEPSRuK4BFvaFTC0OtBMtZiI4riVT4qIr8dNauGgipn/RQUmWgUUXiUBeJYfXdkd0RQ==", "dab0249f-4b71-4d59-9532-e7f0a6103266" });
        }
    }
}
