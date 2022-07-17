using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00ccdecf-29b0-4dfa-84fc-b75578f68f76",
                column: "ConcurrencyStamp",
                value: "73780beb-17e8-4db1-b99f-de1a4a841f6b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6708dd2a-72ae-41dd-83f7-c2bcdaf944d9",
                column: "ConcurrencyStamp",
                value: "4728481f-b9ac-4037-8452-eb592a5edead");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "54e6a58c-2284-4f33-a8ef-389333f44d2b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ddccdcf-047a-45f5-8734-c3f139fa6142", "AQAAAAEAACcQAAAAEHblUnO+z3Hhe3AwjDJkF/9W7Nd5RlQn56dq+En6C+Z2Nidod5J3dWg0rHu2s2tPqw==", "030c6988-e614-42a2-a549-1ef915b5966b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77e4cc68-a1b5-4761-bb55-15c1206ec8a6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "422b0839-7ebf-4a08-aa0e-1079704acfba", "AQAAAAEAACcQAAAAEEE9e972Rgmdba6wWpOxy76UU5MVFHzlF9DYMS9qm3N75kKTVXPb0X82HQkRRv3dZg==", "29ec8e21-a985-4daf-b33f-7679f0c431d5" });
        }
    }
}
