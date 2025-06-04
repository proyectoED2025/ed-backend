using Carpinteria.Modelo;

namespace Carpinteria.InterfaceRepositorio
{
    public interface IRepositorioMovimientoStock  : IRepositorio<MovimientoStock>
    {

        List<MovimientoStock> ListarPorFecha(DateTime desde, DateTime hasta);
    }
}
