using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Hospedagem.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public void NomeMaiusculo()
        {
            Nome = Nome.ToUpper();
            Sobrenome = Sobrenome.ToUpper();
        }
    }
}
