using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Projeto_Hospedagem.Models
{
    public class Suite
    {
        public Suite(int idSuite,string tipoSuite, int capacidade, decimal valorDiaria) 
        {
            IdSuite = idSuite;
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }

        public int IdSuite { get; set; }
        public string TipoSuite { get; set; }
        public int Capacidade { get; set;}
        public decimal ValorDiaria { get; set;}

    }


}
