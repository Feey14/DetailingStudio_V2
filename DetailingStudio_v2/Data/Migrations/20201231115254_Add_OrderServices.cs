using Microsoft.EntityFrameworkCore.Migrations;

namespace DetailingStudio_v2.Migrations
{
    public partial class Add_OrderServices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrderServices",
                columns: table => new
                {
                    OrdersId = table.Column<int>(type: "int", nullable: false),
                    ServicesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderServices");
        }
    }
}
