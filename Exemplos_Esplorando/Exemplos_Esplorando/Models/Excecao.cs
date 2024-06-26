using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos_Esplorando.Models
{
    internal class Excecao
    {
        public void Met1()
        {
            try 
            {
                Met2();
            } 
            catch (Exception ex4) 
            { 
                Console.WriteLine("Tratada");
            }
        }

        public void Met2()
        {
            Met3();
        }

        public void Met3()
        {
            Met4();
        }

        public void Met4()
        {
            throw new Exception("Uma excecao foi encontrada");
        }
    }
}
