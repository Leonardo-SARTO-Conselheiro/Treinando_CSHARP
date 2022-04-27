using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrada_Saida_de_Dados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //entrada de dados, não quebra a linha//
            Console.Write("Homer");

            //entrada de dados, quebra de linha//
            Console.WriteLine("Teste");

            //imprime o codigo do caractere que for digitado(se eu digitar//
            //A = 65 que é seu codigo numerico, imprimere somente de uma tecla//
            //int letra = Console.Read();
            //Console.WriteLine(letra);

            //lê os dados digitados e imprime na tela//
            string texto = Console.ReadLine();
            Console.WriteLine(texto);

            //o 1 readkey para imprimir a letra/numero que eu digitar, o 2 readkey encerra o programa//
            //Console.ReadKey(false);
            Console.ReadKey();



        }
    }
}
