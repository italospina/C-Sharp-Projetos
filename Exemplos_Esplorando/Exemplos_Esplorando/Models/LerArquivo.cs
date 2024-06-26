using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos_Esplorando.Models
{
    public class LerArquivo
    {
        public (bool Sucesso, string[] LinhasArquivo, int QuantidadeLinhas) arquivoLer(string caminho)
        {
            //sucesso
            try
            {
                string[] linha = File.ReadAllLines(caminho);
                return (true, linha, linha.Count());
            }catch (Exception ex)
            {
                return (false, new string[0],0);
            }
        }
    }
}
