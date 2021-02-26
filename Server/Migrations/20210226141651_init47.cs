using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init47 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "LastCheckDistance",
                table: "PeriodicHistories",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1270c01b-7775-4e6d-a5e3-280828afdc4b", "AQAAAAEAACcQAAAAEKZ5Ogx8cWRZquZ7UJ+JzyoCpcDOkypIqvfDM8VescxUEXMXG1XhiWf4sf1yGewauA==", "b120eecd-102f-4d9e-9783-daf9dc840f8a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "LastCheckDistance",
                table: "PeriodicHistories",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "386716d7-55ca-4fc4-aa0d-f7e3c66f305c", "AQAAAAEAACcQAAAAEDPaFJv6iiLo9cZl15cOr7/GIZkxwUFG/MQDIRlFBCPDdWC0K8psa2lgVo8quziYeQ==", "5800fbe2-9edf-4e7d-8f8e-0b675ee176e4" });
        }
    }
}
