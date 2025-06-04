using Carpinteria.Modelo;
using System.ComponentModel.DataAnnotations;

namespace Carpinteria.DTO_s
{
    public class ModificarPerfilDTO
    {
        [Required(ErrorMessage = "El ID del perfil es obligatorio.")]
        public int InsumoId { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Proveedor { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "El precio debe ser mayor a 0.")]
        public int Precio { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "El peso debe ser mayor a 0.")]
        public double Peso { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "El peso por metro debe ser mayor a 0.")]
        public double PesoPorMetro { get; set; }

        [Required]
        public string Largo { get; set; }

        [Required]
        public string Color { get; set; }

        [EnumDataType(typeof(SeriePerfiles), ErrorMessage = "La serie proporcionada no es válida.")]

        public SeriePerfiles SeriePerfil { get; set; }

        [Range(1, int.MaxValue, ErrorMessage ="La cantidad tiene que ser un numero mayor a 0")]
        public int NuevaCantidad { get; set; }

    }
}
