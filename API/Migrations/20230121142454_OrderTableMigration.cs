using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class OrderTableMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orderhistory_Users_userId",
                table: "Orderhistory");

            migrationBuilder.DropIndex(
                name: "IX_Orderhistory_userId",
                table: "Orderhistory");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "Orderhistory",
                newName: "apartmentNo");

            migrationBuilder.AddColumn<string>(
                name: "address",
                table: "Orderhistory",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "country",
                table: "Orderhistory",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Orderhistory",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "fName",
                table: "Orderhistory",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "lName",
                table: "Orderhistory",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "number",
                table: "Orderhistory",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "postalCode",
                table: "Orderhistory",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "province",
                table: "Orderhistory",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "address",
                table: "Orderhistory");

            migrationBuilder.DropColumn(
                name: "country",
                table: "Orderhistory");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Orderhistory");

            migrationBuilder.DropColumn(
                name: "fName",
                table: "Orderhistory");

            migrationBuilder.DropColumn(
                name: "lName",
                table: "Orderhistory");

            migrationBuilder.DropColumn(
                name: "number",
                table: "Orderhistory");

            migrationBuilder.DropColumn(
                name: "postalCode",
                table: "Orderhistory");

            migrationBuilder.DropColumn(
                name: "province",
                table: "Orderhistory");

            migrationBuilder.RenameColumn(
                name: "apartmentNo",
                table: "Orderhistory",
                newName: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_Orderhistory_userId",
                table: "Orderhistory",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orderhistory_Users_userId",
                table: "Orderhistory",
                column: "userId",
                principalTable: "Users",
                principalColumn: "userId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
