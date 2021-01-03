using Microsoft.EntityFrameworkCore.Migrations;

namespace DetailingStudio_v2.Migrations
{
    public partial class userRoleTestv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "774e1b22-0ad3-456a-b5c4-48aa886700ff", "3cc93652-5eb9-4fab-bb76-46c2a2f806cf", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a141dc7f-3170-4c9f-b6e6-3a3856f1b746", 0, "4426b9b2-022a-4fd2-8613-9e7ffb9bd69d", "tester@tester.com", true, false, null, "TesterName", "TESTER@TESTER.COM", "TESTER", "AQAAAAEAACcQAAAAECCyrdEGaJDcpe+4baljqD6/5PKfSe5BDQnxrVubrbTe5Hd3EorKyfSqNxuF8o0Gbw==", "123456789", false, "afcc7905-ee7e-4287-ad90-7926476537bd", "TesterSurname", false, "tester" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "774e1b22-0ad3-456a-b5c4-48aa886700ff", "a141dc7f-3170-4c9f-b6e6-3a3856f1b746" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "774e1b22-0ad3-456a-b5c4-48aa886700ff", "a141dc7f-3170-4c9f-b6e6-3a3856f1b746" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "774e1b22-0ad3-456a-b5c4-48aa886700ff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a141dc7f-3170-4c9f-b6e6-3a3856f1b746");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "11111", "5833974e-89b7-49ad-92f2-621338717206", "Administrator", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { "774e1b22-0ad3-456a-b5c4-48aa886700ff", 0, "39fa3f18-cf7c-4bad-b5c8-e215b2f98cc7", "tester@tester.com", true, false, null, "TesterName", "TESTER@TESTER.COM", "TESTER", "AQAAAAEAACcQAAAAEFW55BvBjTyfb+KaJwwFrklPZVPSkovN6Tt7fNRyHr5To6+WV0TiAXGkO5eo3Y/0BA==", "123456789", false, "c6966f9b-bf44-48a3-96d0-d5075ea0eefa", "TesterSurname", false, "tester" });
        }
    }
}
