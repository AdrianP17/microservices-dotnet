using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace catalogo.Migrations
{
    /// <inheritdoc />
    public partial class Setup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Atributos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atributos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: false),
                    IdPromocion = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AtributosValor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdAtributo = table.Column<int>(type: "integer", nullable: true),
                    Valor = table.Column<string>(type: "text", nullable: false),
                    AtributoId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtributosValor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AtributosValor_Atributos_AtributoId",
                        column: x => x.AtributoId,
                        principalTable: "Atributos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Favoritos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdProducto = table.Column<int>(type: "integer", nullable: false),
                    IdCliente = table.Column<int>(type: "integer", nullable: false),
                    ProductoId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favoritos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Favoritos_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductoImagenes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdProducto = table.Column<int>(type: "integer", nullable: true),
                    Principal = table.Column<bool>(type: "boolean", nullable: false),
                    Imagen = table.Column<string>(type: "text", nullable: false),
                    ProductoId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductoImagenes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductoImagenes_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Variantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdProducto = table.Column<int>(type: "integer", nullable: true),
                    Precio = table.Column<decimal>(type: "numeric", nullable: false),
                    ProductoId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Variantes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Variantes_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VarianteAtributos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdVariante = table.Column<int>(type: "integer", nullable: true),
                    IdAtrValor = table.Column<int>(type: "integer", nullable: true),
                    VarianteId = table.Column<int>(type: "integer", nullable: true),
                    AtributoValorId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VarianteAtributos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VarianteAtributos_AtributosValor_AtributoValorId",
                        column: x => x.AtributoValorId,
                        principalTable: "AtributosValor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VarianteAtributos_Variantes_VarianteId",
                        column: x => x.VarianteId,
                        principalTable: "Variantes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VarianteImagenes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdVariante = table.Column<int>(type: "integer", nullable: true),
                    IdVarAtributo = table.Column<int>(type: "integer", nullable: true),
                    Imagen = table.Column<string>(type: "text", nullable: false),
                    VarianteId = table.Column<int>(type: "integer", nullable: true),
                    VarianteAtributoId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VarianteImagenes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VarianteImagenes_VarianteAtributos_VarianteAtributoId",
                        column: x => x.VarianteAtributoId,
                        principalTable: "VarianteAtributos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_VarianteImagenes_Variantes_VarianteId",
                        column: x => x.VarianteId,
                        principalTable: "Variantes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AtributosValor_AtributoId",
                table: "AtributosValor",
                column: "AtributoId");

            migrationBuilder.CreateIndex(
                name: "IX_Favoritos_ProductoId",
                table: "Favoritos",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductoImagenes_ProductoId",
                table: "ProductoImagenes",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_VarianteAtributos_AtributoValorId",
                table: "VarianteAtributos",
                column: "AtributoValorId");

            migrationBuilder.CreateIndex(
                name: "IX_VarianteAtributos_VarianteId",
                table: "VarianteAtributos",
                column: "VarianteId");

            migrationBuilder.CreateIndex(
                name: "IX_VarianteImagenes_VarianteAtributoId",
                table: "VarianteImagenes",
                column: "VarianteAtributoId");

            migrationBuilder.CreateIndex(
                name: "IX_VarianteImagenes_VarianteId",
                table: "VarianteImagenes",
                column: "VarianteId");

            migrationBuilder.CreateIndex(
                name: "IX_Variantes_ProductoId",
                table: "Variantes",
                column: "ProductoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favoritos");

            migrationBuilder.DropTable(
                name: "ProductoImagenes");

            migrationBuilder.DropTable(
                name: "VarianteImagenes");

            migrationBuilder.DropTable(
                name: "VarianteAtributos");

            migrationBuilder.DropTable(
                name: "AtributosValor");

            migrationBuilder.DropTable(
                name: "Variantes");

            migrationBuilder.DropTable(
                name: "Atributos");

            migrationBuilder.DropTable(
                name: "Productos");
        }
    }
}
