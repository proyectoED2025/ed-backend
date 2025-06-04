using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Carpinteria.Modelo
{
    public class InsumosNecesarios
    {
        [Key]
        public int Id {  get; set; }

        public int InsumoId { get; set; }
        [ForeignKey("InsumoId")]
        public Insumo Insumo { get; set; }
        public int ProductoId { get; set; }
        [ForeignKey("ProductoId")]
        public Producto producto { get; set; }
        public int Cantidad { get; set; }
    }
}
