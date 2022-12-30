using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class ProductRelationsFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductBrands_brandid",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductCategories_categoryid",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "categoryid",
                table: "Products",
                newName: "categoryId");

            migrationBuilder.RenameColumn(
                name: "brandid",
                table: "Products",
                newName: "brandId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_categoryid",
                table: "Products",
                newName: "IX_Products_categoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_brandid",
                table: "Products",
                newName: "IX_Products_brandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductBrands_brandId",
                table: "Products",
                column: "brandId",
                principalTable: "ProductBrands",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductCategories_categoryId",
                table: "Products",
                column: "categoryId",
                principalTable: "ProductCategories",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductBrands_brandId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductCategories_categoryId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "categoryId",
                table: "Products",
                newName: "categoryid");

            migrationBuilder.RenameColumn(
                name: "brandId",
                table: "Products",
                newName: "brandid");

            migrationBuilder.RenameIndex(
                name: "IX_Products_categoryId",
                table: "Products",
                newName: "IX_Products_categoryid");

            migrationBuilder.RenameIndex(
                name: "IX_Products_brandId",
                table: "Products",
                newName: "IX_Products_brandid");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductBrands_brandid",
                table: "Products",
                column: "brandid",
                principalTable: "ProductBrands",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductCategories_categoryid",
                table: "Products",
                column: "categoryid",
                principalTable: "ProductCategories",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
