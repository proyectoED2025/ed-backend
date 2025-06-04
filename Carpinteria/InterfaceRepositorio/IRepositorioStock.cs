using Carpinteria.Modelo;

namespace Carpinteria.InterfaceRepositorio
{
    public interface IRepositorioStock : IRepositorio<Stock>
    {
        public Stock FindByIdInsumo(int insumoId);

    }
}
