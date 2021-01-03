using Microsoft.EntityFrameworkCore.Migrations;

namespace DetailingStudio_v2.Migrations
{
    public partial class userRoleTestv4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: "13b74a8b-8b4b-48b5-9844-2c8bad1bfa32");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { "55cd2e27-e6a8-4627-a7d5-816aa039af6a", 0, "fe3f8136-57a6-4b8a-a0f4-5a3081108cf3", "tester@tester.com", true, false, null, "TesterName", "TESTER@TESTER.COM", "TESTER", "AQAAAAEAACcQAAAAELO+MqqOhR0T5EyrSFzAka6lZaUfa0RVu0IkCdoAGdv68x6ZF5BTZBj2nkTPbmUGyg==", "123456789", false, "1ce4efb0-c4b6-4e18-8abd-7297c2b50c40", "TesterSurname", false, "tester" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55cd2e27-e6a8-4627-a7d5-816aa039af6a");

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
    }
}
