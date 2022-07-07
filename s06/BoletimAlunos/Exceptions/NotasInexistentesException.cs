namespace BoletimNamespace.Exceptions
{
    public class NotasInexistentesException : Exception
    {
        private const string Mensagem = "Nenhuma nota cadastrada.";

        public NotasInexistentesException() : base(
            string.Format(Mensagem))
        {
        }

        public NotasInexistentesException(Exception innerException) : base(
         string.Format(Mensagem), innerException)
        {
        }
    }
}