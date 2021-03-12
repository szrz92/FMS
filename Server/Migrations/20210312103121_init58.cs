using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init58 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ResolutionTime",
                table: "Complaints",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e09012d1-8215-45cc-9f89-24d2c9afeb1c", "AQAAAAEAACcQAAAAEKgoADIezcBER66bfr2rp0DTKAmHh5izYBh0WEvZuSf/rBAGdv6zBUg9C0GR+JEQ1w==", "5ebe79ea-1beb-4caf-91d4-616b34227670" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResolutionTime",
                table: "Complaints");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e983d53-aae2-4c8d-8619-90bf6da09023", "AQAAAAEAACcQAAAAEDlvuDhjtrm6ugwnx8BMd1KMV0MaLqbaHPMi0jLRQCghY63FJnTVrFO9QPMwFNXZmA==", "4e8f0cb3-0348-49ee-8644-8b1b1f0d12c6" });
        }
    }
}
