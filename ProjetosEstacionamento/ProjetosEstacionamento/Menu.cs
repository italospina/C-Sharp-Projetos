using ProjetosEstacionamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosEstacionamento
{
    public class Menu
    {
        public string opcao;
        public bool exibirMenu = true;
        public List<string> listaPlaca = new List<string>();
        public string placaCadastrada;

        public void ApesentarMenu()
        {
            while (exibirMenu)
            {
                //Console.Clear();
                Console.WriteLine("\n");
                Console.WriteLine("================================");
                Console.WriteLine("============ Menu: =============");
                Console.WriteLine("================================");
                Console.WriteLine("1- Cadastro de Veiculo. ");
                Console.WriteLine("2- Remover ciente ");
                Console.WriteLine("3- Listar Veiculos ");
                Console.WriteLine("4- Sair. ");

                Console.WriteLine("-------------------------");
                Console.WriteLine("Digite a opcao desejada: ");
                opcao = Console.ReadLine();

                Apresentar apresentar = new Apresentar();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("\n");
                        Console.WriteLine("===================================");
                        Console.WriteLine("Voce entrou no Cadastro de cliente!");
                        Console.WriteLine("===================================");
                        //Console.WriteLine("\n");
                        Console.WriteLine("Digite a placa do veiculo:");
                        placaCadastrada = Convert.ToString(Console.ReadLine());
                        listaPlaca.Add(placaCadastrada);
                        Console.WriteLine($"Voce adicionou o veiculo com placa: {placaCadastrada} do estacionamento");
                        //listaPlaca.Add((string)Console.ReadLine());

                        Console.WriteLine("Presione uma tecla para continuar");
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.WriteLine("\n");
                        Console.WriteLine("==================================");
                        Console.WriteLine("Voce entrou na remocao de veiculos");
                        Console.WriteLine("==================================");
                        //Console.WriteLine("\n");
                        Console.WriteLine("Digite a placa do veiculo:");
                        placaCadastrada = Convert.ToString(Console.ReadLine());

                        Console.WriteLine("Digite quantas horas o veiculo permaneceu no estacionamento:");
                        apresentar.horaPermanecida = Convert.ToInt32(Console.ReadLine());
                        apresentar.valorReais = (apresentar.horaPermanecida * apresentar.precoPorHora) + apresentar.precoInicial;
                        Console.WriteLine($"O Total para a placa {placaCadastrada} foi R${apresentar.valorReais},00");

                        Console.WriteLine($"Voce removeu o veiculo com placa: {placaCadastrada} do estacionamento");
                        listaPlaca.Remove(placaCadastrada);

                        Console.WriteLine("Presione uma tecla para continuar");
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.WriteLine("\n");
                        Console.WriteLine("=================================");
                        Console.WriteLine("Voce entrou na lista de veiculos");
                        Console.WriteLine("=================================");
                        int contador = 0;

                        if (listaPlaca.Count == 0)
                        {
                            //Console.WriteLine("\n");
                            Console.WriteLine("O estacionamento esta vazio");

                        }
                        else
                        {
                            foreach (string todasPlacas in listaPlaca)
                            {
                                Console.WriteLine($"Posicao N {contador} - {todasPlacas}");
                                contador++;
                            }
                        }
                        Console.WriteLine("Presione uma tecla para continuar");
                        Console.ReadKey();
                        break;

                    case "4":
                        Console.WriteLine("\n");
                        Console.WriteLine("=================================");
                        Console.WriteLine("========== Encerrando.===========");
                        Console.WriteLine("=================================");
                        exibirMenu = false;

                        break;

                    default:
                        Console.WriteLine("===========================");
                        Console.WriteLine("Valor escolhido inexistente");
                        Console.WriteLine("===========================");
                        break;
                }

            }
        }
    }
}
