using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosEstacionamento
{
    public class Apresentar
    {
        public double precoInicial = 5;
        public double precoPorHora = 2;
        public double horaPermanecida;
        public double valorReais;

        public void Apesentacao()
        {
            Console.WriteLine("================================================");
            Console.WriteLine("Bem vindo ao sistema de Estacionamentos Italo.\n");
            Console.WriteLine("================================================");

            Console.WriteLine($"Valor inicial: R${precoInicial},00");
            //precoInicial = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"O Valor digitado foi: {precoInicial}");

            Console.WriteLine($"Preco por hora: R${precoPorHora},00");
            //precoPorHora = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"O Valor digitado foi: {precoInicial}");
        }
    }
}
