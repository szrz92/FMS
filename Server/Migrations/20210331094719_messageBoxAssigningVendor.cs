using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class messageBoxAssigningVendor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4648d5d-37b6-42f9-9e20-552e205a7f8f", "AQAAAAEAACcQAAAAEDgvQEYZ2zo8Qg+JPjBRuy/SGy1+jtND+wDruyg7Jv6e824uOKwWyopJ8bF4YDD6dQ==", "4ae090d9-63dc-4394-b67c-42f6d3655b15" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39d5a145-7839-4a87-a831-b5684070bee2", "AQAAAAEAACcQAAAAENdU1vxnoffY1vunlKWblqkKMfLraRrakHS2pQa/t3ya6e97PxgMIvrZygntjPk6BA==", "1185adde-47e1-43ff-93aa-42e52f47f43f" });
        }
    }
}
