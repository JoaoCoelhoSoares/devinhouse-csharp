using Xunit;
using Ex6.Exceptions;

namespace Ex6.Tests
{
    public class ContaBancariaTest
    {

        private const decimal SaldoBase = 5000;
        private const decimal LimiteSaqueBase = 5000;

        private ContaBancaria CriarContaBancariaOperacional(bool operacional)
        {
            return new ContaBancaria(
                "1234",
                SaldoBase,
                LimiteSaqueBase,
                operacional
            );
        }

        [Fact]

        public void Deveria_Cadastrar_Conta()
        {
            // PREPARAÇÃO
            var numeroConta = "1234";
            var conta = CriarContaBancariaOperacional(true);

            // EXECUÇÃO

            // VALIDAÇÃO DO RESULTADO
            Assert.NotNull(conta);
            Assert.Equal(conta.Numero, numeroConta);
        }

        [Fact]
        public void Deveria_Efetuar_Deposito()
        {
            // PREPARAÇÃO
            var valorDeposito = 500;
            var valorEsperado = 5500;
            var conta = CriarContaBancariaOperacional(true);

            // EXECUÇÃO
            conta.Depositar(valorDeposito);

            // VALIDAÇÃO DO RESULTADO
            Assert.Equal(conta.Saldo, valorEsperado);
        }

        [Fact]
        public void Nao_Deveria_Efetuar_Deposito_Em_Conta_NaoOperacional()
        {
            Assert.Throws<ContaNaoOperacionalException>(
                () =>
                {
                    // PREPARAÇÃO
                    var valorDeposito = 500;
                    var conta = CriarContaBancariaOperacional(false);

                    // EXECUÇÃO
                    conta.Depositar(valorDeposito);
                });
        }

        [Fact]
        public void Deveria_Efetuar_Saque()
        {
            // PREPARAÇÃO
            var valorSaque = 300;
            var valorEsperado = SaldoBase - valorSaque;  //4700
            var conta = CriarContaBancariaOperacional(true);

            // EXECUÇÃO
            conta.Sacar(valorSaque);

            // VALIDAÇÃO DO RESULTADO
            Assert.Equal(conta.Saldo, valorEsperado);
        }

        [Fact]
        public void Nao_Deveria_Efetuar_Saque_Quando_Valor_Eh_Maior_Saldo()
        {
            // VALIDAÇÃO DO RESULTADO
            Assert.Throws<SaldoInsuficienteException>(
                () =>
                {
                    // PREPARAÇÃO
                    var valorSaque = SaldoBase + 100;
                    var conta = CriarContaBancariaOperacional(true);

                    // EXECUÇÃO
                    conta.Sacar(valorSaque);
                });
        }

        [Fact]
        public void Nao_Deveria_Efetuar_Saque_Quando_Valor_Eh_Maior_LimiteSaque()
        {
            // VALIDAÇÃO DO RESULTADO
            Assert.Throws<ValorSaqueAcimaLimiteException>(
                () =>
                {
                    // PREPARAÇÃO
                    var valorSaque = LimiteSaqueBase + 100;
                    var conta = CriarContaBancariaOperacional(true);

                    // EXECUÇÃO
                    conta.Sacar(valorSaque);
                });
        }

    }
}