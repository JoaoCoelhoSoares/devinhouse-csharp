public class Program
{
    public static void Main(string[] args)
    {
        OpcoesMenu opcaoSelecionada = OpcoesMenu.Adicao;
        while (opcaoSelecionada != OpcoesMenu.Sair)
        {
            Console.WriteLine("\n Selecione o tipo de operação:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");

            string resposta = Console.ReadLine().ToUpper();


            if (resposta == "5")
            {
                Console.WriteLine("\nObrigado por acessar a calculadora. Tchau!");
                break;
            }
            else
            {
                Console.Write("Informe o primeiro número: ");
                int numero1 = int.Parse(Console.ReadLine());


                Console.Write("Informe o segundo número: ");
                int numero2 = int.Parse(Console.ReadLine());

                Console.WriteLine($"\nO resultado é: {Executar(resposta, numero1, numero2)}");

            }

        }
    }

    private static int Executar(string resposta, int numero1, int numero2)
    {
        switch (resposta)
        {
            case "1":
                return numero1 + numero2;

            case "2":
                return numero1 - numero2;

            case "3":
                return numero1 * numero2;

            case "4":
                return numero1 / numero2;

            default:
                return 0;
        }


    }



    public enum OpcoesMenu
    {
        Adicao,  // 0
        Subtracao,  // 1
        Multiplicacao,  // 2
        Divisao,    //3
        Sair    // 4
    }
}
