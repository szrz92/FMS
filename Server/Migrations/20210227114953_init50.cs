using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init50 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PeriodicStatus",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "039cfe46-9708-4747-9934-938469d2e57f", "AQAAAAEAACcQAAAAEPTp/RJYUzxtOw04eMjtJLGilqkHS/ix6cziaapgcwByLCDzqozCN+pcjeejroOIuQ==", "40677f74-44f2-41fd-933b-57c7ed846d5a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PeriodicStatus",
                table: "Vehicles");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73f7a868-8035-407f-b322-1f2caaa90188", "AQAAAAEAACcQAAAAEBLshyyA4AZhKNeBKXe4nfdIgPGDoyykBYrFUj1QlG2RhdHN4kkPLV4+dR9+1rxi2g==", "aacf597b-a57f-4738-8b89-8e700509ecef" });
        }
    }
}
