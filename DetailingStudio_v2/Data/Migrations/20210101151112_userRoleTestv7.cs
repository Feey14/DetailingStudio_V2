using Microsoft.EntityFrameworkCore.Migrations;

namespace DetailingStudio_v2.Migrations
{
    public partial class userRoleTestv7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "774e1b22-0ad3-456a-b5c4-48aa886700ff", "a141dc7f-3170-4c9f-b6e6-3a3856f1b746" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1da9dbbc-b058-47ca-946a-0973a6385ff2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "774e1b22-0ad3-456a-b5c4-48aa886700ff");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "774e1b22-0ad3-456a-b5c4-48aa886700ff", "16364fa5-92ee-41ef-a736-409362d11cc6", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1da9dbbc-b058-47ca-946a-0973a6385ff2", 0, "e079eb94-9f59-41c7-acf6-6bf9cf6e108f", "tester@tester.com", true, true, null, "TesterName", "TESTER@TESTER.COM", "TESTER", "AQAAAAEAACcQAAAAECX+eD8Tw+Xc5km+5Izr5iNMRs3Ki+XmIbCdYZSH0jN8clkvYkQ/snqR2Hhkm2GFhQ==", "123456789", false, "9e813876-341e-4615-a50d-9c54312db9e6", "TesterSurname", false, "tester" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "774e1b22-0ad3-456a-b5c4-48aa886700ff", "a141dc7f-3170-4c9f-b6e6-3a3856f1b746" });
        }
    }
}
