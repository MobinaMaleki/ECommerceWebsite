using Microsoft.EntityFrameworkCore.Migrations;

namespace Eshop.Data.Migrations
{
    public partial class CONFIRMEDfIELS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConformMobileCode",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConformMobileCode",
                table: "AspNetUsers");
        }
    }
}
