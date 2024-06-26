using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Projeto_Hospedagem.Construtores;
using System.Security.Cryptography;

namespace Projeto_Hospedagem.Models
{
    public class Reserva
    {
        List<Pessoa> pessoas = new List<Pessoa>();
        SuiteConstructor suiteConstructor = new SuiteConstructor();
        List<Suite> listaDeSuite = new List<Suite>();

        int idSuite;
        string tipoSuite;
        int capacidade;
        decimal valorDaDiaria;

        public void EscolheSuite()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("    Passo 1 - ESCOLHER SUITE     ");
            Console.WriteLine("---------------------------------");
            suiteConstructor.ApresentarDesserializacaoSuite();
            suiteConstructor.EscolherSuite();
        }

        public void EscolhaDiasReservados()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("      Passo 2 - DIAS DE HOSPEDAGEM   ");
            Console.WriteLine("-------------------------------------");

            suiteConstructor.DiasNaSuite();
        }

        public void AdicionarHospede()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("      Passo 3 - CADASTRO DE HOSPEDES     ");
            Console.WriteLine("-----------------------------------------");

            suiteConstructor.IncluirHospede();
        }

              
    }
}
