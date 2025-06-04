using System.ComponentModel.DataAnnotations;

namespace Carpinteria.Modelo
{
    public class Producto
    {
        [Key]
        public int ProductoId { get; set; }
        public string Nombre { get; set; }

        public double Costo { get; set; }

        public TipoMoneda TipoMoneda { get; set; }

        public List<InsumosNecesarios> InsumoNecesarios { get; set; } = new();
    }
}
