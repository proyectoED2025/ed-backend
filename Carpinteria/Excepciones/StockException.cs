namespace Carpinteria.Excepciones
{
    public class StockException :Exception
    {
        public StockException() { }

        public StockException(string message) : base(message) { }

        public StockException(string message, Exception innerException) : base(message, innerException) { }
    }
}
