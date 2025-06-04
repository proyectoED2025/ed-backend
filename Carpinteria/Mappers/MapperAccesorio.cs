using Carpinteria.DTO_s;
using Carpinteria.Excepciones;
using Carpinteria.Modelo;
using System.ComponentModel.DataAnnotations;

namespace Carpinteria.Mappers
{
    public class MapperAccesorio
    {
        public static Accesorio DTOAccesorioTOAccesorio(AccesorioCreateDTO dto)
        {
            if (dto == null)
            {
                throw new InsumoException("Los datos no son correctos");
            }
            return new Accesorio(dto.Nombre, dto.Proveedor, dto.Precio, dto.Color, dto.Tipo, dto.Detalle);
        }

        
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
