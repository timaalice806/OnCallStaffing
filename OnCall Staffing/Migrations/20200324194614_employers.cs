using Microsoft.EntityFrameworkCore.Migrations;

namespace OnCall_Staffing.Migrations
{
    public partial class employers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b3ec504-01c0-4532-b7d3-810747f97149");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf0f0c9c-7015-4a7f-a9e9-39a65e40e177");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Employer",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Employer",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dd1a9183-6564-42a9-aab3-39312190cdb1", "ad08f6f9-e664-4ab5-a4e2-d73ca7eb7190", "Employer", "EMPLOYER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e7ade9d9-458a-417d-9f69-20235fd6461e", "524ecade-7e71-498d-813d-50535667fb51", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd1a9183-6564-42a9-aab3-39312190cdb1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e7ade9d9-458a-417d-9f69-20235fd6461e");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Employer",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Employer",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5b3ec504-01c0-4532-b7d3-810747f97149", "8a08f4f8-bffa-402f-9945-9c34b5666222", "Employer", "EMPLOYER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bf0f0c9c-7015-4a7f-a9e9-39a65e40e177", "51b24f3b-09c3-43e3-b5af-72c2bce26c0b", "Employee", "EMPLOYEE" });
        }
    }
}
