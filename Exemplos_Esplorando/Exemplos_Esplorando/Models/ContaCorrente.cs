using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos_Esplorando.Models
{
    internal class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }

        public int NumeroConta { get; set; }

        private decimal saldo;

        public void Sacar(decimal valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine($"Saque Realizado com sucesso");
            }
            else
            {
                Console.WriteLine($"Valor de Saque maior que o saldo disponivel");
            }
        }

        public void ApresentaSaldo()
        {
            Console.WriteLine($"O saldo é: R${saldo}");
        }
    }

}
