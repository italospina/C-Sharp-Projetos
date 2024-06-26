using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos_Esplorando.Models
{
    internal class Curso
    {
        public Curso() { }

        public Curso(String nome) 
        { 
            Nome = nome;
        }

        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set;}

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public void RemoverAluno(Pessoa aluno) 
        { 
            Alunos.Remove(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados() 
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de: {Nome}");

            for (int count = 0; count < Alunos.Count; count++)
            {
                string texto = $"Numero {count+1} - {Alunos[count].NomeCompleto}";
                Console.WriteLine(texto);
            }
        }


    }
}
