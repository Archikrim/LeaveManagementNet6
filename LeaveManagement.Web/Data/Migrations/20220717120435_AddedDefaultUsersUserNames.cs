using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersUserNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "4ddccdcf-047a-45f5-8734-c3f139fa6142", true, "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEHblUnO+z3Hhe3AwjDJkF/9W7Nd5RlQn56dq+En6C+Z2Nidod5J3dWg0rHu2s2tPqw==", "030c6988-e614-42a2-a549-1ef915b5966b", "admin@mail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77e4cc68-a1b5-4761-bb55-15c1206ec8a6",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "422b0839-7ebf-4a08-aa0e-1079704acfba", true, "USER@MAIL.COM", "AQAAAAEAACcQAAAAEEE9e972Rgmdba6wWpOxy76UU5MVFHzlF9DYMS9qm3N75kKTVXPb0X82HQkRRv3dZg==", "29ec8e21-a985-4daf-b33f-7679f0c431d5", "user@mail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00ccdecf-29b0-4dfa-84fc-b75578f68f76",
                column: "ConcurrencyStamp",
                value: "c1ade8cd-e413-46c7-bc88-11380e5ed61e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6708dd2a-72ae-41dd-83f7-c2bcdaf944d9",
                column: "ConcurrencyStamp",
                value: "05d7d0b7-83bd-46d9-be28-eb3c9e4c6d6d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "54e6a58c-2284-4f33-a8ef-389333f44d2b",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "f0b624dc-2f15-4237-ae9e-0eab14cd69b8", false, null, "AQAAAAEAACcQAAAAEK3L1f/LSRvRrxZ42kgNUl9R+gWopbQk6AMBXtYT0LwHLH1SnVNbniIbVyzDl9dNxg==", "dfe3e363-09f8-43eb-a06f-6f13d15beea8", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77e4cc68-a1b5-4761-bb55-15c1206ec8a6",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "89e696c4-feb4-4ceb-84d6-25ee6f705fb8", false, null, "AQAAAAEAACcQAAAAEBttm6QQdkDDtomxPxtOHJITq9pIOe86lWn+NJlf9hDOY7Sz6fHVppqy+0TNUbz5MQ==", "cd80f0f6-fc53-4768-b3ce-83d7d0dc4022", null });
        }
    }
}
