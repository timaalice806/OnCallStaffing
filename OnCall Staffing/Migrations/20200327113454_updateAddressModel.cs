using Microsoft.EntityFrameworkCore.Migrations;

namespace OnCall_Staffing.Migrations
{
    public partial class updateAddressModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "88da2a03-20dc-4d3e-9f90-97938b0f52b1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e8db7d5e-2d9e-43d7-a917-f7fe1c8b2ebe");

            migrationBuilder.AddColumn<int>(
                name: "Latitude",
                table: "Address",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Longitude",
                table: "Address",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Address",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8612bb3c-eb3b-4747-bd0d-db4ce0e75358", "c960ce1c-b710-4c40-82e2-193034fc052a", "Employer", "EMPLOYER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c25a17d9-7195-4a5e-8def-0c14ddeca9a1", "1338ce3a-8b75-43db-9f23-c40cb2f7199e", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8612bb3c-eb3b-4747-bd0d-db4ce0e75358");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c25a17d9-7195-4a5e-8def-0c14ddeca9a1");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Address");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e8db7d5e-2d9e-43d7-a917-f7fe1c8b2ebe", "553c1c72-6316-4939-bd93-71fd71783c34", "Employer", "EMPLOYER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "88da2a03-20dc-4d3e-9f90-97938b0f52b1", "ea53e3a4-ae1f-4cc4-945c-eba572d3e815", "Employee", "EMPLOYEE" });
        }
    }
}
