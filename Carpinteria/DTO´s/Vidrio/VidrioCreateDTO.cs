using Carpinteria.Modelo;
using System.ComponentModel.DataAnnotations;

namespace Carpinteria.DTO_s
{
    public class VidrioCreateDTO
    {
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El proveedor es obligatorio.")]
        public string Proveedor { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "El precio debe ser mayor a 0.")]
        public int Precio { get; set; }

        [Required(ErrorMessage = "El espesor es obligatorio.")]
        public string Espesor { get; set; }

        [Range(1, double.MaxValue, ErrorMessage = "El largo debe ser mayor a 0.")]
        public double Largo { get; set; }

        [Range(1, double.MaxValue, ErrorMessage = "El ancho debe ser mayor a 0.")]
        public double Ancho { get; set; }

        [EnumDataType(typeof(TipoVidrio), ErrorMessage = "El tipo de vidrio no es válido.")]
        public TipoVidrio TipoVidrio { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "La cantidad no puede ser negativa.")]
        public int Cantidad { get; set; }
    }


}
