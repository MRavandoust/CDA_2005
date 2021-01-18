using Microsoft.EntityFrameworkCore.Migrations;

namespace CatalogueProduit.Migrations
{
    public partial class Catalogue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CATEGORIES",
                columns: table => new
                {
                    CategorieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomCategorie = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CATEGORIES", x => x.CategorieId);
                });

            migrationBuilder.CreateTable(
                name: "PRODUITS",
                columns: table => new
                {
                    ProduitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Designation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Prix = table.Column<double>(type: "float", nullable: false),
                    Quantite = table.Column<int>(type: "int", nullable: false),
                    CategorieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUITS", x => x.ProduitId);
                    table.ForeignKey(
                        name: "FK_PRODUITS_CATEGORIES_CategorieId",
                        column: x => x.CategorieId,
                        principalTable: "CATEGORIES",
                        principalColumn: "CategorieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PRODUITS_CategorieId",
                table: "PRODUITS",
                column: "CategorieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PRODUITS");

            migrationBuilder.DropTable(
                name: "CATEGORIES");
        }
    }
}
