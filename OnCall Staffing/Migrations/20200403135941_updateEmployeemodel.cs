using Microsoft.EntityFrameworkCore.Migrations;

namespace OnCall_Staffing.Migrations
{
    public partial class updateEmployeemodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52ce566c-8819-4b51-aadd-bdbd926b1500");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb674eea-97fa-4eab-b12b-86257fccfaf1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c5f3a861-fb38-4824-9b9c-6d2e632863a6", "4101d09f-dd70-459d-8ec2-6423da9679aa", "Employer", "EMPLOYER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "927721f3-0822-4746-a40f-a5badc9fcd2f", "4caf7845-ac77-4ee9-8d92-950f4ed6614f", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "927721f3-0822-4746-a40f-a5badc9fcd2f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5f3a861-fb38-4824-9b9c-6d2e632863a6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fb674eea-97fa-4eab-b12b-86257fccfaf1", "f08db3a2-0790-4b77-8033-a61e3b0a0f6a", "Employer", "EMPLOYER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "52ce566c-8819-4b51-aadd-bdbd926b1500", "b99cf190-cbf3-434e-9325-27336cce29c8", "Employee", "EMPLOYEE" });
        }
    }
}
