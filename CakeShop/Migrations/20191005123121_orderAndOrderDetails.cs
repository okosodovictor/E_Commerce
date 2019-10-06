using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CakeShop.Migrations
{
    public partial class orderAndOrderDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_shoppingCartItems_Cakes_CakeId",
                table: "shoppingCartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_shoppingCartItems",
                table: "shoppingCartItems");

            migrationBuilder.RenameTable(
                name: "shoppingCartItems",
                newName: "ShoppingCartItems");

            migrationBuilder.RenameIndex(
                name: "IX_shoppingCartItems_CakeId",
                table: "ShoppingCartItems",
                newName: "IX_ShoppingCartItems_CakeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCartItems",
                table: "ShoppingCartItems",
                column: "ShoppingCartItemId");

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    AddressLine1 = table.Column<string>(maxLength: 100, nullable: false),
                    AddressLine2 = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(maxLength: 10, nullable: false),
                    City = table.Column<string>(maxLength: 50, nullable: false),
                    State = table.Column<string>(maxLength: 10, nullable: true),
                    Country = table.Column<string>(maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 25, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    OrderTotal = table.Column<decimal>(nullable: false),
                    OrderPlaced = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    PieId = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    CakeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Cakes_CakeId",
                        column: x => x.CakeId,
                        principalTable: "Cakes",
                        principalColumn: "CakeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_CakeId",
                table: "OrderDetails",
                column: "CakeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Cakes_CakeId",
                table: "ShoppingCartItems",
                column: "CakeId",
                principalTable: "Cakes",
                principalColumn: "CakeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Cakes_CakeId",
                table: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCartItems",
                table: "ShoppingCartItems");

            migrationBuilder.RenameTable(
                name: "ShoppingCartItems",
                newName: "shoppingCartItems");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCartItems_CakeId",
                table: "shoppingCartItems",
                newName: "IX_shoppingCartItems_CakeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_shoppingCartItems",
                table: "shoppingCartItems",
                column: "ShoppingCartItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_shoppingCartItems_Cakes_CakeId",
                table: "shoppingCartItems",
                column: "CakeId",
                principalTable: "Cakes",
                principalColumn: "CakeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
