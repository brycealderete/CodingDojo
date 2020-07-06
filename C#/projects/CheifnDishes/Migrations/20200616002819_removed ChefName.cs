using Microsoft.EntityFrameworkCore.Migrations;

namespace CheifnDishes.Migrations
{
    public partial class removedChefName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChefName",
                table: "Dishes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ChefName",
                table: "Dishes",
                nullable: false,
                defaultValue: "");
        }
    }
}
