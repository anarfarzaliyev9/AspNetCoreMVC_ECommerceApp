using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce_API.Migrations
{
    public partial class test23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMain",
                table: "Products");

            migrationBuilder.AddColumn<bool>(
                name: "IsFeatured",
                table: "Products",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsNewArrival",
                table: "Products",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFeatured",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsNewArrival",
                table: "Products");

            migrationBuilder.AddColumn<bool>(
                name: "IsMain",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
