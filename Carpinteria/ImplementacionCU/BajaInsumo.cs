using Carpinteria.DTO_s;
using Carpinteria.DTO_s.Accesorio;
using Carpinteria.DTO_s.Vidrio;
using Carpinteria.Excepciones;
using Carpinteria.InterfaceRepositorio;
using Carpinteria.InterfacesCU;
using Carpinteria.Modelo;

namespace Carpinteria.ImplementacionCU
{
    public class BajaInsumo : IBajaInsumo
    {
        public IRepositorioInsumo RepoInsumos { get; set; }
        public IRegistrarMovimiento RepoMovimiento { get; set; }
        public IRepositorioStock RepoStock{ get; set; }

        public BajaInsumo(IRepositorioInsumo repoInsumos, IRegistrarMovimiento repoMovimiento, IRepositorioStock repoStock)
        {
            RepoInsumos = repoInsumos;
            RepoMovimiento = repoMovimiento;
            RepoStock = repoStock;
        }

        public void BajaPerfil(DeletePerfilDTO dto)
        {  /////////////////////////////////////////// Se elimina del stock automaticamente
            if (dto == null || dto.InsumoId <= 0)
                throw new InsumoException("Datos inválidos para eliminar el perfil.");

            
            Insumo perfilAEliminar = RepoInsumos.FindById(dto.InsumoId);

            Stock registroDelStock = RepoStock.FindByIdInsumo(dto.InsumoId);
           
           
            MovimientoStock movimiento = new MovimientoStock
            (DateTime.Now, "Baja", "Perfil", dto.InsumoId,
            registroDelStock.Cantidad, "Sistema", $"Baja del perfil {perfilAEliminar.Nombre}");

            RepoMovimiento.Ejecutar(movimiento);
            RepoInsumos.Delete(dto.InsumoId);
        }
        public void BajaVidrio(DeleteVidrioDTO dto)
        {   /////////////////////////////////////////// Se elimina del stock automaticamente
            if (dto == null || dto.InsumoId <= 0)
                throw new InsumoException("Datos inválidos para eliminar el vidrio.");

            //obtengo el vidrio por InsumoId
            Insumo vidrioAEliminar = RepoInsumos.FindById(dto.InsumoId);

            if (vidrioAEliminar is not Vidrio vidrio)
                throw new InsumoException("El insumo especificado no es un vidrio.");
            
            
            ///Obtengo el stock relacionado con el insumoId
            Stock registroDelStock = RepoStock.FindByIdInsumo(dto.InsumoId);

            //Registro el movimiento
            MovimientoStock movimiento = new MovimientoStock(DateTime.Now, "Baja", "Vidrio", dto.InsumoId,
            registroDelStock.Cantidad, "Sistema", dto.Motivo ?? $"Baja del vidrio {vidrio.Nombre}");
            RepoMovimiento.Ejecutar(movimiento);
            //Elimino de los insumos el vidrio
            RepoInsumos.Delete(dto.InsumoId);
        }
        public void BajaAccesorio(DeleteAccesorioDTO dto)
        { /////////////////////////////////////////// Se elimina del stock automaticamente
            if (dto == null || dto.InsumoId <= 0)
                throw new InsumoException("Datos inválidos para eliminar el Accesorio.");
            //Obtengo el accesorio a eliminar por el InsumoId
            Insumo accesorioAEliminar = RepoInsumos.FindById(dto.InsumoId);

            if (accesorioAEliminar is not Accesorio accesorio)
                throw new InsumoException("El insumo especificado no es un accesorio.");
           
            ///Obtengo el stock relacionado con el insumoId
            Stock registroDelStock = RepoStock.FindByIdInsumo(dto.InsumoId);
            //Registro el movimiento en la tabla de movimiento
            MovimientoStock movimiento = new MovimientoStock(DateTime.Now, "Baja", "Accesorio", accesorio.InsumoId,
            registroDelStock.Cantidad, "Sistema", $"Baja de Accesorio {accesorio.Nombre} de color {accesorio.Color}, con detalle: {accesorio.Detalle}");
            RepoMovimiento.Ejecutar(movimiento);
            //Elimino el registro en la tabla de insumos
            RepoInsumos.Delete(dto.InsumoId);
        }

    }
}
