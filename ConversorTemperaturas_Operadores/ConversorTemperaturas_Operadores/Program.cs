using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperaturas_Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c, f, k;

            Console.WriteLine("### CONVERSOR DE TEMPERATURAS ###");
            Console.Write("Insira a temperatura em Celcius: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------\n");

            //conta para converter celcius em fahrenheit
            f = (c * 9 / 5) + 32;

            //conta para converter celcius em kelvin
            k = c + 273.15;

            Console.WriteLine(c + " Graus Celcius = " + f + " graus fahrenheit\n");
            Console.WriteLine(c + " Graus Celcius = " + k + " graus kelvin\n");
            Console.WriteLine("-------------------------------");
            Console.ReadKey();


        }
    }
}
