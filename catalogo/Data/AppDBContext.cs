using catalogo.Models;
using Microsoft.EntityFrameworkCore;

namespace catalogo.Data;

public class AppDBContext : DbContext
{

    public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }


    //Create DbSet for each model
    //Ex: public DbSet<Product> Products { get; set; }
    public DbSet<Producto> Producto { get; set; }
    public DbSet<ProductoImagen> ProductoImagen { get; set; }
    public DbSet<Variante> Variante { get; set; }
    public DbSet<VarianteImagen> VarianteImagen { get; set; }
    public DbSet<VarianteAtributo> VarianteAtributo { get; set; }
    public DbSet<Atributo> Atributo { get; set; }
    public DbSet<AtributoValor> AtributoValor { get; set; }
    public DbSet<ProductoAtributo> ProductoAtributo { get; set; }

    public DbSet<Favorito> Favorito { get; set; }
}
