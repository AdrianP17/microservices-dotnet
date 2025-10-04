namespace promociones.Dtos.Promocion
{
    public class PromocionDto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public decimal Monto { get; set; }
        public decimal Porcentaje { get; set; }
        public DateTimeOffset Fecha_inicio { get; set; }
        public DateTimeOffset Fecha_limite { get; set; }
    }
}