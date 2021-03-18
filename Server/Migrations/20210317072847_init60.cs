using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init60 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Remarks",
                table: "AccidentBills",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AccidentalBillDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CheckPointId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubServiceType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccidentalBillDetails", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13c2aa9f-8710-4431-9301-e0a8191986c6", "AQAAAAEAACcQAAAAEEzczxGkLA63d64HToArzY6X+FQqY++/hsA8CCFVROhANHciTHCi/Q2bD1DWyqXeIw==", "67b72bbd-5a12-46e0-8926-5e36f8157137" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccidentalBillDetails");

            migrationBuilder.DropColumn(
                name: "Remarks",
                table: "AccidentBills");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6dcb74b1-94c6-4ffe-bdc0-5dc1bc7b4b17", "AQAAAAEAACcQAAAAED2/mtLNs0gXEb8XYMbYwLqPJfHy+BIDo59zViL3U1vgpS4qX3pyCHy2U7qNYhpOHQ==", "493c2869-8b72-4178-8136-f34e3bcdc4ff" });
        }
    }
}
