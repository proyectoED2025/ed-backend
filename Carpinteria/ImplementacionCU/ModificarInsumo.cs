using Carpinteria.DTO_s;
using Carpinteria.Excepciones;
using Carpinteria.InterfaceRepositorio;
using Carpinteria.InterfacesCU;
using Carpinteria.Mappers;
using Carpinteria.Modelo;

namespace Carpinteria.ImplementacionCU
{
    public class ModificarInsumo : IModificarInsumo
    {
        private readonly IRepositorioInsumo RepoInsumos;
        private readonly IRepositorioMovimientoStock RepoMovimientos;
        private readonly IRepositorioStock RepoStock;

        public ModificarInsumo(IRepositorioInsumo repoInsumos, IRepositorioMovimientoStock repoMovimientos, IRepositorioStock repoStock)
        {
            RepoInsumos = repoInsumos;
            RepoMovimientos = repoMovimientos;
            RepoStock = repoStock;
        }

        public void ModificarPerfil(ModificarPerfilDTO dto)
        {

            //Obtengo el perfil.
            Insumo existente = RepoInsumos.FindById(dto.InsumoId);

            if (existente is not Perfil perfil)
                throw new InsumoException("El insumo especificado no es un perfil.");

            perfil.Nombre = dto.Nombre;
            perfil.Proveedor = dto.Proveedor;
            perfil.Precio = dto.Precio;
            perfil.Peso = dto.Peso;
            perfil.PesoPorMetro = dto.PesoPorMetro;
            perfil.Largo = dto.Largo;
            perfil.Color = dto.Color;
            perfil.SeriePerfil = dto.SeriePerfil;

           // Perfil actualizado = MapperPerfil.DTOPerfilModificadoToPerfil(dto);
            
            RepoInsumos.Update(perfil,perfil.InsumoId);

            //Obtengo el stock y lo modifico
            Stock registroDelStock = RepoStock.FindByIdInsumo(dto.InsumoId);

            if (registroDelStock == null)
                throw new InsumoException($"No hay registro en el Stock del insumo con Id: {dto.InsumoId}");
            registroDelStock.Cantidad = dto.NuevaCantidad;
            registroDelStock.FechaActualizacion = DateTime.Now;

            RepoStock.Update(registroDelStock, registroDelStock.Id );
            // creo un objeto moviemiento y lo agrego a los registros
            MovimientoStock movimiento = new MovimientoStock
            (
                 DateTime.Now,
                "Modificación",
                "Perfil",
                dto.InsumoId,
                dto.NuevaCantidad,
                "Sistema",
                $"Modificación del perfil {dto.Nombre}"
            );

            RepoMovimientos.Add(movimiento);
        }
    }
}
