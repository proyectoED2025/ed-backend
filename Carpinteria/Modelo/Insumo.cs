using System.ComponentModel.DataAnnotations;

namespace Carpinteria.Modelo
{
    public abstract class Insumo
    {
        [Key]
        public int InsumoId { get; set; }

        public string Nombre { get; set; }
        
        public string Proveedor { get; set; }

        public int Precio { get; set; }

    

    }
}
