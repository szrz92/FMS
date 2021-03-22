using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init63 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CardNumber",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GasolineType",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "497511de-9eee-4530-b8da-1fe4afb0ce88", "AQAAAAEAACcQAAAAEAXHI26PEolYqhMMoO9jsDa+VM9XTRjjzIz7r3vFZoRIwEDw8yCynEw1m29uj+ERZw==", "ffdbda88-d05c-4f33-8708-acae9f5967c1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardNumber",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "GasolineType",
                table: "Vehicles");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98732ac3-fa85-4154-9559-625ef457c6a9", "AQAAAAEAACcQAAAAELzZYC9PpWmo5g0lUY+hV8cfANx/WxcARAxaAsEo/171xThUdx0oChZXBt83JzGzbA==", "806972ee-b76f-4dcd-8804-fc411109f4e2" });
        }
    }
}
