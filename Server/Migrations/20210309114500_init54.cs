using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init54 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Complaints",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PointCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PointCodeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DriverName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complaints", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39f040a0-c5ce-4a9a-9f60-d55b5eb7368e", "AQAAAAEAACcQAAAAEBIxAdWgWkiQ7okQPRBjI2J7eK9qF5Gkufvx3g1vzcPHBeXEtDXjm4CGJtljby+ugQ==", "43cec6b9-9967-464f-b7f7-bf8efa357877" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Complaints");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc3389d0-35ab-4878-a5ce-1852e4226b0a", "AQAAAAEAACcQAAAAEOtXG+mX62rK+0Dy0IxRmuBu5YOL0hK+ocTqytKUrcgFFoJZo2wwchBtsJImPSMdaQ==", "f7c7281e-5c1f-45a5-a440-907b9f81eb94" });
        }
    }
}
