using BoletimNamespace.Dominio;
using BoletimNamespace.Exceptions;

var alunos = new[]
{
   new Aluno(1, "Rodrigo Raiche"),
   new Aluno(2, "José Alfredo"),
   new Aluno(3, "Janaina Alves"),
   new Aluno(4, "Liliane Oliveira")
 };

var disciplinas = new[]
{
   new Disciplina("Cálculo número", 4),
   new Disciplina("Algoritmo I", 3),
   new Disciplina("Algoritmo II", 5)
 };


int opcao = 0;

while (opcao != 9)
{
    Console.WriteLine("Escolha uma das opções: ");
    Console.WriteLine("1 - Lançar Notas");
    Console.WriteLine("2 - Listar Notas");
    Console.WriteLine("3 - Visualizar Boletim");
    Console.WriteLine("9 - Sair");

    var opcaoValida = int.TryParse(Console.ReadLine(), out opcao);

    try
    {
        if (!opcaoValida || (opcao != 1 && opcao != 2 && opcao != 3 && opcao != 9))
        {
            Console.WriteLine(@"
            ***************************
            *****  opção inválida  ****
            ***************************");
            Console.WriteLine($"{Environment.NewLine}");

            continue;
        }
        else if (opcao != 9)
        {

            switch (opcao)
            {

                case 1:
                    {
                        Console.WriteLine("Escolha um aluno");
                        for (int i = 0; i < alunos.Length; i++)
                        {
                            Console.WriteLine($"Aluno {i + 1} - Chamada: {alunos[i].NumeroChamada} - {alunos[i].NomeAluno}");
                        }

                        var opcaoValidaAluno = int.TryParse(Console.ReadLine(), out var opcaoAluno);

                        if (!opcaoValidaAluno || (opcaoAluno > alunos.Length + 1))
                        {
                            throw new System.Exception();
                            continue;
                        }

                        Console.WriteLine("Escolha uma disciplina: ");
                        for (int i = 0; i < disciplinas.Length; i++)
                        {
                            Console.WriteLine($"Disciplina {i + 1} - {disciplinas[i].NomeDisciplina} - {disciplinas[i].QtdAvaliacoes}");
                        }

                        var opcaoValidaDisciplina = int.TryParse(Console.ReadLine(), out var opcaoDisciplina);

                        if (!opcaoValidaDisciplina || (opcaoDisciplina > disciplinas.Length + 1))
                        {
                            throw new System.Exception();
                            continue;
                        }

                        float[] notas = new float[disciplinas[opcaoDisciplina - 1].QtdAvaliacoes];

                        Console.WriteLine("Informe as notas: ");
                        for (int i = 0; i < disciplinas[opcaoDisciplina - 1].QtdAvaliacoes; i++)
                        {
                            var notaValida = float.TryParse(Console.ReadLine(), out var notaDisciplina);
                            if (!notaValida)
                            {
                                throw new ValorNotaInvalidoException();
                                continue;
                            }
                            notas[i] = notaDisciplina;

                        }

                        Boletim boletim = new Boletim(disciplinas[opcaoDisciplina - 1], notas);
                        alunos[opcaoAluno - 1].BoletimDisciplinasAluno.Add(boletim);
                        break;
                    }

                case 2:
                    {
                        for (int k = 0; k < alunos.Length; k++)
                        {
                            if (alunos[k].BoletimDisciplinasAluno.Count != 0)
                            {
                                Console.WriteLine("-----------------------------------");
                                Console.WriteLine($"Nome: {alunos[k].NomeAluno}");

                                for (int i = 0; i < alunos[k].BoletimDisciplinasAluno.Count; i++)
                                {
                                    Console.WriteLine($"Disciplina: {alunos[k].BoletimDisciplinasAluno[i].DisciplinaBoletim.NomeDisciplina}");
                                    for (int j = 0; j < alunos[k].BoletimDisciplinasAluno[i].DisciplinaBoletim.QtdAvaliacoes; j++)
                                    {
                                        Console.WriteLine($"Notas provas: {alunos[k].BoletimDisciplinasAluno[i].Notas[j]}");
                                    }
                                    Console.WriteLine($"Média: {alunos[k].BoletimDisciplinasAluno[i].MediaNotas} ");
                                    Console.WriteLine($"{Environment.NewLine}");
                                }
                            }
                            else
                            {
                                throw new NotasInexistentesException();
                            }
                        }

                        break;
                    }

                case 3:
                    {
                        Console.WriteLine("Escolha um aluno");
                        for (int i = 0; i < alunos.Length; i++)
                        {
                            Console.WriteLine($"Aluno {i + 1} - Chamada: {alunos[i].NumeroChamada} - {alunos[i].NomeAluno}");

                        }

                        var opcaoValidaAluno = int.TryParse(Console.ReadLine(), out var opcaoAluno);

                        if (!opcaoValidaAluno || (opcaoAluno > alunos.Length + 1))
                        {
                            throw new BoletimInexistenteException();
                        }

                        Console.WriteLine(@$"
                        -------------------------------
                        ----------  BOLETIM  ----------
                        -------------------------------");
                        Console.WriteLine($"Nome: {alunos[opcaoAluno - 1].NomeAluno} {Environment.NewLine}");

                        for (int i = 0; i < alunos[opcaoAluno - 1].BoletimDisciplinasAluno.Count; i++)
                        {
                            Console.WriteLine($"Disciplina: {alunos[opcaoAluno - 1].BoletimDisciplinasAluno[i].DisciplinaBoletim.NomeDisciplina}");
                            for (int j = 0; j < alunos[opcaoAluno - 1].BoletimDisciplinasAluno[i].DisciplinaBoletim.QtdAvaliacoes; j++)
                            {
                                Console.WriteLine($"Notas provas: {alunos[opcaoAluno - 1].BoletimDisciplinasAluno[i].Notas[j]}");
                            }
                            Console.WriteLine($"Média: {alunos[opcaoAluno - 1].BoletimDisciplinasAluno[i].MediaNotas} {Environment.NewLine}");
                        }

                        break;

                    }
            }
        }

    }
    catch (System.Exception e)
    {
        Console.WriteLine(@$"Exceção {e.GetType().Name} capturada com a mensagem:
                 {e.Message} {Environment.NewLine}");
        continue;
    }
}
