using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class init64 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ComplaintDescription",
                table: "Complaints",
                newName: "Resolution");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Complaints",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9621cf15-8edc-4a86-9f28-530efe312849", "AQAAAAEAACcQAAAAEB5ZuMcMPyIdWlzTnryFVivcS+9iwSWiCtU6cI2FIpBoS7l6pLwVQ+lmaRrsbMYZ4Q==", "ae72a0b5-a38e-4fa6-98c2-0d28e00df2b5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Complaints");

            migrationBuilder.RenameColumn(
                name: "Resolution",
                table: "Complaints",
                newName: "ComplaintDescription");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "497511de-9eee-4530-b8da-1fe4afb0ce88", "AQAAAAEAACcQAAAAEAXHI26PEolYqhMMoO9jsDa+VM9XTRjjzIz7r3vFZoRIwEDw8yCynEw1m29uj+ERZw==", "ffdbda88-d05c-4f33-8708-acae9f5967c1" });
        }
    }
}
