using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init57 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Complaints",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e983d53-aae2-4c8d-8619-90bf6da09023", "AQAAAAEAACcQAAAAEDlvuDhjtrm6ugwnx8BMd1KMV0MaLqbaHPMi0jLRQCghY63FJnTVrFO9QPMwFNXZmA==", "4e8f0cb3-0348-49ee-8644-8b1b1f0d12c6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Complaints");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd4e8ecf-1e64-42e1-8a63-ac875b5d48e4", "AQAAAAEAACcQAAAAEHOmAT1kJJfbj/EuFwJYY2E+/cZOusctcZi7SJlNbu88MYLv/0mDE+u3eui9UZGV7w==", "58949ec0-0314-443e-a5b7-672419662ad2" });
        }
    }
}
