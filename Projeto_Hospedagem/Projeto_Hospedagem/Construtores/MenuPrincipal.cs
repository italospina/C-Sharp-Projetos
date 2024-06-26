using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_Hospedagem.Construtores;

namespace Projeto_Hospedagem.Construtores
{
    public class MenuPrincipal
    {
        public void MostrarMenuPrincipal()
        {
            //Console.Clear();
            Console.WriteLine("-------------------------");
            Console.WriteLine("BEM VINDO AO HOTEL ITALO!");
            Console.WriteLine("-------------------------");
            Console.WriteLine("1- Ver Suites ");
            Console.WriteLine("2- Ver Hospedes ");
            Console.WriteLine("3- Cadastrar Reservas ");
            Console.WriteLine("4- Sair ");
            Console.WriteLine("Digite uma opção: ");
        }

        public void VoltaMenuPrincipal()
        {
            string voltarMenuPrincipal = null;
            bool voltar = false;
            while (!voltar)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Deseja voltar ao menu principal?");
                Console.WriteLine("Digite 'S' para voltar:");
                voltarMenuPrincipal = Console.ReadLine();

                if (voltarMenuPrincipal.ToUpper() == "S")
                {
                    voltar = true;
                }

                else
                {
                    Console.WriteLine("Opção inválida. Tente novamente!");
                    SuiteConstructor suiteConstructor = new SuiteConstructor();
                    suiteConstructor.ApresentarDesserializacaoSuite();
                }
            }
            
        }
    }
}
