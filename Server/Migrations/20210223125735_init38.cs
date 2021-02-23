using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init38 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CrewDrivers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ee9bc86-fe8f-41c9-9528-888e3172d9f1", "AQAAAAEAACcQAAAAEK0uXwc1yg1yuyXGSwo3ccvPZjrgzizGh3qYzz23M3Aq0dSC+RDlT4fydylpqKatfg==", "bcde8141-e841-4a85-a6d0-3a63dfd7ea57" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CrewDrivers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DriverName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrewDrivers", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2795de4f-9f0d-42bb-87aa-cedd71ac4060", "AQAAAAEAACcQAAAAEL6gx/+USDoCf7IInVpHZevyBQG40FGAZJ02iqW5iJ9yZTxOc8Znf9VY7hnnH6VBKg==", "e4569b38-347b-4804-9a5b-5ec7373841ab" });
        }
    }
}
