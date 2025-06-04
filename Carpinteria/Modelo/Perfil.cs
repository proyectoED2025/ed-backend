namespace Carpinteria.Modelo
{
    public class Perfil : Insumo
    {
       

       
        public double Peso { get; set; }

        public double PesoPorMetro { get; set; }

        public string Color { get; set; }

        public string Largo { get; set; }

        public SeriePerfiles SeriePerfil {  get; set; }//ENUM
        public Perfil(string nombre, string proveedor, int precio, double peso, double pesoPorMetro, string largo, string color, SeriePerfiles seriePerfil)
        {
            Nombre = nombre;
            Proveedor = proveedor;
            Precio = precio;
            Peso = peso;
            PesoPorMetro = pesoPorMetro;
            Largo = largo;
            Color = color;
            SeriePerfil = seriePerfil;
        }

    }
}
