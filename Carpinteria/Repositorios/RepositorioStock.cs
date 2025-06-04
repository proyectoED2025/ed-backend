using Carpinteria.Data;
using Carpinteria.Excepciones;
using Carpinteria.InterfaceRepositorio;
using Carpinteria.Modelo;

namespace Carpinteria.Repositorios
{
    public class RepositorioStock : IRepositorioStock
    {
        public CarpinteriaContext Contexto { get; set; }

        public RepositorioStock(CarpinteriaContext contexto)
        {
            Contexto = contexto;
        }
        public void Add(Stock item)
        {
            Contexto.Stocks.Add(item);
            Contexto.SaveChanges();
            
        }
        public Stock FindById(int id)
        {
            var stock = Contexto.Stocks.FirstOrDefault(s => s.Id == id);
            if (stock == null)
                throw new StockException($"No se encontró el stock con ID {id}.");

            return stock;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Stock> FindAll()
        {
            throw new NotImplementedException();
        }



        public void Update(Stock stock, int id)
        {
            Contexto.Stocks.Update(stock);
            Contexto.SaveChanges();
        }


        public Stock FindByIdInsumo(int insumoId)
        {
            Stock stock = Contexto.Stocks.FirstOrDefault(s => s.InsumoId == insumoId);
            if (stock == null)
                throw new StockException($"No se encontró el stock con ID {insumoId}.");

            return stock;
        }
    }
}
