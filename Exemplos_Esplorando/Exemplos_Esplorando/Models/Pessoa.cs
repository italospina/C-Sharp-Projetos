using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos_Esplorando.Models
{
    internal class Pessoa
    {
        public Pessoa() 
        { 
            
        }
        public Pessoa(string nome, string sobrenome) 
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public void Deconstruct (out string nome, out string sobrenome)
        {
            nome = Nome;
            sobrenome = Sobrenome;
        }

        private string _nome;
        private int _idade;
        private string _sobrenome;
        private string _nomeCompleto;
        //digirar prop
        public string Nome 
        {
            get => _nome;

            set
            {
                if (value == null)
                {
                    throw new ArgumentException("O nome nao pode ser vazio");
                }
                _nome = value;
            }
        }

        public string Sobrenome 
        {
            get => _sobrenome;
            set
            {
                if (value == null) 
                {
                    throw new ArgumentException("O sobrenome nao pode ser vazio");
                }
                _sobrenome = value;
            }
        }

        public string NomeCompleto  
        {
            get => $" {_nome} {_sobrenome}".ToUpper(); 
        }

        public int Idade
        {
            get=>_idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade nao pode ser menor que 0.");
                }
                _idade = value;
            }
        }
     
        public void Apresentar () {

            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade} " );
        }
    }
}
