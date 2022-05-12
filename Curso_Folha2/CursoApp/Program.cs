using System;
using CursoApp;

public class AppCurso
{
    static void Main(string[] args)
    {
        Curso();
    }

    public static void Curso()
    {
        string nomealuno = "";
        string matricula = "";
        string codigoturma = "";
        string turmas;
        string nomeCurso;




        int opcurso = 0;
        bool sair = false;

        Console.WriteLine("Digite o nome do curso: ");
        nomeCurso = Console.ReadLine();
        Curso curso = new Curso(nomeCurso);
        Console.Clear();
        while (!sair)
        {
            try
            {
                Console.WriteLine("Curso: " + nomeCurso);
                Console.WriteLine("1 - Adicionar aluno");
                Console.WriteLine("2 - Adicionar turma");
                Console.WriteLine("3 - Adicionar aluno na turma");
                Console.WriteLine("4 - Remover aluno da turma");
                Console.WriteLine("5 - Remover turma do curso");
                Console.WriteLine("6 - Listar alunos de uma turma");
                opcurso = Convert.ToInt16(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Valor inválido!"); Console.WriteLine("");
                continue;
            }

            switch (opcurso)
            {
                case 1:
                    int qaluno;
                    try
                    {
                        Console.Write("Informe quantos alunos deseja adicionar: ");
                        qaluno = Convert.ToInt16(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Valor inválido!"); Console.WriteLine("");
                        continue;
                    }
                    Console.WriteLine("");

                    int cont = 1;
                    while (cont <= qaluno)
                    {
                        Console.WriteLine("Digite o nome do aluno ");
                        nomealuno = Console.ReadLine();
                        matricula = curso.AddAluno(nomealuno);
                        cont++;
                    }
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Digite o novo codigo da turma ");
                    codigoturma = Console.ReadLine();

                    if (!curso.AddTurma(codigoturma))
                    {
                        Console.WriteLine("Turma ja existe!");
                        continue;
                    }
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Clear();
                    foreach (Aluno aluno in curso.Alunos)
                    {
                        Console.Write("Matricula: " + aluno.Matricula);
                        Console.Write("   Nome: " + aluno.Nome);
                        Console.WriteLine("");
                    }
                    foreach (Turma turma in curso.Turmas)
                    {
                        Console.WriteLine("Turmas: " + turma.Codigo);
                    }
                    Console.WriteLine("Adicionar aluno na turma");

                    Console.WriteLine("Digite o codigo da turma");
                    codigoturma = Console.ReadLine();
                    Turma _turma = curso.GetTurma(codigoturma);

                    Console.Write("Digite a matricula do aluno: ");
                    matricula = Console.ReadLine();
                    Aluno _aluno = curso.GetAluno(matricula);

                    if (!_turma.AddAluno(_aluno))
                    {
                        Console.WriteLine("Aluno ja existe na turma!");
                        continue;
                    }
                    Console.ReadKey();
                    break;
                case 4:
                    Console.Clear();
                    foreach (Aluno aluno in curso.Alunos)
                    {
                        Console.Write("Matricula: " + aluno.Matricula);
                        Console.Write("   Nome: " + aluno.Nome);
                        Console.WriteLine("");
                    }
                    foreach (Turma turma in curso.Turmas)
                    {
                        Console.WriteLine("Turmas: " + turma.Codigo);
                    }
                    Console.WriteLine("Digite o codigo da turma");
                    codigoturma = Console.ReadLine();
                    Turma _alunoturmaremove = curso.GetTurma(codigoturma);

                    Console.WriteLine("Digite a matricula do aluno que deseja remover");
                    matricula = Console.ReadLine();
                    Aluno _alunoremove = curso.GetAluno(matricula);

                    if (_alunoturmaremove.RemoveAluno(_alunoremove))
                    {
                        Console.WriteLine("Aluno removido");
                    }
                    else
                    {
                        Console.WriteLine("Aluno nao existe na turma!");
                    }
                    break;
                    Console.ReadKey();
                case 5:
                    foreach (Turma turma in curso.Turmas)
                    {
                        Console.WriteLine("Turmas: " + turma.Codigo);
                    }
                    Console.WriteLine("Digite o codigo da turma que deseja remover");
                    codigoturma = Console.ReadLine();
                    Turma _removeturma = curso.GetTurma(codigoturma);

                    if (_removeturma == null)
                    {
                        Console.WriteLine("Turma nao encontrada");
                    }

                    if (_removeturma.AlunosTurma.Count > 0)
                    {
                        Console.WriteLine("Turma nao pode ser removida pois possui alunos");
                    }
                    else
                    {
                        if (curso.RemoveTurma(_removeturma))
                        {
                            Console.WriteLine("Turma removida");
                        }
                        else
                        {
                            Console.WriteLine("Erro ao remover turma");
                        }
                    }
                    Console.ReadKey();
                    break;
                case 6:
                    Console.Clear();
                    foreach (Turma turma in curso.Turmas)
                    {
                        Console.WriteLine("Turmas: " + turma.Codigo);
                    }
                    Console.Write("Digite a turma: ");
                    codigoturma = Console.ReadLine();
                    Turma opturma = curso.GetTurma(codigoturma);

                    foreach (Aluno aluno in opturma.AlunosTurma)
                    {
                        Console.Write("Matricula: " + aluno.Matricula);
                        Console.Write("   Nome: " + aluno.Nome);
                    }
                    Console.ReadKey();
                    break;
                case 7:
                    Console.Clear();
                    foreach (Turma turma in curso.Turmas)
                    {
                        if (turma.AlunosTurma.Count > 0)
                        {
                            Console.WriteLine("Turma: " + turma.Codigo);

                            foreach (Aluno aluno in turma.AlunosTurma)
                            {
                                Console.Write("   Matricula: " + aluno.Matricula);
                                Console.Write("   Nome.....: " + aluno.Nome);
                            }
                            Console.WriteLine("");
                        }
                    }
                    Console.ReadKey();
                    break;
            }



        }
    }
}
