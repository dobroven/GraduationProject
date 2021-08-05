using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCoreApp.Migrations
{
    public partial class DishModelFix2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CaloricContent",
                table: "Dish",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Weight",
                table: "Dish",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CaloricContent",
                table: "Dish");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Dish");
        }
    }
}
