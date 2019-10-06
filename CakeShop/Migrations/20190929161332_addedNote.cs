using Microsoft.EntityFrameworkCore.Migrations;

namespace CakeShop.Migrations
{
    public partial class addedNote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Cakes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Cakes");
        }
    }
}
