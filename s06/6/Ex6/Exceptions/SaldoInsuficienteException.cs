namespace Ex6.Exceptions
{
    public class SaldoInsuficienteException : Exception
    {
        private const string Mensagem = "A conta {0} não possui saldo suficiente.";
        public SaldoInsuficienteException() : base(
                   string.Format(Mensagem)
               )
        {
        }


    }
}