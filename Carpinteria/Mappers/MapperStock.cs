using Carpinteria.Modelo;

namespace Carpinteria.Mappers
{
    public class MapperStock
    {
        public static Stock CrearStock(DateTime fechaCreacion, DateTime fechaActualizacion,
            int cantidad, int insumoId)
        {
            return new Stock(fechaCreacion, fechaActualizacion, cantidad, insumoId);
        }
    }
}
