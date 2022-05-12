﻿using System;
using TurmaApp;
using System.Collections.Generic;



AppTurma();

static void AppTurma()
{
    Turma turma = new Turma();
    bool sair = false;
    while (!sair)
    {
        try
        {
            Console.WriteLine("1 - Adicionar aluno");
            Console.WriteLine("2 - Remover aluno");
            Console.WriteLine("3 - Lista de alunos e suas notas finais");
            Console.WriteLine("0 - Sair ");
            Console.Write("Escoha a opcao: ");
            int opcao;
            float p1, p2;
            string nomealuno, matricula;
            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                throw new Exception("Opcao inválida!");
            }

            switch (opcao)
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
                        Console.Write("Nome do Aluno(a) {0}: ", cont);
                        nomealuno = Console.ReadLine();

                        Console.Write("Matricula do Aluno(a): ");
                        matricula = Console.ReadLine();

                        Console.Write("Primeira nota do Aluno(a): ");
                        if (!float.TryParse(Console.ReadLine(), out p1))
                        {
                            Console.WriteLine("Nota inválida, entre com os dados do ultimo aluno novamente!");
                            continue;
                        }

                        Console.Write("Segunda nota do Aluno(a): ");
                        if (!float.TryParse(Console.ReadLine(), out p2))
                        {
                            Console.WriteLine("Nota inválida, entre com os dados do ultimo aluno novamente!");
                            continue;
                        }
                        Console.WriteLine("");
                        if (!turma.AddAluno(new Aluno(nomealuno, matricula, p1, p2)))
                        {
                            Console.WriteLine("Aluno ja existe na lista!");
                            Console.WriteLine("Pressione qualquer tecla para continuar!");
                            Console.ReadKey();
                            Console.WriteLine("");
                            continue;
                        }
                        cont++;
                    }


                    Console.Clear();
                    foreach (Aluno aluno in turma.Alunos)
                    {
                        Console.WriteLine("Nome do aluno: " + aluno.NomeAluno);
                        Console.WriteLine("Matricula do aluno: " + aluno.Matricula);
                        Console.WriteLine("Nota 1 do aluno: " + aluno.P1.ToString("N2"));
                        Console.WriteLine("Nota 2 do aluno: " + aluno.P2.ToString("N2"));
                        Console.WriteLine("");
                    }
                    Console.WriteLine("Pressione qualquer tecla para continuar!");
                    Console.ReadKey();
                    Console.Clear();

                    break;
                case 2:
                    Console.Clear();
                    foreach (Aluno aluno in turma.Alunos)
                    {
                        Console.WriteLine("Nome do aluno: " + aluno.NomeAluno);
                        Console.WriteLine("Matricula do aluno: " + aluno.Matricula);
                        Console.WriteLine("Nota 1 do aluno: " + aluno.P1.ToString("N2"));
                        Console.WriteLine("Nota 2 do aluno: " + aluno.P2.ToString("N2"));
                        Console.WriteLine("");
                    }
                    Console.Write("Digite o nome do aluno(a) que deseja remover: ");
                    nomealuno = Console.ReadLine() ?? "";

                    Console.Write("Digite a matricula do aluno(a) que deseja remover: ");
                    matricula = Console.ReadLine() ?? "";

                    Console.Write("Primeira nota do aluno(a) que desdeja remover: ");
                    if (!float.TryParse(Console.ReadLine(), out p1))
                    {
                        Console.WriteLine("Nota inválida, entre com os dados do ultimo aluno novamente!");
                        continue;
                    }
                    Console.Write("Segunda nota do aluno(a) que desdeja remover: ");
                    if (!float.TryParse(Console.ReadLine(), out p2))
                    {
                        Console.WriteLine("Nota inválida, entre com os dados do ultimo aluno novamente!");
                        continue;
                    }

                    if (turma.RemoverAluno(new Aluno(nomealuno, matricula, p1, p2)))
                    {
                        Console.WriteLine("Aluno removido");
                    }
                    else
                    {
                        Console.WriteLine("Aluno nao existe na lista ou a mesma esta vazia!");
                    }
                    break;

                case 3:
                    Console.Clear();
                    if (turma.Alunos.Count == 0)
                    {
                        Console.WriteLine("A turma nao possui alunos cadastrados!");
                    }
                    else
                    {
                        Console.WriteLine("Alunos da turma");
                        foreach (Aluno aluno in turma.Alunos)
                        {
                            Console.WriteLine("Nome do aluno: " + aluno.NomeAluno);
                            Console.WriteLine("Matricula do aluno: " + aluno.Matricula);
                            Console.WriteLine("Nota Final do aluno: " + aluno.Notafinal.ToString("N2"));
                            Console.WriteLine("");
                        }
                        Console.WriteLine("Media da turma p1:  " + turma.MediaP1.ToString("N2"));
                        Console.WriteLine("Media da turma p2:  " + turma.MediaP2.ToString("N2"));
                        Console.WriteLine("Media da nota final da turma:  " + turma.MediaNotaFinal.ToString("N2"));

                        Console.WriteLine("");
                        Console.WriteLine("Aluno da turma com a maior nota final");
                        Console.WriteLine("Nome do aluno: " + turma.AlunoMaiorNotaFinal.NomeAluno);
                        Console.WriteLine("Matricula do aluno: " + turma.AlunoMaiorNotaFinal.Matricula);
                        Console.WriteLine("Nota 1 do aluno: " + turma.AlunoMaiorNotaFinal.P1.ToString("N2"));
                        Console.WriteLine("Nota 2 do aluno: " + turma.AlunoMaiorNotaFinal.P2.ToString("N2"));
                        Console.WriteLine("Nota Final do aluno: " + turma.AlunoMaiorNotaFinal.Notafinal.ToString("N2"));
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Pressione qualquer tecla para continuar!");
                    Console.ReadKey();
                    break;
                case 0:
                    sair = true;
                    break;
            }



        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message); Console.WriteLine("");
        }
    }
}





//Turma aluno1 = new Turma();
//aluno1.NomeAluno = "Matheus";
//aluno1.Matricula = "2019100859";

//listaturma.Add(aluno1);


