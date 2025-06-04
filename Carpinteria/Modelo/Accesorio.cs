namespace Carpinteria.Modelo
{
    public class Accesorio : Insumo
    {

        public string Color { get; set; }
        public string Tipo { get; set; }

        public string Detalle { get; set; }

        public Accesorio(string nombre, string proveedor, int precio, string color, string tipo, string detalle)
        {
            Nombre = nombre;
            Proveedor = proveedor;
            Precio = precio;
            Color = color;
            Tipo = tipo;
            Detalle = detalle;
        }

    }
}
