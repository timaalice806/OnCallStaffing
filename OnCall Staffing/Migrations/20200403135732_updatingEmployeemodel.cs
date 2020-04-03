using Microsoft.EntityFrameworkCore.Migrations;

namespace OnCall_Staffing.Migrations
{
    public partial class updatingEmployeemodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8612bb3c-eb3b-4747-bd0d-db4ce0e75358");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c25a17d9-7195-4a5e-8def-0c14ddeca9a1");

            migrationBuilder.AddColumn<string>(
                name: "Review",
                table: "Employee",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fb674eea-97fa-4eab-b12b-86257fccfaf1", "f08db3a2-0790-4b77-8033-a61e3b0a0f6a", "Employer", "EMPLOYER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "52ce566c-8819-4b51-aadd-bdbd926b1500", "b99cf190-cbf3-434e-9325-27336cce29c8", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52ce566c-8819-4b51-aadd-bdbd926b1500");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb674eea-97fa-4eab-b12b-86257fccfaf1");

            migrationBuilder.DropColumn(
                name: "Review",
                table: "Employee");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8612bb3c-eb3b-4747-bd0d-db4ce0e75358", "c960ce1c-b710-4c40-82e2-193034fc052a", "Employer", "EMPLOYER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c25a17d9-7195-4a5e-8def-0c14ddeca9a1", "1338ce3a-8b75-43db-9f23-c40cb2f7199e", "Employee", "EMPLOYEE" });
        }
    }
}
