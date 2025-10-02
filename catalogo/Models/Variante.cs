namespace catalogo.Models
{
    public class Variante
    {
        public int Id { get; set; }
        public int? ProductoId { get; set; }
        public decimal Precio { get; set; }

        public Producto? Producto { get; set; }
        public ICollection<VarianteImagen> VarianteImagenes { get; set; } = new List<VarianteImagen>();
        public ICollection<VarianteAtributo> VarianteAtributos { get; set; } = new List<VarianteAtributo>();
    }
}
