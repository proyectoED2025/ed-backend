namespace Carpinteria.Modelo
{
    public class MovimientoStock
    {
       

        public MovimientoStock(DateTime fecha, string tipo, string insumo, int insumoId, int cantidad, string usuario, string observaciones)
        {
            Fecha = fecha;
            Tipo = tipo;
            Insumo = insumo;
            InsumoId = insumoId;
            Cantidad = cantidad;
            Usuario = usuario;
            Observaciones = observaciones;
        }

        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; } // Alta, Baja, Modificación
        public string Insumo { get; set; } // Perfil, Vidrio, Accesorio
        public int InsumoId { get; set; }
        public int Cantidad { get; set; }
        public string Usuario { get; set; }
        public string Observaciones { get; set; }
    }
}
