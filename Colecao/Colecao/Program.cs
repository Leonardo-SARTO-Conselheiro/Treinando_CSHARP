using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Vetores
            ///começa em 0///
            //int[] numeros = new int[5]; //o maximo de elementos que ele pode armezar é 5

            //numeros[0] = 10;
            //numeros[1] = 20;
            //numeros[2] = 30;
            //numeros[3] = 40;
            //numeros[4] = 50;

            ///para modificar/// 
            //numeros[2] = 55;

            //string[] nomes = new string[3];
            //nomes[0] = "Leonardo";
            //nomes[1] = "Sarto";
            //nomes[2] = "Conselheiro";

            ///dessa forma ja atribuo e nao defino um tamanho para a array///
            //string[] animais = 
            //{
            //"Leão", 
            //"Onça", 
            //"Jacaré"
            //};

            ///para imprimir o numero que consta no 2 indice/// 
            //Console.WriteLine(nomes[0]);
            //Console.WriteLine(numeros[2]);
            //Console.WriteLine(animais[1]);
            //Console.ReadKey();
            #endregion Vetores

            #region Matrizes
            ///a virgula defini que é bidemensional, um lado dela é linha outro coluna
            int[,] numeros = new int[2, 3]; ///2 linhas e 3 colunas///

           
            numeros[0, 0] = 10;
            numeros[0, 1] = 20;
            numeros[0, 2] = 30;

            numeros[1, 0] = 40;
            numeros[1, 1] = 50;
            numeros[1, 2] = 60;

            Console.Write("[" + numeros[0,0] + "]");
            Console.Write("[" + numeros[0, 1] + "]");
            Console.Write("[" + numeros[0, 2] + "]");

            ///só para quebrar a linha///
            Console.WriteLine();

            Console.Write("[" + numeros[1, 0] + "]");
            Console.Write("[" + numeros[1, 1] + "]");
            Console.Write("[" + numeros[1, 2] + "]");

            Console.WriteLine();

            ///cada virgula é para separarar uma coluna///
            string[,] nomes =
            {
                ///se eu definir com três nomes, so posso incluir nas colunas posteriores 3 nomes.
                {"Leonardo", "Barbara", "João" },
                {"Nil", "Liza", "José" }
            };

            Console.WriteLine(nomes[0, 1]);
            Console.ReadKey();
            #endregion Matrizes
        }
    }
}
