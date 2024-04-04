using Microsoft.EntityFrameworkCore.Migrations;

namespace EShop.Web.Data.Migrations
{
    public partial class NewMigration9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_AspNetUsers_MyPropertyId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_MyPropertyId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "MyPropertyId",
                table: "Order");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Order",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserId",
                table: "Order",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_AspNetUsers_UserId",
                table: "Order",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_AspNetUsers_UserId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_UserId",
                table: "Order");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MyPropertyId",
                table: "Order",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Order_MyPropertyId",
                table: "Order",
                column: "MyPropertyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_AspNetUsers_MyPropertyId",
                table: "Order",
                column: "MyPropertyId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
