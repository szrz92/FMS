using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class billposting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccidentBills",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CheckPointId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BillAmount = table.Column<double>(type: "float", nullable: false),
                    BillImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccidentBills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmergencyBills",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CheckPointId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BillAmount = table.Column<double>(type: "float", nullable: false),
                    BillImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmergencyBills", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77deebab-699b-4f6c-b7c5-395118a605b3", "AQAAAAEAACcQAAAAEMx8Qmktp/sL9u13ErALVJIEyAI7BYZWMQBOAi9jQ43O7g/coWFdMEWnkS7j3eKqgQ==", "ec0399c3-4372-4108-8069-e84f74139d59" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccidentBills");

            migrationBuilder.DropTable(
                name: "EmergencyBills");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "049db42b-2272-40cb-b818-5bd119433378", "AQAAAAEAACcQAAAAEOZUGAyJDlbG9xxGUpf4haiYDcTt4MBXsxBtNnBP0lB7rQznKNh9kB4GeztZHx9UNg==", "136beed2-143e-471e-a2b6-68c25e6c2e67" });
        }
    }
}
