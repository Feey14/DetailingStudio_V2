using Microsoft.EntityFrameworkCore.Migrations;

namespace DetailingStudio_v2.Migrations
{
    public partial class userRoleTestv3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a141dc7f-3170-4c9f-b6e6-3a3856f1b746");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "774e1b22-0ad3-456a-b5c4-48aa886700ff",
                column: "ConcurrencyStamp",
                value: "e908530c-1507-4f9c-9f9c-e6437448e99b");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { "867c775e-2ffa-40cf-b589-4ebbd72ba033", 0, "00afc150-a64f-45cf-ae58-b7689861cdac", "tester@tester.com", true, false, null, "TesterName", "TESTER@TESTER.COM", "TESTER", "AQAAAAEAACcQAAAAEE+eIDy4HFYcRXPgeRcur1mlE6YoLZShDkXOBdl4RbsI7cDsT3V86cAiVhjTSd8BTQ==", "123456789", false, "8e9c37b3-fcf0-45cc-9bc1-1a1bc29da4f9", "TesterSurname", false, "tester" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "867c775e-2ffa-40cf-b589-4ebbd72ba033");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "774e1b22-0ad3-456a-b5c4-48aa886700ff",
                column: "ConcurrencyStamp",
                value: "3cc93652-5eb9-4fab-bb76-46c2a2f806cf");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a141dc7f-3170-4c9f-b6e6-3a3856f1b746", 0, "4426b9b2-022a-4fd2-8613-9e7ffb9bd69d", "tester@tester.com", true, false, null, "TesterName", "TESTER@TESTER.COM", "TESTER", "AQAAAAEAACcQAAAAECCyrdEGaJDcpe+4baljqD6/5PKfSe5BDQnxrVubrbTe5Hd3EorKyfSqNxuF8o0Gbw==", "123456789", false, "afcc7905-ee7e-4287-ad90-7926476537bd", "TesterSurname", false, "tester" });
        }
    }
}
