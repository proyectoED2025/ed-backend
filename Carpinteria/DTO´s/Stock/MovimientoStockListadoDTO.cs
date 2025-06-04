namespace Carpinteria.DTO_s
{
    public class MovimientoStockListadoDTO
    {
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; }
        public string Entidad { get; set; }
        public int EntidadId { get; set; }
        public int Cantidad { get; set; }
        public string Usuario { get; set; }
        public string Observaciones { get; set; }
    }

}
