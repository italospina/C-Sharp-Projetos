using Newtonsoft.Json;
using Projeto_Hospedagem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Hospedagem.Construtores
{
    
    public class HospedesConstructor
    {
        //mudar conforme a localização do diretorio no seu pc
        private string filePath = "C:\\Users\\estud\\source\\repos\\Projeto_Hospedagem\\Projeto_Hospedagem\\Arquivos\\mostrarHospedes.json";
        int contHospedes;

        //realiza a serialização em um arquivo json
        public void SerializaHospedes(List<Pessoa> pessoas, string filePathPessoa)
        {
            string serializar = JsonConvert.SerializeObject(pessoas, Formatting.Indented);

            File.WriteAllText(filePath, serializar);

            //Console.WriteLine("Arquivo Json Salvo!");
        }

        //Realiza a Desserializacao e apresenta os hospedes cadastrados na reserva
        public void ApresentarDesserializacaoHospedes()
        {
            string conteudoDoArquivo = File.ReadAllText(filePath);

            List<Pessoa> hospedes = JsonConvert.DeserializeObject<List<Pessoa>>(conteudoDoArquivo);

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("ESSAS SÃO OS HOSPEDES DO HOTEL ITALO:");
            Console.WriteLine("-------------------------------------");

            foreach (Pessoa h in hospedes)
            {
                Console.WriteLine($"Nome: {h.Nome}, Sobrenome {h.Sobrenome}");
            }

            contHospedes = hospedes.Count;
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"{contHospedes} pessoas estão hospedadas.");
            Console.WriteLine("-----------------------------------------");


        }

        //Limpar arquivo JSON na hora da saida da aplicação
        public void LimparHospedes()
        {
            string caminhoArquivoMostrarHospedes = filePath;

            LimparArquivoJson(caminhoArquivoMostrarHospedes, "{}");

            //Console.WriteLine("Arquivo Json Limpo!");
        }

        static void LimparArquivoJson(string caminho, string conteudo)
        {
            try
            {
                File.WriteAllText(caminho, conteudo);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao limpar arquivo Json: {ex.Message}");
            }
        }

    }
}
