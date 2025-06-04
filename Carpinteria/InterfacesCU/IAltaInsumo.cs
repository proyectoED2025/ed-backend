using Carpinteria.DTO_s;

namespace Carpinteria.InterfacesCU
{
    public interface IAltaInsumo
    {
        void AltaPerfil(PerfilCreateDTO perfilCreateDTO);

        void AltaVidrio(VidrioCreateDTO vidrioCreateDTO);

        
        void AltaAccesorio(AccesorioCreateDTO accesorioCreateDTO);
    }
}
