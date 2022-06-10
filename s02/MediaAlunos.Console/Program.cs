// See https://aka.ms/new-console-template for more information

float[] notas = new float[6];
int notaMaiorSete = 0;
int notaMenorSete = 0;
int notaMaiorZero = 0;
int notaZero = 0;

Console.Write("Informe a nota do primeiro aluno: ");
notas[0] = float.Parse(Console.ReadLine());

Console.Write("Informe a nota do segundo aluno: ");
notas[1] = float.Parse(Console.ReadLine());

Console.Write("Informe a nota do terceiro aluno: ");
notas[2] = float.Parse(Console.ReadLine());

Console.Write("Informe a nota do quarto aluno: ");
notas[3] = float.Parse(Console.ReadLine());

Console.Write("Informe a nota do quinto aluno: ");
notas[4] = float.Parse(Console.ReadLine());

Console.Write("Informe a nota do sexto aluno: ");
notas[5] = float.Parse(Console.ReadLine());


foreach (var nota in notas)
{

    if (nota > 7)
    {
        notaMaiorSete++;

    }

    if (nota < 7)
    {
        notaMenorSete++;

    }

    if (nota > 0)
    {
        notaMaiorZero++;
    }

    if (nota == 0)
    {
        notaZero++;
    }

}

Console.WriteLine($"Nota média da turma: {notas.Sum()}");
Console.WriteLine($"Alunos com nota maior que 7: {notaMaiorSete}");
Console.WriteLine($"Alunos com nota menor que 7: {notaMenorSete}");
Console.WriteLine($"Alunos com nota maior que 0: {notaMaiorZero}");
Console.WriteLine($"Alunos com nota igual a 0: {notaZero}");