using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace catalogo.Migrations
{
    /// <inheritdoc />
    public partial class Rename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AtributosValor_Atributos_AtributoId",
                table: "AtributosValor");

            migrationBuilder.DropForeignKey(
                name: "FK_Favoritos_Productos_ProductoId",
                table: "Favoritos");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductoImagenes_Productos_ProductoId",
                table: "ProductoImagenes");

            migrationBuilder.DropForeignKey(
                name: "FK_VarianteAtributos_AtributosValor_AtributoValorId",
                table: "VarianteAtributos");

            migrationBuilder.DropForeignKey(
                name: "FK_VarianteAtributos_Variantes_VarianteId",
                table: "VarianteAtributos");

            migrationBuilder.DropForeignKey(
                name: "FK_VarianteImagenes_VarianteAtributos_VarianteAtributoId",
                table: "VarianteImagenes");

            migrationBuilder.DropForeignKey(
                name: "FK_VarianteImagenes_Variantes_VarianteId",
                table: "VarianteImagenes");

            migrationBuilder.DropForeignKey(
                name: "FK_Variantes_Productos_ProductoId",
                table: "Variantes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Variantes",
                table: "Variantes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VarianteImagenes",
                table: "VarianteImagenes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VarianteAtributos",
                table: "VarianteAtributos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Productos",
                table: "Productos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductoImagenes",
                table: "ProductoImagenes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Favoritos",
                table: "Favoritos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AtributosValor",
                table: "AtributosValor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Atributos",
                table: "Atributos");

            migrationBuilder.RenameTable(
                name: "Variantes",
                newName: "Variante");

            migrationBuilder.RenameTable(
                name: "VarianteImagenes",
                newName: "VarianteImagen");

            migrationBuilder.RenameTable(
                name: "VarianteAtributos",
                newName: "VarianteAtributo");

            migrationBuilder.RenameTable(
                name: "Productos",
                newName: "Producto");

            migrationBuilder.RenameTable(
                name: "ProductoImagenes",
                newName: "ProductoImagen");

            migrationBuilder.RenameTable(
                name: "Favoritos",
                newName: "Favorito");

            migrationBuilder.RenameTable(
                name: "AtributosValor",
                newName: "AtributoValor");

            migrationBuilder.RenameTable(
                name: "Atributos",
                newName: "Atributo");

            migrationBuilder.RenameIndex(
                name: "IX_Variantes_ProductoId",
                table: "Variante",
                newName: "IX_Variante_ProductoId");

            migrationBuilder.RenameIndex(
                name: "IX_VarianteImagenes_VarianteId",
                table: "VarianteImagen",
                newName: "IX_VarianteImagen_VarianteId");

            migrationBuilder.RenameIndex(
                name: "IX_VarianteImagenes_VarianteAtributoId",
                table: "VarianteImagen",
                newName: "IX_VarianteImagen_VarianteAtributoId");

            migrationBuilder.RenameIndex(
                name: "IX_VarianteAtributos_VarianteId",
                table: "VarianteAtributo",
                newName: "IX_VarianteAtributo_VarianteId");

            migrationBuilder.RenameIndex(
                name: "IX_VarianteAtributos_AtributoValorId",
                table: "VarianteAtributo",
                newName: "IX_VarianteAtributo_AtributoValorId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductoImagenes_ProductoId",
                table: "ProductoImagen",
                newName: "IX_ProductoImagen_ProductoId");

            migrationBuilder.RenameIndex(
                name: "IX_Favoritos_ProductoId",
                table: "Favorito",
                newName: "IX_Favorito_ProductoId");

            migrationBuilder.RenameIndex(
                name: "IX_AtributosValor_AtributoId",
                table: "AtributoValor",
                newName: "IX_AtributoValor_AtributoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Variante",
                table: "Variante",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VarianteImagen",
                table: "VarianteImagen",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VarianteAtributo",
                table: "VarianteAtributo",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Producto",
                table: "Producto",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductoImagen",
                table: "ProductoImagen",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Favorito",
                table: "Favorito",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AtributoValor",
                table: "AtributoValor",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Atributo",
                table: "Atributo",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AtributoValor_Atributo_AtributoId",
                table: "AtributoValor",
                column: "AtributoId",
                principalTable: "Atributo",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Favorito_Producto_ProductoId",
                table: "Favorito",
                column: "ProductoId",
                principalTable: "Producto",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductoImagen_Producto_ProductoId",
                table: "ProductoImagen",
                column: "ProductoId",
                principalTable: "Producto",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Variante_Producto_ProductoId",
                table: "Variante",
                column: "ProductoId",
                principalTable: "Producto",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VarianteAtributo_AtributoValor_AtributoValorId",
                table: "VarianteAtributo",
                column: "AtributoValorId",
                principalTable: "AtributoValor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VarianteAtributo_Variante_VarianteId",
                table: "VarianteAtributo",
                column: "VarianteId",
                principalTable: "Variante",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VarianteImagen_VarianteAtributo_VarianteAtributoId",
                table: "VarianteImagen",
                column: "VarianteAtributoId",
                principalTable: "VarianteAtributo",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VarianteImagen_Variante_VarianteId",
                table: "VarianteImagen",
                column: "VarianteId",
                principalTable: "Variante",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AtributoValor_Atributo_AtributoId",
                table: "AtributoValor");

            migrationBuilder.DropForeignKey(
                name: "FK_Favorito_Producto_ProductoId",
                table: "Favorito");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductoImagen_Producto_ProductoId",
                table: "ProductoImagen");

            migrationBuilder.DropForeignKey(
                name: "FK_Variante_Producto_ProductoId",
                table: "Variante");

            migrationBuilder.DropForeignKey(
                name: "FK_VarianteAtributo_AtributoValor_AtributoValorId",
                table: "VarianteAtributo");

            migrationBuilder.DropForeignKey(
                name: "FK_VarianteAtributo_Variante_VarianteId",
                table: "VarianteAtributo");

            migrationBuilder.DropForeignKey(
                name: "FK_VarianteImagen_VarianteAtributo_VarianteAtributoId",
                table: "VarianteImagen");

            migrationBuilder.DropForeignKey(
                name: "FK_VarianteImagen_Variante_VarianteId",
                table: "VarianteImagen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VarianteImagen",
                table: "VarianteImagen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VarianteAtributo",
                table: "VarianteAtributo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Variante",
                table: "Variante");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductoImagen",
                table: "ProductoImagen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Producto",
                table: "Producto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Favorito",
                table: "Favorito");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AtributoValor",
                table: "AtributoValor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Atributo",
                table: "Atributo");

            migrationBuilder.RenameTable(
                name: "VarianteImagen",
                newName: "VarianteImagenes");

            migrationBuilder.RenameTable(
                name: "VarianteAtributo",
                newName: "VarianteAtributos");

            migrationBuilder.RenameTable(
                name: "Variante",
                newName: "Variantes");

            migrationBuilder.RenameTable(
                name: "ProductoImagen",
                newName: "ProductoImagenes");

            migrationBuilder.RenameTable(
                name: "Producto",
                newName: "Productos");

            migrationBuilder.RenameTable(
                name: "Favorito",
                newName: "Favoritos");

            migrationBuilder.RenameTable(
                name: "AtributoValor",
                newName: "AtributosValor");

            migrationBuilder.RenameTable(
                name: "Atributo",
                newName: "Atributos");

            migrationBuilder.RenameIndex(
                name: "IX_VarianteImagen_VarianteId",
                table: "VarianteImagenes",
                newName: "IX_VarianteImagenes_VarianteId");

            migrationBuilder.RenameIndex(
                name: "IX_VarianteImagen_VarianteAtributoId",
                table: "VarianteImagenes",
                newName: "IX_VarianteImagenes_VarianteAtributoId");

            migrationBuilder.RenameIndex(
                name: "IX_VarianteAtributo_VarianteId",
                table: "VarianteAtributos",
                newName: "IX_VarianteAtributos_VarianteId");

            migrationBuilder.RenameIndex(
                name: "IX_VarianteAtributo_AtributoValorId",
                table: "VarianteAtributos",
                newName: "IX_VarianteAtributos_AtributoValorId");

            migrationBuilder.RenameIndex(
                name: "IX_Variante_ProductoId",
                table: "Variantes",
                newName: "IX_Variantes_ProductoId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductoImagen_ProductoId",
                table: "ProductoImagenes",
                newName: "IX_ProductoImagenes_ProductoId");

            migrationBuilder.RenameIndex(
                name: "IX_Favorito_ProductoId",
                table: "Favoritos",
                newName: "IX_Favoritos_ProductoId");

            migrationBuilder.RenameIndex(
                name: "IX_AtributoValor_AtributoId",
                table: "AtributosValor",
                newName: "IX_AtributosValor_AtributoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VarianteImagenes",
                table: "VarianteImagenes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VarianteAtributos",
                table: "VarianteAtributos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Variantes",
                table: "Variantes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductoImagenes",
                table: "ProductoImagenes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Productos",
                table: "Productos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Favoritos",
                table: "Favoritos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AtributosValor",
                table: "AtributosValor",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Atributos",
                table: "Atributos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AtributosValor_Atributos_AtributoId",
                table: "AtributosValor",
                column: "AtributoId",
                principalTable: "Atributos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Favoritos_Productos_ProductoId",
                table: "Favoritos",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductoImagenes_Productos_ProductoId",
                table: "ProductoImagenes",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VarianteAtributos_AtributosValor_AtributoValorId",
                table: "VarianteAtributos",
                column: "AtributoValorId",
                principalTable: "AtributosValor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VarianteAtributos_Variantes_VarianteId",
                table: "VarianteAtributos",
                column: "VarianteId",
                principalTable: "Variantes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VarianteImagenes_VarianteAtributos_VarianteAtributoId",
                table: "VarianteImagenes",
                column: "VarianteAtributoId",
                principalTable: "VarianteAtributos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VarianteImagenes_Variantes_VarianteId",
                table: "VarianteImagenes",
                column: "VarianteId",
                principalTable: "Variantes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Variantes_Productos_ProductoId",
                table: "Variantes",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id");
        }
    }
}
