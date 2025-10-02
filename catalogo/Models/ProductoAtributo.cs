namespace catalogo.Models
{
    public class ProductoAtributo
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public int AtributoId { get; set; }

        public Producto? Producto { get; set; }
        public Atributo? Atributo { get; set; }
    }
}
