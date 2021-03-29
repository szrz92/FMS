using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init69 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Remarks",
                table: "FMSAccidentalCheckList",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "767b7db0-fe48-4d14-8e79-cc92c4be338d", "AQAAAAEAACcQAAAAENFfxVajGq7Lp9vPNxC/wMCb29dY0/DMWzPMRk8eJeHAyvVMFZIhr/5YIuHt8/5yWg==", "fcf47e9d-1c2a-4d32-ad17-88341d4f2287" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Remarks",
                table: "FMSAccidentalCheckList");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "946629e9-c5d0-4dfa-bc61-e7337842ddd4", "AQAAAAEAACcQAAAAEISnbEgd84vLajveQJgFt9MT2sE0LBa6Aaol+OR3Dq1DUp19KogpEK9HUShhakNRPg==", "8018c466-1502-4173-a63f-ea54a32c3675" });
        }
    }
}
