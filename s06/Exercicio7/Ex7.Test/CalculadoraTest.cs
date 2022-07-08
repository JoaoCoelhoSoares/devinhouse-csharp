using Xunit;
using Ex7.Exceptions;

namespace Ex7.Test
{
    public class CalculadoraTest
    {
        private const int Num1Base = 10;
        private const int Num2Base = 5;

        [Fact]

        public void Deveria_Realizar_Adicao()
        {
            // PREPARAÇÃO
            var resultadoEsperado = Num1Base + Num2Base;

            // EXECUÇÃO
            var resultadoCalculadora = Calculadora.Executar(OpcoesMenu.Adicao, Num1Base, Num2Base);

            // VALIDAÇÃO DO RESULTADO
            Assert.Equal(resultadoCalculadora, resultadoEsperado);
        }

        [Fact]

        public void Deveria_Realizar_Divisao()
        {
            // PREPARAÇÃO
            var resultadoEsperado = Num1Base / Num2Base;

            // EXECUÇÃO
            var resultadoCalculadora = Calculadora.Executar(OpcoesMenu.Divisao, Num1Base, Num2Base);

            // VALIDAÇÃO DO RESULTADO
            Assert.Equal(resultadoCalculadora, resultadoEsperado);
        }

        [Fact]

        public void Deveria_Realizar_Multiplicacao()
        {
            // PREPARAÇÃO
            var resultadoEsperado = Num1Base * Num2Base;

            // EXECUÇÃO
            var resultadoCalculadora = Calculadora.Executar(OpcoesMenu.Multiplicacao, Num1Base, Num2Base);

            // VALIDAÇÃO DO RESULTADO
            Assert.Equal(resultadoCalculadora, resultadoEsperado);
        }

        [Fact]

        public void Deveria_Realizar_Subtracao()
        {
            // PREPARAÇÃO
            var resultadoEsperado = Num1Base - Num2Base;

            // EXECUÇÃO
            var resultadoCalculadora = Calculadora.Executar(OpcoesMenu.Subtracao, Num1Base, Num2Base);

            // VALIDAÇÃO DO RESULTADO
            Assert.Equal(resultadoCalculadora, resultadoEsperado);
        }

        [Fact]
        public void Deveria_Informar_Opcao_Invalida()
        {
            // VALIDAÇÃO DO RESULTADO
            Assert.Throws<OpcaoInvalidaException>(
                () =>
                {
                    Calculadora.Executar(OpcoesMenu.Errado, Num1Base, Num2Base);
                });
        }

        [Fact]
        public void Deveria_Informar_Valor_Nulo()
        {
            // VALIDAÇÃO DO RESULTADO
            Assert.Throws<ValorNuloException>(
                () =>
                {
                    Calculadora.Executar(OpcoesMenu.Adicao, Num1Base, null);
                });
        }

    }
}