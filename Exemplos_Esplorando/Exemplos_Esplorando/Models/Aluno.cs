using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos_Esplorando.Models
{
    //cria a classe e herda da pessoa
    public class Aluno : Pessoa
    {
        
        public Aluno(string nome) : base(nome) 
        { 

        }

        public double Nota { get; set; }

        //sobscreve a classe aluno
        public override void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome}, tenho {Idade} anos e tirei {Nota}");
        }
    }
}
