using Microsoft.EntityFrameworkCore.Migrations;

namespace EShop.Web.Data.Migrations
{
    public partial class addProductQuantity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductQuantity",
                table: "Products",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductQuantity",
                table: "Products");
        }
    }
}
