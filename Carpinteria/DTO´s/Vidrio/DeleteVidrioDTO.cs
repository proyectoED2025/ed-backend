using System.ComponentModel.DataAnnotations;

namespace Carpinteria.DTO_s.Vidrio
{
    public class DeleteVidrioDTO
    {
        [Required(ErrorMessage = "El campo InsumoId es obligatorio.")]
        [Range(1, int.MaxValue, ErrorMessage = "El ID del insumo debe ser mayor que cero.")]
        public int InsumoId { get; set; }

        [StringLength(200, ErrorMessage = "El motivo no puede superar los 200 caracteres.")]
        public string Motivo { get; set; } = "Baja de vidrio";
    }
}
