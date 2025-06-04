using Carpinteria.Modelo;
using System.ComponentModel.DataAnnotations;

namespace Carpinteria.DTO_s
{
    public class PerfilCreateDTO
    {

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El proveedor es obligatorio.")]
        public string Proveedor { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "El precio debe ser mayor a 0.")]
        public int Precio { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "El peso debe ser mayor a 0.")]
        public double Peso { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "El peso por metro debe ser mayor a 0.")]
        public double PesoPorMetro { get; set; }

        [Required(ErrorMessage = "El color es obligatorio.")]
        public string Color { get; set; }

        [Required(ErrorMessage = "El largo es obligatorio.")]
        [RegularExpression(@"^\d+(\.\d+)?$", ErrorMessage = "El largo debe ser un número válido.")]
        public string Largo { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "La cantidad no puede ser negativa.")]
        public int Cantidad { get; set; }

        [EnumDataType(typeof(SeriePerfiles), ErrorMessage = "La serie proporcionada no es válida.")]

        public SeriePerfiles SeriePerfil { get; set; }//ENUM

    }
}
