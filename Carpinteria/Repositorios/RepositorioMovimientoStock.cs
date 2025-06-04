using Carpinteria.Data;
using Carpinteria.InterfaceRepositorio;
using Carpinteria.Modelo;
using Microsoft.EntityFrameworkCore;

namespace Carpinteria.Repositorios
{
    public class RepositorioMovimientoStock : IRepositorioMovimientoStock
    {


        public CarpinteriaContext Contexto;

        public RepositorioMovimientoStock(CarpinteriaContext contexto)
        {
            Contexto = contexto;
        }
        public void Add(MovimientoStock item)
        {
            Contexto.MovimientosStock.Add(item);
            Contexto.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MovimientoStock> FindAll()
        {
            throw new NotImplementedException();
        }

        public MovimientoStock FindById(int id)
        {
            throw new NotImplementedException();
        }

        public List<MovimientoStock> ListarPorFecha(DateTime desde, DateTime hasta)
        {
            return Contexto.MovimientosStock
           .Where(m => m.Fecha >= desde && m.Fecha <= hasta)
           .ToList();
        }

     

        public void Update(MovimientoStock item, int id)
        {
            throw new NotImplementedException();
        }
    }
}
