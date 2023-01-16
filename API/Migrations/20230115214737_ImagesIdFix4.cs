using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class ImagesIdFix4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Products_Productid",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_Productid",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "Productid",
                table: "Images");

            migrationBuilder.CreateTable(
                name: "ImagesProduct",
                columns: table => new
                {
                    imagesid = table.Column<int>(type: "INTEGER", nullable: false),
                    productsid = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagesProduct", x => new { x.imagesid, x.productsid });
                    table.ForeignKey(
                        name: "FK_ImagesProduct_Images_imagesid",
                        column: x => x.imagesid,
                        principalTable: "Images",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ImagesProduct_Products_productsid",
                        column: x => x.productsid,
                        principalTable: "Products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ImagesProduct_productsid",
                table: "ImagesProduct",
                column: "productsid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImagesProduct");

            migrationBuilder.AddColumn<int>(
                name: "Productid",
                table: "Images",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Images_Productid",
                table: "Images",
                column: "Productid");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Products_Productid",
                table: "Images",
                column: "Productid",
                principalTable: "Products",
                principalColumn: "id");
        }
    }
}
