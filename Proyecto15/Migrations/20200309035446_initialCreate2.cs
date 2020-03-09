using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto15.Migrations
{
    public partial class initialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    IdCategoria = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.IdCategoria);
                });

            migrationBuilder.CreateTable(
                name: "SubCategorias",
                columns: table => new
                {
                    IdSubCategoria = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategorias", x => x.IdSubCategoria);
                });

            migrationBuilder.CreateTable(
                name: "CategoriaSubCategorias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCategoria = table.Column<int>(nullable: false),
                    IdSubCategoria = table.Column<int>(nullable: false),
                    CategoriaIdCategoria = table.Column<int>(nullable: true),
                    SubCategoriaIdSubCategoria = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaSubCategorias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoriaSubCategorias_Categoria_CategoriaIdCategoria",
                        column: x => x.CategoriaIdCategoria,
                        principalTable: "Categoria",
                        principalColumn: "IdCategoria",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CategoriaSubCategorias_SubCategorias_SubCategoriaIdSubCategoria",
                        column: x => x.SubCategoriaIdSubCategoria,
                        principalTable: "SubCategorias",
                        principalColumn: "IdSubCategoria",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoriaSubCategorias_CategoriaIdCategoria",
                table: "CategoriaSubCategorias",
                column: "CategoriaIdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriaSubCategorias_SubCategoriaIdSubCategoria",
                table: "CategoriaSubCategorias",
                column: "SubCategoriaIdSubCategoria");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoriaSubCategorias");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "SubCategorias");
        }
    }
}
