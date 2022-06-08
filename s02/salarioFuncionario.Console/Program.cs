// See https://aka.ms/new-console-template for more information

int anoAtual = 2022;

Console.Write("Informe o nome do funcionário: ");
string nome = Console.ReadLine();

Console.Write("Informe o ano de nascimento do funcionário: ");
int anoNascimento = int.Parse(Console.ReadLine());

Console.Write("Informe o salário do funcionário: ");
float salario = float.Parse(Console.ReadLine());

Console.Write("Informe o % de reajuste do funcionário: ");
float reajuste = float.Parse(Console.ReadLine());


Console.WriteLine($"Olá {nome}, você possui {anoAtual - anoNascimento} idade. Tendo em vista o reajuste de {reajuste}%, seu salário será R${salario + (salario * reajuste / 100)}.");
