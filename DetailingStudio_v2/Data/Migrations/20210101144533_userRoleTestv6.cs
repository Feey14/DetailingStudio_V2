using Microsoft.EntityFrameworkCore.Migrations;

namespace DetailingStudio_v2.Migrations
{
    public partial class userRoleTestv6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: "16364fa5-92ee-41ef-a736-409362d11cc6");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1da9dbbc-b058-47ca-946a-0973a6385ff2", 0, "e079eb94-9f59-41c7-acf6-6bf9cf6e108f", "tester@tester.com", true, true, null, "TesterName", "TESTER@TESTER.COM", "TESTER", "AQAAAAEAACcQAAAAECX+eD8Tw+Xc5km+5Izr5iNMRs3Ki+XmIbCdYZSH0jN8clkvYkQ/snqR2Hhkm2GFhQ==", "123456789", false, "9e813876-341e-4615-a50d-9c54312db9e6", "TesterSurname", false, "tester" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1da9dbbc-b058-47ca-946a-0973a6385ff2");

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
    }
}
