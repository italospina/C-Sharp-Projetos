using Newtonsoft.Json;
using Projeto_Hospedagem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Hospedagem.Construtores
{
    public class SuiteConstructor
    {
        bool continua = true;
        int contHospedes;
        public int escolhaSuite;
        decimal guardaValor;
        string cadastraNovoHospede;

        //mudar conforme a localização do diretorio no seu pc
        private string filePathSuite = "C:\\Users\\estud\\source\\repos\\Projeto_Hospedagem\\Projeto_Hospedagem\\Arquivos\\mostrarSuites.json";
        private string filePathHospede = "C:\\Users\\estud\\source\\repos\\Projeto_Hospedagem\\Projeto_Hospedagem\\Arquivos\\mostrarHospedes.json";

        List<Pessoa> pessoas = new List<Pessoa>();

        //serialização da suite
        public void SerializacaoSuite()
        {
            List<Suite> listaDeSuite = new List<Suite>()
            {
                new Suite(idSuite:0 ,tipoSuite: "Simples", capacidade: 1, valorDiaria: 35),
                new Suite(idSuite:1 ,tipoSuite: "Basica", capacidade: 2, valorDiaria: 50),
                new Suite(idSuite:2 ,tipoSuite: "Média", capacidade: 3, valorDiaria: 75),
                new Suite(idSuite:3 ,tipoSuite: "Plus", capacidade: 4, valorDiaria: 125),
                new Suite(idSuite:4 ,tipoSuite: "Premium", capacidade: 6, valorDiaria: 200),
                new Suite(idSuite:5 ,tipoSuite: "Rei", capacidade: 20, valorDiaria: 5000)
            };

            string serializar = JsonConvert.SerializeObject(listaDeSuite, Formatting.Indented);

            File.WriteAllText(filePathSuite, serializar);

            //Console.WriteLine(serializar);
        }

        //desserialização da suite
        public void ApresentarDesserializacaoSuite()
        {

            string conteudoDoArquivo = File.ReadAllText(filePathSuite);
            List<Suite> listaDeSuite = JsonConvert.DeserializeObject<List<Suite>>(conteudoDoArquivo);

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("ESSAS SÃO AS SUITES DO HOTEL ITALO:");
            Console.WriteLine("-----------------------------------");
            foreach (Suite suite in listaDeSuite)
            {

                Console.WriteLine($"Numero da Suite: {suite.IdSuite} | Tipo: {suite.TipoSuite} | Capacidade: {suite.Capacidade} Pessoas | Valor da Diaria: R${suite.ValorDiaria}");
            }

            contHospedes = listaDeSuite.Count;
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"{contHospedes} suites disponiveis.");
            Console.WriteLine("-----------------------------------");
        }


        //Passo 1 - ESCOLHER SUITE
        public void EscolherSuite()

        {
            string conteudoDoArquivo = File.ReadAllText(filePathSuite);
            List<Suite> listaDeSuite = JsonConvert.DeserializeObject<List<Suite>>(conteudoDoArquivo);

            escolhaSuite = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"A Suite escolhida foi a seguinte: ");
            Console.WriteLine("-----------------------------------");
            Suite suite = listaDeSuite[escolhaSuite];
            Console.WriteLine($"Id: {suite.IdSuite}\n" +
                $"Tipo da Suite: {suite.TipoSuite}\n" +
                $"Capacidade: {suite.Capacidade} Pessoas\n" +
                $"Valor da Diaria: R${suite.ValorDiaria}");
        }

        //Passo 2 - DIAS DE HOSPEDAGEM
        public void DiasNaSuite()
        {
            string conteudoDoArquivo = File.ReadAllText(filePathSuite);
            List<Suite> listaDeSuite = JsonConvert.DeserializeObject<List<Suite>>(conteudoDoArquivo);
            Suite suite = listaDeSuite[escolhaSuite];
            int diasReservados;
            string dias;

            do
            {
                Console.WriteLine("Quantos dias deseja ficar hospedado?");
                dias = Console.ReadLine();

                //diasReservados = Convert.ToInt32(Console.ReadLine());

                if (int.TryParse(dias, out diasReservados) && diasReservados > 0)
                {
                    diasReservados = Convert.ToInt32(dias);
                    break;

                }
                else
                {
                    Console.WriteLine("Quantidade de dias não pode ser vazio.");
                }
            }
            while (string.IsNullOrEmpty(dias));



            decimal valorTotal = suite.ValorDiaria * diasReservados;
            if (diasReservados >= 10)
            {
                decimal valorPorcentagem = (suite.ValorDiaria * diasReservados) / 100;
                decimal valorTotalGeral = valorTotal - valorPorcentagem;
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine($"O Valor total da estadia é: R${valorTotalGeral}");
                Console.WriteLine("------------------------------------------------");
            }
            else
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine($"O Valor total da estadia é: R${valorTotal}");
                Console.WriteLine("-------------------------------------------");
            }
        }

        //Passo 3 - CADASTRO DE HOSPEDES
        public void IncluirHospede()
        {

            string conteudoDoArquivo = File.ReadAllText(filePathSuite);
            List<Suite> listaDeSuite = JsonConvert.DeserializeObject<List<Suite>>(conteudoDoArquivo);

            while (continua)
            {
                var pessoa = new Pessoa();

                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("-----------------------------------------");

                do
                {
                    Console.WriteLine("Digite o nome do hospede para continuar: ");
                    pessoa.Nome = Console.ReadLine();

                    if (string.IsNullOrEmpty(pessoa.Nome))
                    {
                        Console.WriteLine("O Nome não pode ser vazio");
                    }
                }
                while (string.IsNullOrEmpty(pessoa.Nome));


                do
                {
                    Console.WriteLine("Digite o sobrenome do hospede para continuar: ");
                    pessoa.Sobrenome = Console.ReadLine();

                    if (string.IsNullOrEmpty(pessoa.Sobrenome))
                    {
                        Console.WriteLine("O Sobrenome não pode ser vazio");
                    }
                }
                while (string.IsNullOrEmpty(pessoa.Sobrenome));
                

                pessoa.NomeMaiusculo();
                pessoas.Add(pessoa);

                Console.WriteLine("-----------------------------------------------------------------------------------------");
                Console.WriteLine("Digite 'S' para inserir mais um nome ou 'N' para avançar ao processo de seleção da suite:");
                cadastraNovoHospede = Console.ReadLine();

                if (cadastraNovoHospede.ToUpper() == "S")
                {
                    Console.WriteLine("==================================================");
                    Console.WriteLine($"Nome adicionado com sucesso:{pessoa.Nome + " " + pessoa.Sobrenome}");
                    Console.WriteLine("==================================================");
                }
                else if (cadastraNovoHospede.ToUpper() == "N")
                {
                    Console.WriteLine("==================================================");
                    Console.WriteLine($"Nome adicionado com sucesso:{pessoa.Nome + " " + pessoa.Sobrenome}");
                    Console.WriteLine("==================================================");

                    continua = false;
                }
                else
                {
                    break;
                }
                
                HospedesConstructor hospedesConstructor = new HospedesConstructor();
                hospedesConstructor.SerializaHospedes(pessoas, filePathHospede);

                VerificaQuantidadeDeHospedesNaSuite();

            }
        }

        //Passo 3.1 - Verifica a Quantidade de hospedes na suite
        public void VerificaQuantidadeDeHospedesNaSuite()
        {

            string conteudoDoArquivoHospedes = File.ReadAllText(filePathHospede);
            List<Pessoa> hospedes = JsonConvert.DeserializeObject<List<Pessoa>>(conteudoDoArquivoHospedes);

            contHospedes = hospedes.Count;

            Console.WriteLine($"Total de pessoas cadastradas: {pessoas.Count()}");
            Console.WriteLine($"Total de capacidade da suite: {contHospedes}");

            if (pessoas.Count() > contHospedes)
            {
                Console.WriteLine("O total de hospedes ultrapassa a capacidade da suite.");

                HospedesConstructor listaDeHospedes = new HospedesConstructor();
                listaDeHospedes.LimparHospedes();

                pessoas.Clear();
                Console.WriteLine("Realize novamente o cadastro dos hospedes");

                continua = true;
            }
        }

    }
}
