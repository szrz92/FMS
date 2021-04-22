using Microsoft.EntityFrameworkCore.Migrations;

namespace SOS.FMS.Server.Migrations
{
    public partial class AddedRefToEmergencyCheck : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmergencyRef",
                table: "FMSEmergencyCheckList",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Remarks",
                table: "FMSEmergencyCheckList",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AccidentRef",
                table: "FMSAccidentalCheckList",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ref",
                table: "Accidents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e18b3b9-85c1-4a10-b895-5f8420a29ecb", "AQAAAAEAACcQAAAAEN+7GEWXCNLMC+2hiMXg4TVAlG815rRpQeSragcN/2ucZ+gYxpDj+DZHkBMyXCJoPw==", "6b1b2d7f-d660-46bd-97ea-80f6c09411e5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmergencyRef",
                table: "FMSEmergencyCheckList");

            migrationBuilder.DropColumn(
                name: "Remarks",
                table: "FMSEmergencyCheckList");

            migrationBuilder.DropColumn(
                name: "AccidentRef",
                table: "FMSAccidentalCheckList");

            migrationBuilder.DropColumn(
                name: "Ref",
                table: "Accidents");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c58e1a9d-1c28-46db-830a-7b3f0b9663f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d429b6d6-355a-45d2-bbc9-f81546e7c1c2", "AQAAAAEAACcQAAAAEHStjK9rpDMATIO2pMTzSAvybAQZuS4N+9YOv2okYSmU6B3LDAJ25tRd529/HlVPuw==", "b4752184-9472-49f3-aa97-0d3ac2e3e238" });
        }
    }
}
