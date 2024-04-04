using Microsoft.EntityFrameworkCore.Migrations;

namespace EShop.Web.Data.Migrations
{
    public partial class NeMigration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductInShoppingCart_ShoppingCarts_ProductId",
                table: "ProductInShoppingCart");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductInShoppingCart_Products_ShoppingCartId",
                table: "ProductInShoppingCart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductInShoppingCart",
                table: "ProductInShoppingCart");

            migrationBuilder.RenameTable(
                name: "ProductInShoppingCart",
                newName: "ProductInShoppingCarts");

            migrationBuilder.RenameIndex(
                name: "IX_ProductInShoppingCart_ShoppingCartId",
                table: "ProductInShoppingCarts",
                newName: "IX_ProductInShoppingCarts_ShoppingCartId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductInShoppingCarts",
                table: "ProductInShoppingCarts",
                columns: new[] { "ProductId", "ShoppingCartId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInShoppingCarts_ShoppingCarts_ProductId",
                table: "ProductInShoppingCarts",
                column: "ProductId",
                principalTable: "ShoppingCarts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInShoppingCarts_Products_ShoppingCartId",
                table: "ProductInShoppingCarts",
                column: "ShoppingCartId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductInShoppingCarts_ShoppingCarts_ProductId",
                table: "ProductInShoppingCarts");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductInShoppingCarts_Products_ShoppingCartId",
                table: "ProductInShoppingCarts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductInShoppingCarts",
                table: "ProductInShoppingCarts");

            migrationBuilder.RenameTable(
                name: "ProductInShoppingCarts",
                newName: "ProductInShoppingCart");

            migrationBuilder.RenameIndex(
                name: "IX_ProductInShoppingCarts_ShoppingCartId",
                table: "ProductInShoppingCart",
                newName: "IX_ProductInShoppingCart_ShoppingCartId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductInShoppingCart",
                table: "ProductInShoppingCart",
                columns: new[] { "ProductId", "ShoppingCartId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInShoppingCart_ShoppingCarts_ProductId",
                table: "ProductInShoppingCart",
                column: "ProductId",
                principalTable: "ShoppingCarts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInShoppingCart_Products_ShoppingCartId",
                table: "ProductInShoppingCart",
                column: "ShoppingCartId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
