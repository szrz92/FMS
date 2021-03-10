using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init55 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ComplaintDescription",
                table: "Complaints",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a25f580e-d89b-46d9-8a25-cc0eb03d54df", "AQAAAAEAACcQAAAAENUHL8mxEasBnukdUbxSeeuWRHDaRiVEn5L0w9gMj+Z0G5pwaOfwuZxTDueqX6sV4Q==", "e294de0d-6c3e-40be-a3e9-1a4fafbbf36c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ComplaintDescription",
                table: "Complaints");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39f040a0-c5ce-4a9a-9f60-d55b5eb7368e", "AQAAAAEAACcQAAAAEBIxAdWgWkiQ7okQPRBjI2J7eK9qF5Gkufvx3g1vzcPHBeXEtDXjm4CGJtljby+ugQ==", "43cec6b9-9967-464f-b7f7-bf8efa357877" });
        }
    }
}
