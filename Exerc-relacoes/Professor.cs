using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_relacoes
{
    class Professor: Pessoa
    {
        public int Grupo { get; set; }
        public int Cod_func { get; set; }

        public string MostraInfo()
        {
            return $"Numero:{Cod_func}, Grupo: {Grupo}, " + base.MostraInfo();
            //base.MostraInfo() invoca o método MostraInfo da classe de que Professor deriva - Pessoa
        }
    }
}
