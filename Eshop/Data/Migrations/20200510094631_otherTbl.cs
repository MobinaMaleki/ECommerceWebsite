using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Eshop.Data.Migrations
{
    public partial class otherTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Tbl_Article",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 150, nullable: false),
                    View = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: false),
                    Text = table.Column<string>(nullable: false),
                    PictureName = table.Column<string>(nullable: true),
                    InsertedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Article", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Category",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 150, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    InsertedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Category", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_OtherServer",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsertedDate = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    IP = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    HttpDomain = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_OtherServer", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Settings",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsertedDate = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(maxLength: 150, nullable: false),
                    Title = table.Column<string>(maxLength: 75, nullable: false),
                    PageNumber = table.Column<int>(nullable: false),
                    Smtp = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    SmsService = table.Column<string>(nullable: false),
                    SmsUser = table.Column<string>(nullable: false),
                    SmsPassword = table.Column<string>(nullable: false),
                    Telegram = table.Column<string>(nullable: true),
                    Instagram = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Settings", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_UserPages",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsertedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_UserPages", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Weight",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsertedDate = table.Column<DateTime>(nullable: false),
                    Weight_Max = table.Column<int>(nullable: true),
                    Weight_Min = table.Column<int>(nullable: true),
                    Weight_Price = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Weight", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Products",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsertedDate = table.Column<DateTime>(nullable: false),
                    CodeProduct = table.Column<string>(maxLength: 20, nullable: false),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    CategoryId = table.Column<int>(nullable: true),
                    Visit = table.Column<int>(nullable: false),
                    Price = table.Column<string>(maxLength: 12, nullable: false),
                    DiscountPercent = table.Column<int>(nullable: true),
                    DiscountedPrice = table.Column<string>(maxLength: 12, nullable: false),
                    ActiveInactive = table.Column<bool>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Stock = table.Column<int>(nullable: false),
                    Decrption = table.Column<string>(nullable: false),
                    Wieght = table.Column<int>(nullable: false),
                    UserID = table.Column<string>(nullable: true),
                    IsServerUpload = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Tbl_Products_Tbl_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Tbl_Category",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tbl_Products_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Comments",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsertedDate = table.Column<DateTime>(nullable: false),
                    ProductID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    NameFamily = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Text = table.Column<string>(maxLength: 240, nullable: false),
                    IP = table.Column<string>(nullable: false),
                    Confirm = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Comments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Tbl_Comments_Tbl_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Tbl_Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Invoce",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsertedDate = table.Column<DateTime>(nullable: false),
                    Userid = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    Count = table.Column<int>(nullable: false),
                    InvoiceId = table.Column<int>(nullable: false),
                    Price = table.Column<string>(maxLength: 15, nullable: false),
                    AmountSent = table.Column<string>(maxLength: 15, nullable: false),
                    Tax = table.Column<string>(maxLength: 15, nullable: false),
                    TransactionID = table.Column<string>(maxLength: 100, nullable: true),
                    ReferenceID = table.Column<string>(maxLength: 100, nullable: true),
                    Productid = table.Column<int>(nullable: false),
                    ProductCode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Invoce", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Tbl_Invoce_Tbl_Products_Productid",
                        column: x => x.Productid,
                        principalTable: "Tbl_Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tbl_Invoce_AspNetUsers_Userid",
                        column: x => x.Userid,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_ProductColors",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsertedDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    ColorCode = table.Column<string>(nullable: false),
                    ProductID = table.Column<int>(nullable: false),
                    ProductsID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_ProductColors", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Tbl_ProductColors_Tbl_Products_ProductsID",
                        column: x => x.ProductsID,
                        principalTable: "Tbl_Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_ShoppingCart",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsertedDate = table.Column<DateTime>(nullable: false),
                    Productid = table.Column<int>(nullable: false),
                    ProductCode = table.Column<int>(nullable: false),
                    Userid = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    Count = table.Column<int>(nullable: false),
                    Price = table.Column<string>(maxLength: 15, nullable: false),
                    AmountSent = table.Column<string>(maxLength: 15, nullable: false),
                    Tax = table.Column<string>(maxLength: 15, nullable: false),
                    Warranty = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_ShoppingCart", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Tbl_ShoppingCart_Tbl_Products_Productid",
                        column: x => x.Productid,
                        principalTable: "Tbl_Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tbl_ShoppingCart_AspNetUsers_Userid",
                        column: x => x.Userid,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_ViewImage",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsertedDate = table.Column<DateTime>(nullable: false),
                    ServerID = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    FileName = table.Column<string>(nullable: true),
                    Alt = table.Column<string>(nullable: true),
                    ProductsID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_ViewImage", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Tbl_ViewImage_Tbl_Products_ProductsID",
                        column: x => x.ProductsID,
                        principalTable: "Tbl_Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tbl_ViewImage_Tbl_OtherServer_ServerID",
                        column: x => x.ServerID,
                        principalTable: "Tbl_OtherServer",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_TechnicalsDetails",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsertedDate = table.Column<DateTime>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    ColorId = table.Column<int>(nullable: false),
                    Type = table.Column<string>(maxLength: 100, nullable: false),
                    Manufacturer = table.Column<string>(maxLength: 100, nullable: true),
                    ManufacturerCountry = table.Column<string>(maxLength: 100, nullable: true),
                    Model = table.Column<string>(maxLength: 100, nullable: true),
                    ProductionYear = table.Column<string>(maxLength: 100, nullable: true),
                    Warranty = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_TechnicalsDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Tbl_TechnicalsDetails_Tbl_ProductColors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Tbl_ProductColors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tbl_TechnicalsDetails_Tbl_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Tbl_Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Gallery",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsertedDate = table.Column<DateTime>(nullable: false),
                    ProductID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    PictureName = table.Column<string>(maxLength: 50, nullable: false),
                    Defult = table.Column<bool>(nullable: false),
                    ViewImageID = table.Column<int>(nullable: false),
                    ServerUpload = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Gallery", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Tbl_Gallery_Tbl_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Tbl_Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tbl_Gallery_Tbl_ViewImage_ViewImageID",
                        column: x => x.ViewImageID,
                        principalTable: "Tbl_ViewImage",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Comments_ProductID",
                table: "Tbl_Comments",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Gallery_ProductID",
                table: "Tbl_Gallery",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Gallery_ViewImageID",
                table: "Tbl_Gallery",
                column: "ViewImageID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Invoce_Productid",
                table: "Tbl_Invoce",
                column: "Productid");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Invoce_Userid",
                table: "Tbl_Invoce",
                column: "Userid");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_ProductColors_ProductsID",
                table: "Tbl_ProductColors",
                column: "ProductsID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Products_CategoryId",
                table: "Tbl_Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Products_UserID",
                table: "Tbl_Products",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_ShoppingCart_Productid",
                table: "Tbl_ShoppingCart",
                column: "Productid");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_ShoppingCart_Userid",
                table: "Tbl_ShoppingCart",
                column: "Userid");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_TechnicalsDetails_ColorId",
                table: "Tbl_TechnicalsDetails",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_TechnicalsDetails_ProductId",
                table: "Tbl_TechnicalsDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_ViewImage_ProductsID",
                table: "Tbl_ViewImage",
                column: "ProductsID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_ViewImage_ServerID",
                table: "Tbl_ViewImage",
                column: "ServerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Article");

            migrationBuilder.DropTable(
                name: "Tbl_Comments");

            migrationBuilder.DropTable(
                name: "Tbl_Gallery");

            migrationBuilder.DropTable(
                name: "Tbl_Invoce");

            migrationBuilder.DropTable(
                name: "Tbl_Settings");

            migrationBuilder.DropTable(
                name: "Tbl_ShoppingCart");

            migrationBuilder.DropTable(
                name: "Tbl_TechnicalsDetails");

            migrationBuilder.DropTable(
                name: "Tbl_UserPages");

            migrationBuilder.DropTable(
                name: "Tbl_Weight");

            migrationBuilder.DropTable(
                name: "Tbl_ViewImage");

            migrationBuilder.DropTable(
                name: "Tbl_ProductColors");

            migrationBuilder.DropTable(
                name: "Tbl_OtherServer");

            migrationBuilder.DropTable(
                name: "Tbl_Products");

            migrationBuilder.DropTable(
                name: "Tbl_Category");

            migrationBuilder.DropColumn(
                name: "City",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");
        }
    }
}
