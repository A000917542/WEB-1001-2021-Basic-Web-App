using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WEB_1001_2021_Basic_Web_App.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 64, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 128, nullable: true),
                    Location = table.Column<string>(type: "TEXT", nullable: true),
                    RegisterDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Email);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    SKU = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Decription = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<decimal>(type: "TEXT", precision: 18, scale: 10, nullable: false),
                    Category = table.Column<string>(type: "TEXT", nullable: true),
                    SubCategory = table.Column<string>(type: "TEXT", nullable: true),
                    Dimensions = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.SKU);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    RGB = table.Column<string>(type: "TEXT", nullable: false),
                    ShortCode = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    ProductSKU = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.RGB);
                    table.ForeignKey(
                        name: "FK_Colors_Products_ProductSKU",
                        column: x => x.ProductSKU,
                        principalTable: "Products",
                        principalColumn: "SKU",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    ShortCode = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    ProductSKU = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.ShortCode);
                    table.ForeignKey(
                        name: "FK_Materials_Products_ProductSKU",
                        column: x => x.ProductSKU,
                        principalTable: "Products",
                        principalColumn: "SKU",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Media",
                columns: table => new
                {
                    FilePath = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    FileType = table.Column<string>(type: "TEXT", nullable: true),
                    MediaDescriptor = table.Column<string>(type: "TEXT", nullable: true),
                    ColorRGB = table.Column<string>(type: "TEXT", nullable: true),
                    MaterialShortCode = table.Column<string>(type: "TEXT", nullable: true),
                    ProductSKU = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Media", x => x.FilePath);
                    table.ForeignKey(
                        name: "FK_Media_Colors_ColorRGB",
                        column: x => x.ColorRGB,
                        principalTable: "Colors",
                        principalColumn: "RGB",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Media_Materials_MaterialShortCode",
                        column: x => x.MaterialShortCode,
                        principalTable: "Materials",
                        principalColumn: "ShortCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Media_Products_ProductSKU",
                        column: x => x.ProductSKU,
                        principalTable: "Products",
                        principalColumn: "SKU",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Colors_ProductSKU",
                table: "Colors",
                column: "ProductSKU");

            migrationBuilder.CreateIndex(
                name: "IX_Materials_ProductSKU",
                table: "Materials",
                column: "ProductSKU");

            migrationBuilder.CreateIndex(
                name: "IX_Media_ColorRGB",
                table: "Media",
                column: "ColorRGB");

            migrationBuilder.CreateIndex(
                name: "IX_Media_MaterialShortCode",
                table: "Media",
                column: "MaterialShortCode");

            migrationBuilder.CreateIndex(
                name: "IX_Media_ProductSKU",
                table: "Media",
                column: "ProductSKU");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Media");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
