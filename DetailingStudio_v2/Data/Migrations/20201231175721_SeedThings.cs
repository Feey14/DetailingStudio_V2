using Microsoft.EntityFrameworkCore.Migrations;

namespace DetailingStudio_v2.Migrations
{
    public partial class SeedThings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
