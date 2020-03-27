using Microsoft.EntityFrameworkCore.Migrations;

namespace OnCall_Staffing.Migrations
{
    public partial class updateModelsprops : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_PostingEmployeeJoin_PostingEmployeeJoinJoinID",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Posting_PostingEmployeeJoin_PostingEmployeeJoinJoinID",
                table: "Posting");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PostingEmployeeJoin",
                table: "PostingEmployeeJoin");

            migrationBuilder.DropIndex(
                name: "IX_PostingEmployeeJoin_PostingID",
                table: "PostingEmployeeJoin");

            migrationBuilder.DropIndex(
                name: "IX_Posting_PostingEmployeeJoinJoinID",
                table: "Posting");

            migrationBuilder.DropIndex(
                name: "IX_Employee_PostingEmployeeJoinJoinID",
                table: "Employee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17618c1f-d180-4cdf-9a4d-0a9e1c4d7051");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0969afd-fadd-4930-822e-230dda81ebbe");

            migrationBuilder.DropColumn(
                name: "JoinID",
                table: "PostingEmployeeJoin");

            migrationBuilder.DropColumn(
                name: "Hired",
                table: "PostingEmployeeJoin");

            migrationBuilder.DropColumn(
                name: "PostingEmployeeJoinJoinID",
                table: "Posting");

            migrationBuilder.DropColumn(
                name: "PostingEmployeeJoinJoinID",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "PostingId",
                table: "Posting",
                newName: "PostingID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostingEmployeeJoin",
                table: "PostingEmployeeJoin",
                columns: new[] { "PostingID", "EmployeeID" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e8db7d5e-2d9e-43d7-a917-f7fe1c8b2ebe", "553c1c72-6316-4939-bd93-71fd71783c34", "Employer", "EMPLOYER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "88da2a03-20dc-4d3e-9f90-97938b0f52b1", "ea53e3a4-ae1f-4cc4-945c-eba572d3e815", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PostingEmployeeJoin",
                table: "PostingEmployeeJoin");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "88da2a03-20dc-4d3e-9f90-97938b0f52b1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e8db7d5e-2d9e-43d7-a917-f7fe1c8b2ebe");

            migrationBuilder.RenameColumn(
                name: "PostingID",
                table: "Posting",
                newName: "PostingId");

            migrationBuilder.AddColumn<int>(
                name: "JoinID",
                table: "PostingEmployeeJoin",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<bool>(
                name: "Hired",
                table: "PostingEmployeeJoin",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "PostingEmployeeJoinJoinID",
                table: "Posting",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PostingEmployeeJoinJoinID",
                table: "Employee",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostingEmployeeJoin",
                table: "PostingEmployeeJoin",
                column: "JoinID");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "17618c1f-d180-4cdf-9a4d-0a9e1c4d7051", "c392101e-7cf3-4914-a8d5-4e755b56c205", "Employer", "EMPLOYER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a0969afd-fadd-4930-822e-230dda81ebbe", "72c97d30-507a-4900-91da-1f440aa1dcdc", "Employee", "EMPLOYEE" });

            migrationBuilder.CreateIndex(
                name: "IX_PostingEmployeeJoin_PostingID",
                table: "PostingEmployeeJoin",
                column: "PostingID");

            migrationBuilder.CreateIndex(
                name: "IX_Posting_PostingEmployeeJoinJoinID",
                table: "Posting",
                column: "PostingEmployeeJoinJoinID");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_PostingEmployeeJoinJoinID",
                table: "Employee",
                column: "PostingEmployeeJoinJoinID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_PostingEmployeeJoin_PostingEmployeeJoinJoinID",
                table: "Employee",
                column: "PostingEmployeeJoinJoinID",
                principalTable: "PostingEmployeeJoin",
                principalColumn: "JoinID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Posting_PostingEmployeeJoin_PostingEmployeeJoinJoinID",
                table: "Posting",
                column: "PostingEmployeeJoinJoinID",
                principalTable: "PostingEmployeeJoin",
                principalColumn: "JoinID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
