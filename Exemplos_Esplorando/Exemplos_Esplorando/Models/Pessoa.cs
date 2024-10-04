using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos_Esplorando.Models
{
    public class Pessoa
    {
        public Pessoa(string nome) 
        {
            Nome= nome;

        }
        public string Nome { get; set; }
        public int Idade { get; set; }

        //virtual - permite que o metodo seja sobrescrito conforme preciso
        public virtual void Apresentar()
        {
            Console.WriteLine($"Ola, meu nome e {Nome} e tenho {Idade} anos");
        }
    }
}
