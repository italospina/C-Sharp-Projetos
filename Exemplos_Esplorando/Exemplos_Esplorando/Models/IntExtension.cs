using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos_Esplorando.Models
{
    public static class IntExtension
    {
        public static bool EhPar (this int numero)
        { 
            return numero % 2 == 0; 
        }
    }
}
