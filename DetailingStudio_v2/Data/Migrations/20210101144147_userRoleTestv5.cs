using Microsoft.EntityFrameworkCore.Migrations;

namespace DetailingStudio_v2.Migrations
{
    public partial class userRoleTestv5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: "820eaa73-f507-43e3-8b38-0d5efa05e852");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8cafcd44-7597-4d84-836c-253d7cb309a5", 0, "ce20d5aa-85f8-4631-99e3-7c26b7aa7dad", "tester@tester.com", true, false, null, "TesterName", "TESTER@TESTER.COM", "TESTER", "AQAAAAEAACcQAAAAEKeUcqMbDdc/PWA4fe4Dvb5Oz+lOXup9ShTrucbN4QmmgDh9FdF4X4PvPVNiGMVTSQ==", "123456789", false, "4ff326c7-41b0-4eee-ad20-264cd5f28f01", "TesterSurname", false, "tester" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8cafcd44-7597-4d84-836c-253d7cb309a5");

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
    }
}
