using Microsoft.EntityFrameworkCore.Migrations;

namespace Eshop.Data.Migrations
{
    public partial class changedb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Manufacturer",
                table: "Tbl_TechnicalsDetails");

            migrationBuilder.DropColumn(
                name: "ManufacturerCountry",
                table: "Tbl_TechnicalsDetails");

            migrationBuilder.AddColumn<string>(
                name: "Factory",
                table: "Tbl_TechnicalsDetails",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MadeIn",
                table: "Tbl_TechnicalsDetails",
                maxLength: 100,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Factory",
                table: "Tbl_TechnicalsDetails");

            migrationBuilder.DropColumn(
                name: "MadeIn",
                table: "Tbl_TechnicalsDetails");

            migrationBuilder.AddColumn<string>(
                name: "Manufacturer",
                table: "Tbl_TechnicalsDetails",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ManufacturerCountry",
                table: "Tbl_TechnicalsDetails",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);
        }
    }
}
