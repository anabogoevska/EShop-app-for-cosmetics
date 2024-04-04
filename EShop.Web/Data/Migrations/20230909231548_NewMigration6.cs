using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EShop.Web.Data.Migrations
{
    public partial class NewMigration6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddToShoppingCartDto",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_AddToShoppingCartDto_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AddToShoppingCartDto_ProductId",
                table: "AddToShoppingCartDto",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddToShoppingCartDto");
        }
    }
}
