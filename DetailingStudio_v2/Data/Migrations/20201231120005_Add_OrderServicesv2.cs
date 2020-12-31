using Microsoft.EntityFrameworkCore.Migrations;

namespace DetailingStudio_v2.Migrations
{
    public partial class Add_OrderServicesv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ServicesId",
                table: "OrderServices",
                newName: "ServiceId");

            migrationBuilder.RenameColumn(
                name: "OrdersId",
                table: "OrderServices",
                newName: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderServices_OrderId",
                table: "OrderServices",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderServices_ServiceId",
                table: "OrderServices",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderServices_Orders_OrderId",
                table: "OrderServices",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderServices_Services_ServiceId",
                table: "OrderServices",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderServices_Orders_OrderId",
                table: "OrderServices");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderServices_Services_ServiceId",
                table: "OrderServices");

            migrationBuilder.DropIndex(
                name: "IX_OrderServices_OrderId",
                table: "OrderServices");

            migrationBuilder.DropIndex(
                name: "IX_OrderServices_ServiceId",
                table: "OrderServices");

            migrationBuilder.RenameColumn(
                name: "ServiceId",
                table: "OrderServices",
                newName: "ServicesId");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "OrderServices",
                newName: "OrdersId");
        }
    }
}
