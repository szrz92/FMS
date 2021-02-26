using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init44 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Score",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Score",
                table: "Drivers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "049db42b-2272-40cb-b818-5bd119433378", "AQAAAAEAACcQAAAAEOZUGAyJDlbG9xxGUpf4haiYDcTt4MBXsxBtNnBP0lB7rQznKNh9kB4GeztZHx9UNg==", "136beed2-143e-471e-a2b6-68c25e6c2e67" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Score",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "Score",
                table: "Drivers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41591ac3-7ea0-4c75-8cfb-bad6fc32809c", "AQAAAAEAACcQAAAAED5MrjunlS3UqRt6403N5XXM5JXeVmckQmxP74sIjbD18pN4MiuCCNqUl8D++IbADg==", "100951a3-a41a-44c8-9218-12500d188952" });
        }
    }
}
