using Exemplos_Esplorando.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

int numero = 15;
bool par = false;

par = numero.EhPar();
Console.WriteLine($"o NUMERO {numero} é " + (par ? "par" : "impar"));

