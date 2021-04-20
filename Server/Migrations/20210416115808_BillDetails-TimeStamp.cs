using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class BillDetailsTimeStamp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Timestamp",
                table: "BillDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e1835d8-76e5-413f-a621-db6299256720", "AQAAAAEAACcQAAAAENbAXHFS0GX4JePiq/s2E/SbYhtfgKHDz5yIGqceScQrR1D8+ETg8Ei942gmELVyqg==", "8287231a-f865-49a2-9409-cf53441af3a4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "BillDetails");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9987bc8e-7f86-454b-a242-b37adeef3b6f", "AQAAAAEAACcQAAAAEMaVt+OKBidgCayiLlvyEueoEtdijAPPH01g+lDeNrxwDUorzt4+2CXbjob+0Dvbng==", "bcbef37f-775e-4488-bec4-8c574583a453" });
        }
    }
}
