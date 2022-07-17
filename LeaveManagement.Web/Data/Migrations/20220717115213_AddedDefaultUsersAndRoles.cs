using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "00ccdecf-29b0-4dfa-84fc-b75578f68f76", "c1ade8cd-e413-46c7-bc88-11380e5ed61e", "User", "USER" },
                    { "6708dd2a-72ae-41dd-83f7-c2bcdaf944d9", "05d7d0b7-83bd-46d9-be28-eb3c9e4c6d6d", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "54e6a58c-2284-4f33-a8ef-389333f44d2b", 0, "f0b624dc-2f15-4237-ae9e-0eab14cd69b8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@mail.com", false, "System", "Admin", false, null, "ADMIN@MAIL.COM", null, "AQAAAAEAACcQAAAAEK3L1f/LSRvRrxZ42kgNUl9R+gWopbQk6AMBXtYT0LwHLH1SnVNbniIbVyzDl9dNxg==", null, false, "dfe3e363-09f8-43eb-a06f-6f13d15beea8", null, false, null },
                    { "77e4cc68-a1b5-4761-bb55-15c1206ec8a6", 0, "89e696c4-feb4-4ceb-84d6-25ee6f705fb8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@mail.com", false, "System", "User", false, null, "USER@MAIL.COM", null, "AQAAAAEAACcQAAAAEBttm6QQdkDDtomxPxtOHJITq9pIOe86lWn+NJlf9hDOY7Sz6fHVppqy+0TNUbz5MQ==", null, false, "cd80f0f6-fc53-4768-b3ce-83d7d0dc4022", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6708dd2a-72ae-41dd-83f7-c2bcdaf944d9", "54e6a58c-2284-4f33-a8ef-389333f44d2b" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "00ccdecf-29b0-4dfa-84fc-b75578f68f76", "77e4cc68-a1b5-4761-bb55-15c1206ec8a6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6708dd2a-72ae-41dd-83f7-c2bcdaf944d9", "54e6a58c-2284-4f33-a8ef-389333f44d2b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "00ccdecf-29b0-4dfa-84fc-b75578f68f76", "77e4cc68-a1b5-4761-bb55-15c1206ec8a6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00ccdecf-29b0-4dfa-84fc-b75578f68f76");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6708dd2a-72ae-41dd-83f7-c2bcdaf944d9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "54e6a58c-2284-4f33-a8ef-389333f44d2b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77e4cc68-a1b5-4761-bb55-15c1206ec8a6");
        }
    }
}
