using Calculadora.Exceptions;

internal class Program
{
    private static void Main(string[] args)
    {
        OpcoesMenu opcao = OpcoesMenu.Adicao;

        while (opcao != OpcoesMenu.Sair)
        {
            Console.WriteLine("\n Selecione o tipo de operação:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");

            try
            {
                var opcaoSelecionada = Enum.TryParse(Console.ReadLine(), out opcao);

                if (opcao == OpcoesMenu.Sair)
                {
                    Console.WriteLine("\nObrigado por acessar a calculadora.");
                }
                else if (opcao != OpcoesMenu.Adicao && opcao != OpcoesMenu.Divisao && opcao != OpcoesMenu.Multiplicacao && opcao != OpcoesMenu.Subtracao)
                {
                    throw new OpcaoInvalidaException();
                }
                else
                {
                    Console.Write("Informe o primeiro número: ");
                    int numero1 = int.Parse(Console.ReadLine());

                    VerificaValorNulo(numero1);

                    Console.Write("Informe o segundo número: ");
                    int numero2 = int.Parse(Console.ReadLine());

                    VerificaValorNulo(numero2);

                    Console.WriteLine($"\nO resultado é: {Executar(opcao, numero1, numero2)}");
                }
            }
            catch (System.Exception e)
            {
                Console.WriteLine(@$"Exceção {e.GetType().Name} capturada com a mensagem:
                 {e.Message} {Environment.NewLine}");
                continue;
            }
        }

    }

    private static void VerificaValorNulo(int valor)
    {
        if (valor == null) throw new ValorNuloException();
    }

    private static float Executar(OpcoesMenu opcao, int num1, int num2)
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