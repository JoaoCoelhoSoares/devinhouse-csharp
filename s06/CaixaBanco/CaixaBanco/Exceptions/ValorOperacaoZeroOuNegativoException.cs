namespace CaixaBanco.Exceptions
{
    public class ValorOperacaoZeroOuNegativoException : Exception
    {
        private const string Mensagem = "O valor da operação não pode ser zerado ou negativo.";

        public ValorOperacaoZeroOuNegativoException() : base(
            Mensagem
        )
        {
        }

        public ValorOperacaoZeroOuNegativoException(
            Exception innerException
        ) : base(
            Mensagem,
            innerException
        )
        {
        }
    }
}