using Carpinteria.Modelo;

namespace Carpinteria.Mappers
{
    public class MapperMovimientoStock// esto capaz lo podemos eliminar
    {
        public static MovimientoStock CrearMovStock(MovimientoStock dto)
        {
            return new MovimientoStock(dto.Fecha, dto.Tipo, dto.Insumo, dto.InsumoId, dto.Cantidad, dto.Usuario, dto.Observaciones);
        }
       
    }
}
