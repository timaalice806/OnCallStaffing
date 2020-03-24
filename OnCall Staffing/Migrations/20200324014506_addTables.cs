using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnCall_Staffing.Migrations
{
    public partial class addTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4cafb3a6-bb74-4320-a8e0-c29c6b8d6323");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b7df65e2-9595-49d1-b032-7d9c502f7a72");

            migrationBuilder.AddColumn<int>(
                name: "PostingEmployeeJoinJoinID",
                table: "Employee",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    AddressID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StreetAddress = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AddressID);
                });

            migrationBuilder.CreateTable(
                name: "Posting",
                columns: table => new
                {
                    PostingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionTitle = table.Column<string>(nullable: false),
                    Facility = table.Column<string>(nullable: false),
                    DateTime = table.Column<DateTime>(nullable: false),
                    PayRate = table.Column<string>(nullable: false),
                    PositionDescription = table.Column<string>(nullable: false),
                    ArrivalInstructions = table.Column<string>(nullable: false),
                    AddressID = table.Column<int>(nullable: false),
                    EmployerID = table.Column<int>(nullable: false),
                    PostingEmployeeJoinJoinID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posting", x => x.PostingId);
                    table.ForeignKey(
                        name: "FK_Posting_Address_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Address",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Posting_Employer_EmployerID",
                        column: x => x.EmployerID,
                        principalTable: "Employer",
                        principalColumn: "EmployerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostingEmployeeJoin",
                columns: table => new
                {
                    JoinID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostingID = table.Column<int>(nullable: false),
                    EmployeeID = table.Column<int>(nullable: false),
                    Hired = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostingEmployeeJoin", x => x.JoinID);
                    table.ForeignKey(
                        name: "FK_PostingEmployeeJoin_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostingEmployeeJoin_Posting_PostingID",
                        column: x => x.PostingID,
                        principalTable: "Posting",
                        principalColumn: "PostingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bc597bdf-48c4-4aa3-8422-eb2cf524b21a", "1af47976-5a4c-444b-8114-279facb99041", "Employer", "EMPLOYER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6cdc2e4b-9478-49d7-9894-0d5803ec36f0", "b147e405-908c-4e2d-a4f6-19d80a43218c", "Employee", "EMPLOYEE" });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_PostingEmployeeJoinJoinID",
                table: "Employee",
                column: "PostingEmployeeJoinJoinID");

            migrationBuilder.CreateIndex(
                name: "IX_Posting_AddressID",
                table: "Posting",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_Posting_EmployerID",
                table: "Posting",
                column: "EmployerID");

            migrationBuilder.CreateIndex(
                name: "IX_Posting_PostingEmployeeJoinJoinID",
                table: "Posting",
                column: "PostingEmployeeJoinJoinID");

            migrationBuilder.CreateIndex(
                name: "IX_PostingEmployeeJoin_EmployeeID",
                table: "PostingEmployeeJoin",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_PostingEmployeeJoin_PostingID",
                table: "PostingEmployeeJoin",
                column: "PostingID");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_PostingEmployeeJoin_PostingEmployeeJoinJoinID",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Posting_Address_AddressID",
                table: "Posting");

            migrationBuilder.DropForeignKey(
                name: "FK_Posting_PostingEmployeeJoin_PostingEmployeeJoinJoinID",
                table: "Posting");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "PostingEmployeeJoin");

            migrationBuilder.DropTable(
                name: "Posting");

            migrationBuilder.DropIndex(
                name: "IX_Employee_PostingEmployeeJoinJoinID",
                table: "Employee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cdc2e4b-9478-49d7-9894-0d5803ec36f0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc597bdf-48c4-4aa3-8422-eb2cf524b21a");

            migrationBuilder.DropColumn(
                name: "PostingEmployeeJoinJoinID",
                table: "Employee");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b7df65e2-9595-49d1-b032-7d9c502f7a72", "722e90bb-e97f-4e22-8d68-074cbbfb4bf5", "Employer", "EMPLOYER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4cafb3a6-bb74-4320-a8e0-c29c6b8d6323", "c647b1b8-43d7-4e9d-a7fe-8cf71224f8f4", "Employee", "EMPLOYEE" });
        }
    }
}
