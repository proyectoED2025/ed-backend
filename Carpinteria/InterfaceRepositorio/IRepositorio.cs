namespace Carpinteria.InterfaceRepositorio
{
   public interface IRepositorio<T>
    {
        void Add(T item);
        void Delete(int id);
        void Update(T item,int id);
        T FindById(int id);
        IEnumerable<T> FindAll();
    }
}
