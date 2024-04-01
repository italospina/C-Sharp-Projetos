/*
Desafio
Você receberá dois valores inteiros. Faça a leitura e em seguida calcule o produto entre estes dois valores. Atribua esta operação à variável PROD, mostrando esta de acordo com a mensagem de saída esperada (exemplo abaixo).   

Entrada
A entrada contém 2 valores inteiros.

Saída
Exiba a variável PROD conforme exemplo abaixo, tendo obrigatoriamente um espaço em branco antes e depois da igualdade.

 
Exemplos de Entrada|	Exemplos de Saída
3 e 9              |    PROD = 27
                   |
-30 e 10           |    PROD = -300             
                   |
0 e 9              |    PROD = 0          
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        int a, b;
        Console.WriteLine("Calculando a multiplicação do produto entre dois valores");
        Console.WriteLine("Digite o Primeiro valor:");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor:");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("PROD = " + (a * b)); //implemente o código que representa a multiplicação.
        Console.ReadLine();
    }
}