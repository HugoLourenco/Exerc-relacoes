using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_relacoes
{
    class Aluno: Pessoa
    {
        public int Num_aluno { get; set; }

        public string MostraInfo() {
            return $"Numero:{Num_aluno}, " + base.MostraInfo();
            //base.MostraInfo() invoca o método MostraInfo da classe de que Aluno deriva - Pessoa
        }
    }
}
