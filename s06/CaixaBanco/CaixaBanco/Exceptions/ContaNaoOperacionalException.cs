namespace CaixaBanco.Exceptions
{
    public class ContaNaoOperacionalException : BaseContaException
    {
        private const string Mensagem = "A conta {0} não está operacional.";

        public ContaNaoOperacionalException(string numeroConta) : base(
           string.Format(Mensagem, numeroConta), numeroConta
        )
        {
            NumeroConta = numeroConta;
        }

        public ContaNaoOperacionalException(
        string numeroConta,
        Exception innerException
    ) : base(
        string.Format(Mensagem, numeroConta),
        numeroConta,
        innerException
    )
        {
            NumeroConta = numeroConta;
        }

    }
}