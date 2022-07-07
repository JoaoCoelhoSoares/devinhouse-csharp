namespace BoletimNamespace.Exceptions
{
    public class ValorNotaInvalidoException : Exception
    {
        private const string Mensagem = "O valor informado é inválido. Apenas valores entre 0 e 10 são aceitos.";

        public ValorNotaInvalidoException() : base(
            string.Format(Mensagem))
        {
        }

        public ValorNotaInvalidoException(Exception innerException) : base(
         string.Format(Mensagem), innerException)
        {
        }
    }
}