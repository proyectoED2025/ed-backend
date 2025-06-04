using System.ComponentModel.DataAnnotations;
namespace Carpinteria.DTO_s
{

    public class DeletePerfilDTO
    {
        [Required(ErrorMessage = "El ID del perfil es obligatorio.")]
        [Range(1, int.MaxValue, ErrorMessage = "El ID debe ser un número mayor a cero.")]
        public int InsumoId { get; set; }

    }









}

