using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto15.Migrations
{
    public partial class _ : Migration
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
                name: "Grupos",
                columns: table => new
                {
                    IdGrupo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupos", x => x.IdGrupo);
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
                    IdCategoriaSubCategoria = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCategoria1 = table.Column<int>(nullable: true),
                    IdSubCategoria1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaSubCategorias", x => x.IdCategoriaSubCategoria);
                    table.ForeignKey(
                        name: "FK_CategoriaSubCategorias_Categoria_IdCategoria1",
                        column: x => x.IdCategoria1,
                        principalTable: "Categoria",
                        principalColumn: "IdCategoria",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CategoriaSubCategorias_SubCategorias_IdSubCategoria1",
                        column: x => x.IdSubCategoria1,
                        principalTable: "SubCategorias",
                        principalColumn: "IdSubCategoria",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Instituciones",
                columns: table => new
                {
                    IdInstitucion = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RazonSocial = table.Column<string>(nullable: true),
                    Alias = table.Column<string>(nullable: true),
                    IdGrupo1 = table.Column<int>(nullable: true),
                    IdCategoriaSubCategoria1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instituciones", x => x.IdInstitucion);
                    table.ForeignKey(
                        name: "FK_Instituciones_CategoriaSubCategorias_IdCategoriaSubCategoria1",
                        column: x => x.IdCategoriaSubCategoria1,
                        principalTable: "CategoriaSubCategorias",
                        principalColumn: "IdCategoriaSubCategoria",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Instituciones_Grupos_IdGrupo1",
                        column: x => x.IdGrupo1,
                        principalTable: "Grupos",
                        principalColumn: "IdGrupo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoriaSubCategorias_IdCategoria1",
                table: "CategoriaSubCategorias",
                column: "IdCategoria1");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriaSubCategorias_IdSubCategoria1",
                table: "CategoriaSubCategorias",
                column: "IdSubCategoria1");

            migrationBuilder.CreateIndex(
                name: "IX_Instituciones_IdCategoriaSubCategoria1",
                table: "Instituciones",
                column: "IdCategoriaSubCategoria1");

            migrationBuilder.CreateIndex(
                name: "IX_Instituciones_IdGrupo1",
                table: "Instituciones",
                column: "IdGrupo1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Instituciones");

            migrationBuilder.DropTable(
                name: "CategoriaSubCategorias");

            migrationBuilder.DropTable(
                name: "Grupos");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "SubCategorias");
        }
    }
}
