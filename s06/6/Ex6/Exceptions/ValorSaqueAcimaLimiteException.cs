namespace Ex6.Exceptions
{
    public class ValorSaqueAcimaLimiteException : Exception
    {
        private const string Mensagem = "A conta {0} não possui saldo suficiente.";
        public ValorSaqueAcimaLimiteException() : base(
                   string.Format(Mensagem)
               )
        {
        }

    }
}