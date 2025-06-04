using Carpinteria.Data;
using Carpinteria.Excepciones;
using Carpinteria.InterfaceRepositorio;
using Carpinteria.Modelo;
using Microsoft.EntityFrameworkCore;

namespace Carpinteria.Repositorios
{
    public class RepositorioInsumo : IRepositorioInsumo
    {

        public CarpinteriaContext Contexto { get; set; }

        public RepositorioInsumo(CarpinteriaContext contexto)
        {
            Contexto = contexto;
        }

        public void Add(Insumo item)
        {

            Contexto.Add(item);
            Contexto.SaveChanges();
            //throw new NotImplementedException();
        }
        public Insumo FindById(int id)
        {
            Insumo insumo = Contexto.Insumos.FirstOrDefault(i => i.InsumoId == id);
            if (insumo == null)
                throw new InsumoException($"No se encontró un insumo con ID {id}.");

            return insumo;
        }
        public void Delete(int id)
        {
            var insumo = FindById(id);
            if (insumo != null)
            {
                Contexto.Insumos.Remove(insumo);
                Contexto.SaveChanges();
            }
            else
            {
                throw new InsumoException("No se encontró el insumo a eliminar.");
            }
        }
        public IEnumerable<Insumo> FindAll()
        {
            throw new NotImplementedException();
        }


        public void Update(Insumo item, int id)
        {

            Contexto.Update(item);
            Contexto.SaveChanges();
        }

    }
}
