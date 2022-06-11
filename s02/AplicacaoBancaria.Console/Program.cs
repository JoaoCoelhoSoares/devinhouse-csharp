public class Program
{
    private static List<string> listaOperacoes = new List<string>();
    private static int saldo = 0;

    public static void Main(string[] args)
    {

        Menu();

    }

    private static void Menu()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\n ------DevInBank------");
        Console.WriteLine("\n Operação disponíveis:");
        Console.WriteLine("1 - Consulta saldo");
        Console.WriteLine("2 - Depósito");
        Console.WriteLine("3 - Saque");
        Console.WriteLine("4 - Histórico");
        Console.WriteLine("5 - Sair");

        Console.Write("\n Selecione o tipo de operação: ");
        int opcao = int.Parse(Console.ReadLine());
        var opcaoSelecionada = (OpcoesMenu)opcao;

        if (opcaoSelecionada == OpcoesMenu.Sair)
        {
            Console.WriteLine("\nObrigado por ser cliente do DevInBank.");
            return;
        }
        else
        {
            Executar(opcaoSelecionada);
            Menu();
        }
    }

    private static void Executar(OpcoesMenu resposta)
    {
        switch (resposta)
        {
            case OpcoesMenu.Saldo:
                Console.WriteLine($"\nO saldo atual é: {saldo}");
                break;

            case OpcoesMenu.Deposito:
                Deposito();
                break;

            case OpcoesMenu.Saque:
                Saque();
                break;

            case OpcoesMenu.Historico:
                Histórico();
                break;

            default:
                break;
        }


    }

    private static void Deposito()
    {
        Console.Write("\n Informe o valor do depósito: ");
        int valorDeposito = int.Parse(Console.ReadLine());

        if (valorDeposito < 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nOperação inválida! O valor informado ({valorDeposito}) é negativo.");
        }
        else
        {
            saldo = saldo + valorDeposito;
            listaOperacoes.Add($"- Depósito no valor de R${valorDeposito}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nDeposito no valor {valorDeposito} realizado com sucesso.");
        }
    }

    private static void Saque()
    {
        Console.Write("\n Informe o valor do depósito: ");
        int valorSaque = int.Parse(Console.ReadLine());

        if (saldo - valorSaque < 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nOperação inválida! Você não possui saldo suficiente.");
        }
        else
        {
            saldo = saldo - valorSaque;
            listaOperacoes.Add($"- Saque no valor de R${valorSaque}");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nSaque no valor {valorSaque} realizado com sucesso.");
        }

    }

    private static void Histórico()
    {
        foreach (var operacao in listaOperacoes)
        {
            Console.WriteLine(operacao);
        }
    }

    public enum OpcoesMenu
    {
        Saldo,  // 0
        Deposito,  // 1
        Saque,  // 2
        Historico,    //3
        Sair    // 4
    }
}
