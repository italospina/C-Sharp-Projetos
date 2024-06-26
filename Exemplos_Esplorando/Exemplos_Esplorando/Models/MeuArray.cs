using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos_Esplorando.Models
{
    public class MeuArray<T>
    {
        private static int cap = 10;
        private int cont = 0;
        private T[] array = new T[cap];

        public void AddElementoArray(T elemento) 
        { 
            if(cont+1<11)
            {
                array[cont] = elemento;
            }
            cont++;
        }

        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
    }
}
