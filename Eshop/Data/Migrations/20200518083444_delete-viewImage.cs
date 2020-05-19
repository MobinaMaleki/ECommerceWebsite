using Microsoft.EntityFrameworkCore.Migrations;

namespace Eshop.Data.Migrations
{
    public partial class deleteviewImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Gallery_Tbl_ViewImage_ViewImageID",
                table: "Tbl_Gallery");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Gallery_ViewImageID",
                table: "Tbl_Gallery");

            migrationBuilder.DropColumn(
                name: "ServerUpload",
                table: "Tbl_Gallery");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Tbl_Gallery");

            migrationBuilder.DropColumn(
                name: "ViewImageID",
                table: "Tbl_Gallery");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ServerUpload",
                table: "Tbl_Gallery",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Tbl_Gallery",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ViewImageID",
                table: "Tbl_Gallery",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Gallery_ViewImageID",
                table: "Tbl_Gallery",
                column: "ViewImageID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Gallery_Tbl_ViewImage_ViewImageID",
                table: "Tbl_Gallery",
                column: "ViewImageID",
                principalTable: "Tbl_ViewImage",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
