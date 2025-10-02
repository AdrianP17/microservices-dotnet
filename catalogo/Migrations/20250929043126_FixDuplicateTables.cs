using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace catalogo.Migrations
{
    /// <inheritdoc />
    public partial class FixDuplicateTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favorito_Producto_ProductoId",
                table: "Favorito");

            migrationBuilder.DropColumn(
                name: "IdVarAtributo",
                table: "VarianteImagen");

            migrationBuilder.DropColumn(
                name: "IdVariante",
                table: "VarianteImagen");

            migrationBuilder.DropColumn(
                name: "IdAtrValor",
                table: "VarianteAtributo");

            migrationBuilder.DropColumn(
                name: "IdVariante",
                table: "VarianteAtributo");

            migrationBuilder.DropColumn(
                name: "IdProducto",
                table: "Variante");

            migrationBuilder.DropColumn(
                name: "IdProducto",
                table: "ProductoImagen");

            migrationBuilder.DropColumn(
                name: "IdProducto",
                table: "Favorito");

            migrationBuilder.DropColumn(
                name: "IdAtributo",
                table: "AtributoValor");

            migrationBuilder.AlterColumn<int>(
                name: "ProductoId",
                table: "Favorito",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Favorito_Producto_ProductoId",
                table: "Favorito",
                column: "ProductoId",
                principalTable: "Producto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favorito_Producto_ProductoId",
                table: "Favorito");

            migrationBuilder.AddColumn<int>(
                name: "IdVarAtributo",
                table: "VarianteImagen",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdVariante",
                table: "VarianteImagen",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdAtrValor",
                table: "VarianteAtributo",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdVariante",
                table: "VarianteAtributo",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdProducto",
                table: "Variante",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdProducto",
                table: "ProductoImagen",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductoId",
                table: "Favorito",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "IdProducto",
                table: "Favorito",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdAtributo",
                table: "AtributoValor",
                type: "integer",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Favorito_Producto_ProductoId",
                table: "Favorito",
                column: "ProductoId",
                principalTable: "Producto",
                principalColumn: "Id");
        }
    }
}
