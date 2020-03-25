using Microsoft.EntityFrameworkCore.Migrations;

namespace OnCall_Staffing.Migrations
{
    public partial class inlcudeRateProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4dc0b3cb-6551-4825-a675-48dd12ac8905");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80ce918a-d644-4a6c-8d15-fd6d3a6c3387");

            migrationBuilder.AddColumn<double>(
                name: "Rate",
                table: "Employee",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "17618c1f-d180-4cdf-9a4d-0a9e1c4d7051", "c392101e-7cf3-4914-a8d5-4e755b56c205", "Employer", "EMPLOYER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a0969afd-fadd-4930-822e-230dda81ebbe", "72c97d30-507a-4900-91da-1f440aa1dcdc", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17618c1f-d180-4cdf-9a4d-0a9e1c4d7051");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0969afd-fadd-4930-822e-230dda81ebbe");

            migrationBuilder.DropColumn(
                name: "Rate",
                table: "Employee");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "80ce918a-d644-4a6c-8d15-fd6d3a6c3387", "7d60a6dc-e01e-4491-8849-1a060880081c", "Employer", "EMPLOYER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4dc0b3cb-6551-4825-a675-48dd12ac8905", "55c3e02e-edfe-4a93-84cc-452b4cc4bf6b", "Employee", "EMPLOYEE" });
        }
    }
}
