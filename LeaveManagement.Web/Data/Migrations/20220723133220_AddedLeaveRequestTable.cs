using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00ccdecf-29b0-4dfa-84fc-b75578f68f76",
                column: "ConcurrencyStamp",
                value: "e5b935b0-c64d-4c26-9ec2-ae2ba7bcc55e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6708dd2a-72ae-41dd-83f7-c2bcdaf944d9",
                column: "ConcurrencyStamp",
                value: "d76e639a-b4eb-4a22-a44b-b6ad62ac628e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "54e6a58c-2284-4f33-a8ef-389333f44d2b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4201ea9e-16d8-4461-824c-6e24bdd0f2ef", "AQAAAAEAACcQAAAAEA3aijXkx/SgyZ+fXJeHphGRQKsoPt4jCbWb4s0qTtqeSmaEjDyMd6T2HbSnFNuyzw==", "64740d32-a457-43ff-82a6-e33209a87d30" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77e4cc68-a1b5-4761-bb55-15c1206ec8a6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73f0d827-9ccf-43a5-9b2b-17296ec70f10", "AQAAAAEAACcQAAAAEAQDWEgMFPHmpD1eA1x/SNhKqkzLdPasJgJbWNtMFLYYC/UuAi9L5IUwBJWxdqSsJA==", "94a4613a-bd20-4e53-a45a-c6cb3c4774f5" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00ccdecf-29b0-4dfa-84fc-b75578f68f76",
                column: "ConcurrencyStamp",
                value: "f2ecde89-828e-4333-8164-67c420147356");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6708dd2a-72ae-41dd-83f7-c2bcdaf944d9",
                column: "ConcurrencyStamp",
                value: "5c88bfde-1321-4d31-86d1-9a4765a5403e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "54e6a58c-2284-4f33-a8ef-389333f44d2b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5afcef0-cc2a-4ccb-bbe2-dfc3c7745a8b", "AQAAAAEAACcQAAAAEO306iwOXGtf9nXMHnp8QVsL2YeYnEBv9yX46XHexj1XdnVy8xbPIOf9ao9EGkRg5A==", "3a7f4694-c4a0-4e6d-abb0-56a1735927b0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77e4cc68-a1b5-4761-bb55-15c1206ec8a6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2cdc380e-170a-4d4f-819f-9d31f1a82ec6", "AQAAAAEAACcQAAAAEDYrqPtM8dxbYvD0nnA7VXQI6IBIOVJ43erxvJn33mqWD34rLnuR35+ut51n0X6PhA==", "3e2307f8-7db5-4d1b-894e-8eb0cf6ed2bb" });
        }
    }
}
