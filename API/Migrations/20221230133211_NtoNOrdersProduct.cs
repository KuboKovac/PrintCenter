using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class NtoNOrdersProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Orderhistory_OrderHistoryid",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_OrderHistoryid",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "OrderHistoryid",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "OrderHistoryProduct",
                columns: table => new
                {
                    Productsid = table.Column<int>(type: "INTEGER", nullable: false),
                    orderHistoriesid = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderHistoryProduct", x => new { x.Productsid, x.orderHistoriesid });
                    table.ForeignKey(
                        name: "FK_OrderHistoryProduct_Orderhistory_orderHistoriesid",
                        column: x => x.orderHistoriesid,
                        principalTable: "Orderhistory",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderHistoryProduct_Products_Productsid",
                        column: x => x.Productsid,
                        principalTable: "Products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderHistoryProduct_orderHistoriesid",
                table: "OrderHistoryProduct",
                column: "orderHistoriesid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderHistoryProduct");

            migrationBuilder.AddColumn<int>(
                name: "OrderHistoryid",
                table: "Products",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_OrderHistoryid",
                table: "Products",
                column: "OrderHistoryid");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Orderhistory_OrderHistoryid",
                table: "Products",
                column: "OrderHistoryid",
                principalTable: "Orderhistory",
                principalColumn: "id");
        }
    }
}
