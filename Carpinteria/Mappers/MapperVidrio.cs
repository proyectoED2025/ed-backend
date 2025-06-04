using Carpinteria.DTO_s;
using Carpinteria.Excepciones;
using Carpinteria.Modelo;

namespace Carpinteria.Mappers
{
    public class MapperVidrio
    {
        public static Vidrio DTOVidrioTOVidrio(VidrioCreateDTO dto)
        {
            if (dto == null)
            {
                throw new InsumoException("Los datos no son correctos");
            }
            return new Vidrio(dto.Nombre, dto.Proveedor, dto.Precio, dto.Espesor, dto.Largo, dto.Ancho, dto.TipoVidrio);
        }
    }
}
