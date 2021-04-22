using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class AddedRefToAccidentEmergencyBill : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BillImage",
                table: "EmergencyBills",
                newName: "Ref");

            migrationBuilder.RenameColumn(
                name: "BillImage",
                table: "AccidentBills",
                newName: "Ref");

            migrationBuilder.AddColumn<string>(
                name: "Ref",
                table: "EmergencyBillDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ref",
                table: "AccidentalBillDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d429b6d6-355a-45d2-bbc9-f81546e7c1c2", "AQAAAAEAACcQAAAAEHStjK9rpDMATIO2pMTzSAvybAQZuS4N+9YOv2okYSmU6B3LDAJ25tRd529/HlVPuw==", "b4752184-9472-49f3-aa97-0d3ac2e3e238" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ref",
                table: "EmergencyBillDetails");

            migrationBuilder.DropColumn(
                name: "Ref",
                table: "AccidentalBillDetails");

            migrationBuilder.RenameColumn(
                name: "Ref",
                table: "EmergencyBills",
                newName: "BillImage");

            migrationBuilder.RenameColumn(
                name: "Ref",
                table: "AccidentBills",
                newName: "BillImage");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0bb70d9e-3013-4ed3-bb76-4d1678943042", "AQAAAAEAACcQAAAAEJPJiEM9N1jqDf6lYIFWHDEI/G6VKYnbtQ2vRpuHWeL84azOy+G8Cbo/NU0k/WQ2SQ==", "914b76a4-730f-4407-bc94-8894951ec6cf" });
        }
    }
}
