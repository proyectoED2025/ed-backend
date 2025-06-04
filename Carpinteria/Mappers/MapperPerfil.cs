using Carpinteria.DTO_s;
using Carpinteria.Excepciones;
using Carpinteria.Modelo;

namespace Carpinteria.Mappers
{
    public class MapperPerfil
    {
        public static Perfil DTOPerfilTOPerfil(PerfilCreateDTO dto)
        {
            if (dto == null)
            {
                throw new InsumoException("Los datos no son correctos");
            }
            return new Perfil(dto.Nombre, dto.Proveedor, dto.Precio, dto.Peso, dto.PesoPorMetro, dto.Largo, dto.Color, dto.SeriePerfil);
        }

        public static Perfil DTOPerfilModificadoToPerfil(ModificarPerfilDTO dto)
        {
            if (dto == null)
                throw new InsumoException("Los datos no son correctos");

            return new Perfil(
                dto.Nombre,
                dto.Proveedor,
                dto.Precio,
                dto.Peso,
                dto.PesoPorMetro,
                dto.Largo,
                dto.Color,
                dto.SeriePerfil
            )
            {
                InsumoId = dto.InsumoId//Esto lo hacemos para que EF entienda que es una actualizacion. Este atributo no de modifica.
            };
        }
    }
}
