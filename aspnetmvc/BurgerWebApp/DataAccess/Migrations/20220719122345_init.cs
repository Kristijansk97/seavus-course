using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Burger",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Burger", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Size",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Size", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BurgerId = table.Column<int>(type: "int", nullable: false),
                    SizeId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuItem_Burger_BurgerId",
                        column: x => x.BurgerId,
                        principalTable: "Burger",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuItem_Size_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Size",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuItemId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItem_MenuItem_MenuItemId",
                        column: x => x.MenuItemId,
                        principalTable: "MenuItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItem_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Burger",
                columns: new[] { "Id", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, "Beef, Cheese, Onion, Tomatoes, Kethcup, Lettuce", "https://www.kitchensanctuary.com/wp-content/uploads/2021/05/Double-Cheeseburger-tall-FS-38.webp", "Cheeseburger" },
                    { 2, "Beef, Cheese, Onion, Tomatoes, Kethcup, Lettuce", "https://www.tastingtable.com/img/gallery/heres-how-hamburgers-got-their-name/intro-1653066580.webp", "Hamburger" },
                    { 3, "Chicken, Onions, Tomatoes, Kethcup, Lettuce", "https://i1.wp.com/gofry.com.fj/wp-content/uploads/2019/04/Chicken_Burger-scaled-e1624614963511.jpg?fit=600%2C583&ssl=1", "Chickenburger" }
                });

            migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "10cm", "S" },
                    { 2, "15cm", "M" },
                    { 3, "20cm", "XL" }
                });

            migrationBuilder.InsertData(
                table: "MenuItem",
                columns: new[] { "Id", "BurgerId", "Price", "SizeId" },
                values: new object[,]
                {
                    { 1, 1, 100, 1 },
                    { 2, 1, 130, 2 },
                    { 3, 1, 150, 3 },
                    { 4, 2, 120, 1 },
                    { 5, 2, 150, 2 },
                    { 6, 2, 170, 3 },
                    { 7, 3, 110, 1 },
                    { 8, 3, 140, 2 },
                    { 9, 3, 180, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MenuItem_BurgerId",
                table: "MenuItem",
                column: "BurgerId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItem_SizeId",
                table: "MenuItem",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_MenuItemId",
                table: "OrderItem",
                column: "MenuItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "MenuItem");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Burger");

            migrationBuilder.DropTable(
                name: "Size");
        }
    }
}
