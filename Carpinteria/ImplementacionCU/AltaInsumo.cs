using Carpinteria.DTO_s;
using Carpinteria.InterfaceRepositorio;
using Carpinteria.InterfacesCU;
using Carpinteria.Mappers;
using Carpinteria.Modelo;

namespace Carpinteria.ImplementacionCU
{
    public class AltaInsumo : IAltaInsumo
    {
        public IRepositorioInsumo RepoInsumos { get; set; }
        public IRepositorioStock RepoStock{ get; set; }

        public IRepositorioMovimientoStock RepoMovimiento { get; set; }
        public AltaInsumo(IRepositorioInsumo repoInsumos, IRepositorioStock repoStock, IRepositorioMovimientoStock repoMovimiento)
        {
            RepoInsumos = repoInsumos;
            RepoStock = repoStock;
            RepoMovimiento = repoMovimiento;
        }

        public void AltaPerfil(PerfilCreateDTO perfilCreateDTO)
        {

            //Creo un nuevo Perfil a partir del dto

            Perfil perfil = MapperPerfil.DTOPerfilTOPerfil(perfilCreateDTO);
 
            //Lo añado al repo de insumos
            RepoInsumos.Add(perfil);
            //se crea un registro en stock y se añade al repo de stok.
            Stock stock = MapperStock.CrearStock(DateTime.Now, DateTime.Now, perfilCreateDTO.Cantidad, perfil.InsumoId);
            RepoStock.Add(stock);
            //Aca podria crear los detalle del stock.


            // Crear DTO de movimiento
            MovimientoStock movimientoDTO = new MovimientoStock(DateTime.Now, "Alta", "Perfil", perfil.InsumoId,
                perfilCreateDTO.Cantidad, "Sistema", $"Alta de perfil {perfil.Nombre} ({perfil.SeriePerfil}) de color {perfil.Color} de largo {perfil.Largo}");

            // Registrar el movimiento en la tabla de movimientoStock
            RepoMovimiento.Add(movimientoDTO);
          
            
        }

        public void AltaVidrio(VidrioCreateDTO vidrioCreateDTO)
        {
            Vidrio vidrio = MapperVidrio.DTOVidrioTOVidrio(vidrioCreateDTO);

            RepoInsumos.Add(vidrio);

            Stock stock = MapperStock.CrearStock(DateTime.Now, DateTime.Now, vidrioCreateDTO.Cantidad, vidrio.InsumoId);

            RepoStock.Add(stock);

            // Crear DTO de vidrio
            MovimientoStock movimientoDTO = new MovimientoStock(DateTime.Now, "Alta", "Vidrio", vidrio.InsumoId,
                vidrioCreateDTO.Cantidad, "Sistema", $"Alta de Vidrio {vidrio.Nombre}, el tipo de vidrio es: {vidrio.TipoVidrio}, {vidrio.Espesor} de {vidrio.Ancho}X{vidrio.Largo}");

            // Registrar el movimiento
            RepoMovimiento.Add(movimientoDTO);

        }
        

        public void AltaAccesorio(AccesorioCreateDTO accesorioCreateDTO)
        {
            Accesorio accesorio = MapperAccesorio.DTOAccesorioTOAccesorio(accesorioCreateDTO);

            RepoInsumos.Add(accesorio);

            Stock stock = MapperStock.CrearStock(DateTime.Now, DateTime.Now, accesorioCreateDTO.Cantidad, accesorio.InsumoId);

            RepoStock.Add(stock);
            MovimientoStock movimientoDTO = new MovimientoStock(DateTime.Now, "Alta", "Accesorio", accesorio.InsumoId,
              accesorioCreateDTO.Cantidad, "Sistema", $"Alta de Accesorio {accesorio.Nombre} de color {accesorio.Color}, con detalle: {accesorio.Detalle}" );

            // Registrar el movimiento
            RepoMovimiento.Add(movimientoDTO);


        }
    }
}
