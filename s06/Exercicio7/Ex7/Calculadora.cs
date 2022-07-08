using Ex7.Exceptions;

namespace Ex7
{
    public static class Calculadora
    {
        private static void VerificaValorNulo(int valor)
        {
            if (valor == null) throw new ValorNuloException();
        }

        public static float Executar(OpcoesMenu opcao, int num1, int num2)
        {
            switch (opcao)
            {
                case OpcoesMenu.Adicao: return num1 + num2;

                case OpcoesMenu.Subtracao: return num1 - num2;

                case OpcoesMenu.Multiplicacao: return num1 * num2;

                case OpcoesMenu.Divisao: return num1 / num2;

                default:
                    throw new OpcaoInvalidaException();
            }
        }
    }

    public enum OpcoesMenu
    {
        Adicao = 1,
        Subtracao,
        Multiplicacao,
        Divisao,
        Sair
    }

}

