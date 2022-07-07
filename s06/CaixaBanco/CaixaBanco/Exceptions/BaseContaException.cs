namespace CaixaBanco.Exceptions
{
    public class BaseContaException : Exception
    {
        public string NumeroConta { get; set; }

        public BaseContaException(
            string message,
            string numeroConta
        ) : base(
            message
        )
        {
            NumeroConta = numeroConta;
        }

        public BaseContaException(
            string message,
            string numeroConta,
            Exception innerException
        ) : base(
            message,
            innerException
        )
        {
            NumeroConta = numeroConta;
        }
    }
}