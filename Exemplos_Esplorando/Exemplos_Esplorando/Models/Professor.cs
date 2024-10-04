using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos_Esplorando.Models
{
    //cria a classe e herda da pessoa
    public class Professor : Pessoa
    {
        public Professor(string nome): base(nome) 
        { 
        }
        public decimal Salario { get; set; }

        //sobscreve a classe aluno
        public sealed override void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome}, tenho {Idade} anos e ganho R${Salario}");
        }
    }
}
