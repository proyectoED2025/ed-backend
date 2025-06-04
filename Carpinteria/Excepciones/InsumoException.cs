namespace Carpinteria.Excepciones
{
    public class InsumoException : Exception
    {
        public InsumoException() { }

        public InsumoException(string message) : base(message) { }

        public InsumoException(string message, Exception innerException) : base(message, innerException) { }

    }
}
