using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_relacoes
{
    class Pessoa
    {
        public string Nome { get; set; }
        public DateTime Data_nasc { get; set; }
        public string Morada { get; set; }
        public int Contacto { get; set; }
        public string Email { get; set; }
        public int Nif { get; set; }

        public string MostraInfo()
        {
            return $"Nome:{Nome}, E-mail:{Email}";
        }
    }
}
