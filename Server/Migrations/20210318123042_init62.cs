using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init62 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccidentalStatus",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmergencyStatus",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98732ac3-fa85-4154-9559-625ef457c6a9", "AQAAAAEAACcQAAAAELzZYC9PpWmo5g0lUY+hV8cfANx/WxcARAxaAsEo/171xThUdx0oChZXBt83JzGzbA==", "806972ee-b76f-4dcd-8804-fc411109f4e2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccidentalStatus",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "EmergencyStatus",
                table: "Vehicles");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e516c4b3-1c39-401f-8691-eaa19be0121d", "AQAAAAEAACcQAAAAEJhOs6vkXI9q0xNGoFR8pJZfIRGSJFULinsyrx3coL7lmJk1CYi8FF2v3lV7pWBUcg==", "28834d68-7ba6-4b3e-b6f8-a7afd34f3020" });
        }
    }
}
