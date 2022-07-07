using CaixaBanco.Exceptions;

namespace CaixaBanco
{
    public class Conta
    {
        public Conta(string numero, decimal saldo, decimal limiteSaque, bool operacional)
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
                throw new ValorOperacaoZeroOuNegativoException();
            }

            Saldo += valor;
        }

        public void Sacar(decimal valor)
        {
            VerificarContaOperacional();

            if (valor <= 0)
            {
                throw new ValorOperacaoZeroOuNegativoException();
            }

            if (valor > Saldo)
            {
                throw new SaldoInsuficienteException(Numero);
            }

            if (valor > LimiteSaque)
            {
                throw new ValorSaqueAcimaLimiteException(Numero);
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