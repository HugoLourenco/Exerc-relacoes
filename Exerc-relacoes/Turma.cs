using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_relacoes
{
    class Turma
    {
        public int Ano { get; set; }
        public char Letra { get; set; }
        public List<Aluno> Alunos { get; set; } = new();
        public Professor Prof { get; set; }

        public void AdicionaProf(Professor p) {
            Prof = p;
        }
        public void AdicionaAluno(Aluno a) {
            Alunos.Add(a);
        }

        public void ListaAlunos() { 
            foreach(Aluno a in Alunos)
            {
                Console.WriteLine(a.MostraInfo());
            }
        }
    }
}
