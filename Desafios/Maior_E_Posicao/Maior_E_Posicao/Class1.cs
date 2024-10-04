/*
Desafio
Você recebeu o desafio de ler 100 valores inteiros. Apresente então o maior valor lido e a posição dentre os 100 valores lidos.

Entrada
O arquivo de entrada contém 100 números inteiros, positivos e distintos.

Saída
Apresente o maior valor lido e a posição de entrada, conforme exemplo abaixo.

Exemplo de Entrada	
2
113
45
34565
6
...
8
 
Exemplo de Saída
34565
4

*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Lista para armazenar os 100 valores
        List<int> valores = new List<int>();

        // Lendo os 100 valores inteiros
        for (int i = 0; i < 100; i++)
        {
            int numero = int.Parse(Console.ReadLine());
            valores.Add(numero);
        }

        // Encontrando o maior valor e sua posição
        int maiorValor = int.MinValue;
        int posicao = 0;

        for (int i = 0; i < valores.Count; i++)
        {
            if (valores[i] > maiorValor)
            {
                maiorValor = valores[i];
                posicao = i + 1;  // +1 para ajustar a posição a partir de 1
            }
        }

        // Exibindo o maior valor e a posição
        Console.WriteLine(maiorValor);
        Console.WriteLine(posicao);
    }
}