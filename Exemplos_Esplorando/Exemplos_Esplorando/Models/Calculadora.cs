using Exemplos_Esplorando.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos_Esplorando.Models
{
    public class Calculadora : ICalculadora
    {
        

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Somar (int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
