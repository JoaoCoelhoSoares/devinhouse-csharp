namespace Calculadora.Exceptions
{
    public class OpcaoInvalidaException : Exception
    {
        private const string Mensagem = "A opção informada é inválida.";

        public OpcaoInvalidaException() : base(
            string.Format(Mensagem)
        )
        {

        }

        public OpcaoInvalidaException(Exception innerException) : base(
         string.Format(Mensagem), innerException
     )
        {

        }
    }
}