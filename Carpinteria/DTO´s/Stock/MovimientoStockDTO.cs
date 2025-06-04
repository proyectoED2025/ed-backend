namespace Carpinteria.DTO_s
{
    public class MovimientoStockDTO
    {
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string Tipo { get; set; } // "Alta", "Baja", "Modificación"
        public string Insumo { get; set; } // "Perfil", "Vidrio", "Accesorio"
        public int InsumoId { get; set; }
        public int Cantidad { get; set; }
        public string Usuario { get; set; }
        public string Observaciones { get; set; }
    }
}
