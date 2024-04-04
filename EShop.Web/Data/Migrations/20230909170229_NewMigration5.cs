using Microsoft.EntityFrameworkCore.Migrations;

namespace EShop.Web.Data.Migrations
{
    public partial class NewMigration5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserLoginDto",
                columns: table => new
                {
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    RememberMe = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "UserRegistrationDto",
                columns: table => new
                {
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    ConfirmPassword = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserLoginDto");

            migrationBuilder.DropTable(
                name: "UserRegistrationDto");
        }
    }
}
