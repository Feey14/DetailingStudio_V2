using Microsoft.EntityFrameworkCore.Migrations;

namespace DetailingStudio_v2.Migrations
{
    public partial class userRoleTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "429b6b06-c13d-4665-8489-251fb42050ec");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5addc493-5f3c-4816-9790-7a5b3ed8678b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db5d78a6-be11-4f2f-b4c0-54bb70447166");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "11111", "5833974e-89b7-49ad-92f2-621338717206", "Administrator", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { "774e1b22-0ad3-456a-b5c4-48aa886700ff", 0, "39fa3f18-cf7c-4bad-b5c8-e215b2f98cc7", "tester@tester.com", true, false, null, "TesterName", "TESTER@TESTER.COM", "TESTER", "AQAAAAEAACcQAAAAEFW55BvBjTyfb+KaJwwFrklPZVPSkovN6Tt7fNRyHr5To6+WV0TiAXGkO5eo3Y/0BA==", "123456789", false, "c6966f9b-bf44-48a3-96d0-d5075ea0eefa", "TesterSurname", false, "tester" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11111");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "774e1b22-0ad3-456a-b5c4-48aa886700ff");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "429b6b06-c13d-4665-8489-251fb42050ec", "b78ddff6-cd48-4b64-a0f1-83abfe5023d2", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5addc493-5f3c-4816-9790-7a5b3ed8678b", "42541c0a-48ae-4c7c-852a-13c6c0ac915a", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { "db5d78a6-be11-4f2f-b4c0-54bb70447166", 0, "8e79b170-59c4-463e-a30d-9d5bc9b924ea", "tester@test.com", true, false, null, null, "TESTER@TEST.COM", "TESTER", "AQAAAAEAACcQAAAAEI0VdGkUV1yNZkdkjR98g2hGVR6qEu3NVBAKC367g9Rgw0VgL5EZxaHbQEZHlLXhcw==", "123456789", false, "a7e27ca9-15fe-4660-a92f-c963ae375c59", null, false, "tester" });
        }
    }
}
