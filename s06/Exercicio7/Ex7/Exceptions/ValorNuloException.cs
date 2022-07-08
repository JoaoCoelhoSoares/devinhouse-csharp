namespace Ex7.Exceptions
{
    public class ValorNuloException : Exception
    {
        private const string Mensagem = "O valor informado é nulo ou não é um número.";

        public ValorNuloException() : base(
            string.Format(Mensagem)
        )
        {
        }

        public ValorNuloException(Exception innerException) : base(
         string.Format(Mensagem), innerException)
        {
        }
    }
}