using Microsoft.EntityFrameworkCore.Migrations;

namespace OnCall_Staffing.Migrations
{
    public partial class newcontroller : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cdc2e4b-9478-49d7-9894-0d5803ec36f0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc597bdf-48c4-4aa3-8422-eb2cf524b21a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5b3ec504-01c0-4532-b7d3-810747f97149", "8a08f4f8-bffa-402f-9945-9c34b5666222", "Employer", "EMPLOYER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bf0f0c9c-7015-4a7f-a9e9-39a65e40e177", "51b24f3b-09c3-43e3-b5af-72c2bce26c0b", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b3ec504-01c0-4532-b7d3-810747f97149");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf0f0c9c-7015-4a7f-a9e9-39a65e40e177");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bc597bdf-48c4-4aa3-8422-eb2cf524b21a", "1af47976-5a4c-444b-8114-279facb99041", "Employer", "EMPLOYER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6cdc2e4b-9478-49d7-9894-0d5803ec36f0", "b147e405-908c-4e2d-a4f6-19d80a43218c", "Employee", "EMPLOYEE" });
        }
    }
}
