using Ex6.Exceptions;

namespace Ex6
{
    public class ContaBancaria
    {
        public ContaBancaria(string numero, decimal saldo, decimal limiteSaque, bool operacional)
        {
            this.Numero = numero;
            this.Saldo = saldo;
            this.LimiteSaque = limiteSaque;
            this.Operacional = operacional;
        }
        public string Numero { get; set; }
        public decimal Saldo { get; set; }
        public decimal LimiteSaque { get; set; }
        public bool Operacional { get; set; }

        public void Depositar(decimal valor)
        {
            VerificarContaOperacional();

            if (valor <= 0)
            {
                //throw new ValorOperacaoZeroOuNegativoException();
            }

            Saldo += valor;
        }

        public void Sacar(decimal valor)
        {
            VerificarContaOperacional();

            if (valor <= 0)
            {
                //throw new ValorOperacaoZeroOuNegativoException();
            }

            if (valor > Saldo)
            {
                throw new SaldoInsuficienteException();
            }

            if (valor > LimiteSaque)
            {
                throw new ValorSaqueAcimaLimiteException();
            }

            Saldo -= valor;

        }

        public decimal InformarSaldo()
        {
            VerificarContaOperacional();

            return Saldo;

        }

        private void VerificarContaOperacional()
        {
            if (!Operacional) throw new ContaNaoOperacionalException(Numero);
        }


    }
}