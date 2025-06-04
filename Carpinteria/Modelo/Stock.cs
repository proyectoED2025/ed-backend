using System.ComponentModel.DataAnnotations;

namespace Carpinteria.Modelo
{
    public class Stock
    {
        
       

        [Key]
        public int Id { get; set; }
        public DateTime FechaActualizacion {  get; set; }

        public DateTime FechaCreacion { get; set; }//No creo que sea necesario, por ahora, vamos a usar la misma fecha que la
                                                    //de actualizacion
       
        public int Cantidad {  get; set; }


        //Esto no se si se queda, se esta guardando como null y ya tengo insumoID. 
        //Lo voy a dejar por las dudas, si no lo uso, lo elimino.
        public Insumo Insumo { get; set; }

        public int InsumoId { get; set; }
        public Stock( DateTime fechaCreacion, DateTime fechaActualizacion, int cantidad, int insumoId)
        {
           
            FechaCreacion = fechaCreacion;
            FechaActualizacion = fechaActualizacion;
            Cantidad = cantidad;
            InsumoId = insumoId;
        }


    }
}
