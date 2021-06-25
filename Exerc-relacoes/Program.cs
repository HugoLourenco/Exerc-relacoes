using System;
using System.Collections.Generic;

namespace Exerc_relacoes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Turma> turmas = new();
            int opcao;
            do
            {
                Console.WriteLine("1 - inserir turma");
                Console.WriteLine("2 - inserir aluno");
                Console.WriteLine("3 - inserir professor");
                Console.WriteLine("4 - listar alunos da turma");
                Console.WriteLine("5 - lista de professor/turma");
                Console.WriteLine("0 - sair");
                Console.WriteLine("Selecione opção:");
                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Turma t = new();
                        Console.WriteLine("Indique ano da turma");
                        t.Ano = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Indique letra da turma");
                        t.Letra = Convert.ToChar(Console.ReadLine());
                        turmas.Add(t);
                        break;
                    case 2:
                        Aluno a = new();
                        Console.WriteLine("Indique nome do aluno");
                        a.Nome = Console.ReadLine();
                        Console.WriteLine("Indique email do aluno");
                        a.Email = Console.ReadLine();
                        Console.WriteLine("Indique numero do aluno");
                        a.Num_aluno = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Indique ano da turma do aluno");
                        int ano = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Indique letra da turma do aluno");
                        char letra = Convert.ToChar(Console.ReadLine());
                        foreach(Turma tu in turmas)
                        {
                            if((tu.Ano == ano) && (tu.Letra == letra))
                            {
                                tu.AdicionaAluno(a);
                                Console.WriteLine($"Aluno {a.Nome} adicionado à turma {tu.Ano} {tu.Letra}");
                            }
                        }
                        break;
                    case 3:
                        Professor p = new();
                        Console.WriteLine("Indique nome do professor");
                        p.Nome = Console.ReadLine();
                        Console.WriteLine("Indique código de funcionário do professor");
                        p.Cod_func = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Indique grupo do professor");
                        p.Grupo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Indique ano da turma do professor");
                        ano = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Indique letra da turma do professor");
                        letra = Convert.ToChar(Console.ReadLine());
                        foreach (Turma tu in turmas)
                        {
                            if ((tu.Ano == ano) && (tu.Letra == letra))
                            {
                                tu.AdicionaProf(p);
                                Console.WriteLine($"Professor {p.Nome} adicionado à turma {tu.Ano} {tu.Letra}");
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("Indique ano da turma");
                        ano = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Indique letra da turma");
                        letra = Convert.ToChar(Console.ReadLine());
                        foreach (Turma tu in turmas) {
                            if ((tu.Ano == ano) && (tu.Letra == letra))
                            {
                                tu.ListaAlunos();
                            }
                        }
                        break;
                    case 5:
                        foreach (Turma tu in turmas)
                        {
                            Console.WriteLine($"Nome: {tu.Prof.Nome}, Turma: {tu.Ano} {tu.Letra}");
                        }
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            } while (opcao != 0);
        }
    }
}
