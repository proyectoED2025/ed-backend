namespace Carpinteria.Modelo
{
    public class Vidrio : Insumo
    {
       

        public string Espesor {  get; set; }

        public double Largo { get; set; }

        public double Ancho { get; set; }

        public TipoVidrio TipoVidrio { get; set; }// enum

        public Vidrio(string nombre, string proveedor, int precio, string espesor, double largo, double ancho, TipoVidrio tipoVidrio)
        {
            Nombre = nombre;
            Proveedor = proveedor;
            Precio = precio;
            Espesor = espesor;
            Largo = largo;
            Ancho = ancho;
            TipoVidrio = tipoVidrio;
        }
    }
}
