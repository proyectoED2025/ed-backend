using System.ComponentModel.DataAnnotations;

namespace Carpinteria.DTO_s
{
    public class AccesorioCreateDTO
    {
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El proveedor es obligatorio.")]
        public string Proveedor { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "El precio debe ser mayor a 0.")]
        public int Precio { get; set; }

        [Required(ErrorMessage = "El color es obligatorio.")]
        public string Color { get; set; }

        [Required(ErrorMessage = "El tipo es obligatorio.")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "El detalle es obligatorio.")]
        public string Detalle { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "La cantidad no puede ser negativa.")]
        public int Cantidad { get; set; }
    }
}
