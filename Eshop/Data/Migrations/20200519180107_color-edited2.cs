using Microsoft.EntityFrameworkCore.Migrations;

namespace Eshop.Data.Migrations
{
    public partial class coloredited2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_ProductColors_Tbl_Products_ProductsID",
                table: "Tbl_ProductColors");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_ProductColors_ProductsID",
                table: "Tbl_ProductColors");

            migrationBuilder.DropColumn(
                name: "ProductsID",
                table: "Tbl_ProductColors");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductsID",
                table: "Tbl_ProductColors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_ProductColors_ProductsID",
                table: "Tbl_ProductColors",
                column: "ProductsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_ProductColors_Tbl_Products_ProductsID",
                table: "Tbl_ProductColors",
                column: "ProductsID",
                principalTable: "Tbl_Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
