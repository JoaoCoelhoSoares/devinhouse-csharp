public class Program
{
    public static void Main(string[] args)
    {
        Menu();
    }

    private static void Menu()
    {

        Console.WriteLine("\n Selecione o tipo de operação:");
        Console.WriteLine("1 - Adição");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.WriteLine("5 - Sair");

        int opcao = int.Parse(Console.ReadLine());
        var opcaoSelecionada = (OpcoesMenu)opcao;

        if (opcaoSelecionada == OpcoesMenu.Sair)
        {
            Console.WriteLine("\nObrigado por acessar a calculadora. Tchau!");
        }
        else
        {
            Console.Write("Informe o primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Informe o segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            Executar(opcaoSelecionada, numero1, numero2);
            Menu();

        }




    }

    private static void Executar(OpcoesMenu opcao, int num1, int num2)
    {
        switch (opcao)
        {
            case OpcoesMenu.Adicao:
                Console.WriteLine($"\nO resultado é: {num1 + num2}");
                break;
            case OpcoesMenu.Subtracao:
                Console.WriteLine($"\nO resultado é: {num1 - num2}");
                break;

            case OpcoesMenu.Multiplicacao:
                Console.WriteLine($"\nO resultado é: {num1 * num2}");
                break;

            case OpcoesMenu.Divisao:
                Console.WriteLine($"\nO resultado é: {num1 / num2}");
                break;

            default:
                Console.WriteLine("Não foi possível executar");
                break;

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
