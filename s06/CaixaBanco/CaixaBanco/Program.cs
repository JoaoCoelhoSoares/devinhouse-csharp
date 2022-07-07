using CaixaBanco;

var contas = new[]
{
    new Conta("1234", 5000, 1000, true),
    new Conta("4321", 15000, 5000, false),
    new Conta("5678", 80, 500, true),
};

EnumMenu opcaoSelecionada = EnumMenu.ConsultarLimite;

while (opcaoSelecionada != EnumMenu.Sair)
{
    Console.WriteLine("\n Escolha a conta desejada:");

    for (var i = 1; i < contas.Length + 1; i++)
    {
        var item = contas.ElementAt(i - 1);

        Console.WriteLine($"{i} - Conta nº: {item.Numero}.");
    }

    var indiceValido = int.TryParse(Console.ReadLine(), out var indiceSelecionado);

    if (!indiceValido || indiceSelecionado > 3)
    {
        Console.WriteLine($"Indice inválido {Environment.NewLine}");
        continue;
    }

    var contaSelecionada = contas.ElementAt(indiceSelecionado - 1);

    Console.WriteLine($"{Environment.NewLine}Selecione a operação:");
    Console.WriteLine("1 - Consultar Limite");
    Console.WriteLine("2 - Sacar");
    Console.WriteLine("3 - Depositar");
    Console.WriteLine("0 - Sair");

    var operacaoValida = EnumMenu.TryParse(Console.ReadLine(), out opcaoSelecionada);

    if (!operacaoValida || opcaoSelecionada != EnumMenu.ConsultarLimite && opcaoSelecionada != EnumMenu.Depositar && opcaoSelecionada != EnumMenu.Sacar)
    {
        Console.WriteLine($"Operação inválida {Environment.NewLine}");
        continue;
    }

    try
    {
        switch (opcaoSelecionada)
        {
            case EnumMenu.ConsultarLimite:
                Console.WriteLine($"Saldo: {contaSelecionada.InformarSaldo()}");
                break;
            case EnumMenu.Sacar:
                Console.WriteLine("Informe um valor para saque:");
                var valorValido = decimal.TryParse(Console.ReadLine(), out var valorSaque);

                if (!valorValido)
                {
                    Console.WriteLine($"Valor inválido {Environment.NewLine}");
                    continue;
                }

                contaSelecionada.Sacar(valorSaque);

                Console.WriteLine($"Novo saldo após saque: {contaSelecionada.InformarSaldo()}");
                break;
            case EnumMenu.Depositar:
                Console.WriteLine("Informe um valor para depositar:");
                var valorDepositoValido = decimal.TryParse(Console.ReadLine(), out var valorDeposito);

                if (!valorDepositoValido)
                {
                    Console.WriteLine($"Valor inválido {Environment.NewLine}");
                    continue;
                }

                contaSelecionada.Depositar(valorDeposito);

                Console.WriteLine($"Novo saldo após depósito: {contaSelecionada.InformarSaldo()}");
                break;
        }
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exceção {e.GetType().Name} capturada com a mensagem {e.Message} {Environment.NewLine}");
        continue;
    }

    Console.WriteLine(Environment.NewLine);
}