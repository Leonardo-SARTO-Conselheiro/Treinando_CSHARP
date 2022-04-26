using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comentarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            para abrir e fechar grandes comentarios
            */


            // este comando mostra a mensagem "Hello World"
            #region Primeira parte
            Console.WriteLine("Hello World");
            Console.WriteLine("Hello World");
            Console.WriteLine("Hello World");
            Console.WriteLine("Hello World");
            Console.WriteLine("Hello World");
            #endregion

            #region Segunda Parte
            Console.WriteLine("Hello World");
            Console.WriteLine("Hello World");
            Console.WriteLine("Hello World");
            Console.WriteLine("Hello World");
            #endregion

            // este comando só fecha o programa "Hello World" quando eu digitar alguma coisa
            Console.ReadKey();
        }
    }
}
