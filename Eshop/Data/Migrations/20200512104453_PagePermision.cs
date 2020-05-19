using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Eshop.Data.Migrations
{
    public partial class PagePermision : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AddPost",
                table: "Tbl_UserPages",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ControllerName",
                table: "Tbl_UserPages",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "DeletePost",
                table: "Tbl_UserPages",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EditePost",
                table: "Tbl_UserPages",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "PageNameEn",
                table: "Tbl_UserPages",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PageNameFa",
                table: "Tbl_UserPages",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "RoelID",
                table: "Tbl_UserPages",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddPost",
                table: "Tbl_UserPages");

            migrationBuilder.DropColumn(
                name: "ControllerName",
                table: "Tbl_UserPages");

            migrationBuilder.DropColumn(
                name: "DeletePost",
                table: "Tbl_UserPages");

            migrationBuilder.DropColumn(
                name: "EditePost",
                table: "Tbl_UserPages");

            migrationBuilder.DropColumn(
                name: "PageNameEn",
                table: "Tbl_UserPages");

            migrationBuilder.DropColumn(
                name: "PageNameFa",
                table: "Tbl_UserPages");

            migrationBuilder.DropColumn(
                name: "RoelID",
                table: "Tbl_UserPages");
        }
    }
}
