using Carpinteria.DTO_s;
using Carpinteria.DTO_s.Accesorio;
using Carpinteria.DTO_s.Vidrio;

namespace Carpinteria.InterfacesCU
{
    public interface IBajaInsumo
    {
        void BajaPerfil(DeletePerfilDTO dto);

        void BajaVidrio(DeleteVidrioDTO dto);

        void BajaAccesorio(DeleteAccesorioDTO dto);


    }
}
