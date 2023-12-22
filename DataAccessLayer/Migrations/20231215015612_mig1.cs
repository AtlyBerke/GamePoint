using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Firmalars",
                columns: table => new
                {
                    FirmaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirmaAd = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firmalars", x => x.FirmaID);
                });

            migrationBuilder.CreateTable(
                name: "Platforms",
                columns: table => new
                {
                    Platformid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlatformAd = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platforms", x => x.Platformid);
                });

            migrationBuilder.CreateTable(
                name: "Oyunlars",
                columns: table => new
                {
                    OyunID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OyunAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    OyunGenelPuan = table.Column<int>(type: "int", nullable: false),
                    OyunCikisTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OyunFiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Platformid = table.Column<int>(type: "int", nullable: false),
                    GelisticiFirma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OyunTanitim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OyunAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OyunResim = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oyunlars", x => x.OyunID);
                    table.ForeignKey(
                        name: "FK_Oyunlars_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Oyunlars_Platforms_Platformid",
                        column: x => x.Platformid,
                        principalTable: "Platforms",
                        principalColumn: "Platformid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hareketlers",
                columns: table => new
                {
                    HareketID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OyunlarOyunID = table.Column<int>(type: "int", nullable: true),
                    OyunID = table.Column<int>(type: "int", nullable: false),
                    Platformid = table.Column<int>(type: "int", nullable: false),
                    FirmalarFirmaID = table.Column<int>(type: "int", nullable: true),
                    FirmaID = table.Column<int>(type: "int", nullable: false),
                    FirmaPuan = table.Column<int>(type: "int", nullable: false),
                    FirmaYorum = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hareketlers", x => x.HareketID);
                    table.ForeignKey(
                        name: "FK_Hareketlers_Firmalars_FirmalarFirmaID",
                        column: x => x.FirmalarFirmaID,
                        principalTable: "Firmalars",
                        principalColumn: "FirmaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Hareketlers_Oyunlars_OyunlarOyunID",
                        column: x => x.OyunlarOyunID,
                        principalTable: "Oyunlars",
                        principalColumn: "OyunID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Hareketlers_Platforms_Platformid",
                        column: x => x.Platformid,
                        principalTable: "Platforms",
                        principalColumn: "Platformid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hareketlers_FirmalarFirmaID",
                table: "Hareketlers",
                column: "FirmalarFirmaID");

            migrationBuilder.CreateIndex(
                name: "IX_Hareketlers_OyunlarOyunID",
                table: "Hareketlers",
                column: "OyunlarOyunID");

            migrationBuilder.CreateIndex(
                name: "IX_Hareketlers_Platformid",
                table: "Hareketlers",
                column: "Platformid");

            migrationBuilder.CreateIndex(
                name: "IX_Oyunlars_CategoryID",
                table: "Oyunlars",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Oyunlars_Platformid",
                table: "Oyunlars",
                column: "Platformid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hareketlers");

            migrationBuilder.DropTable(
                name: "Firmalars");

            migrationBuilder.DropTable(
                name: "Oyunlars");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Platforms");
        }
    }
}
