using Carpinteria.Data;
using Carpinteria.InterfaceRepositorio;
using Carpinteria.InterfacesCU;
using Carpinteria.Mappers;
using Carpinteria.Modelo;
using Carpinteria.Repositorios;

namespace Carpinteria.ImplementacionCU
{
    public class RegistrarMovimiento : IRegistrarMovimiento
    {
        private readonly IRepositorioMovimientoStock ReposMovimientStock;

        public RegistrarMovimiento(IRepositorioMovimientoStock reposMovimientStock)
        {
            ReposMovimientStock = reposMovimientStock;
        }

        public void Ejecutar(MovimientoStock dto)
        {
            MovimientoStock movimiento = MapperMovimientoStock.CrearMovStock(dto);
            ReposMovimientStock.Add(movimiento);
             
        }

       
        }
    
}
