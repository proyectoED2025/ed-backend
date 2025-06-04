using Carpinteria.Modelo;
using System.ComponentModel.DataAnnotations;

namespace Carpinteria.DTO_s.Vidrio
{
    public class ModificarVidrioDTO
    {

        [Required(ErrorMessage = "El ID del vidrio es obligatorio.")]
        public int InsumoId { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Proveedor { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "El precio debe ser mayor a 0.")]
        public int Precio { get; set; }

        [Required]
        public string Espesor { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "El largo debe ser mayor a 0.")]
        public double Largo { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "El ancho debe ser mayor a 0.")]
        public double Ancho { get; set; }
      

        [EnumDataType(typeof(TipoVidrio), ErrorMessage = "El tipo de vidrio no es válido.")]

        public TipoVidrio SeriePerfil { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "La cantidad tiene que ser un numero mayor a 0")]
        public int NuevaCantidad { get; set; }
    }
}
