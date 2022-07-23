using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class UpdatedRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00ccdecf-29b0-4dfa-84fc-b75578f68f76",
                column: "ConcurrencyStamp",
                value: "b9359ce0-ac50-4bc0-9009-26025431cc0a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6708dd2a-72ae-41dd-83f7-c2bcdaf944d9",
                column: "ConcurrencyStamp",
                value: "5eed2a7a-d7fa-47f1-a806-159b12baaa25");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "54e6a58c-2284-4f33-a8ef-389333f44d2b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41aba596-c0a6-4235-848d-96597faebb10", "AQAAAAEAACcQAAAAEAaCnbTSB22YPZgrrYMMY9DWCTJyNMu8rrfd3hdBmtZDFon3tdT9mBpbht8oxEBrYQ==", "10c84209-bed5-40c0-9799-2494dc7ea55a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77e4cc68-a1b5-4761-bb55-15c1206ec8a6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dabc51b2-c7b4-4a6e-96f5-d4c0cbc74d26", "AQAAAAEAACcQAAAAEF359NODB81w8Q4ie86abuVHI5ImukAeu9wJnW9reBe7g+55fjO0g6IgsZ1xOx7ZSA==", "7865962e-a519-4321-9c9c-b39e62617e1f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
        }
    }
}
