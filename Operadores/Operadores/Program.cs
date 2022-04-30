using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Operadores Matemáticos
            //int num1 = 15;
            //int num2 = 2;
            //int resultado = num1 + num2;

            //Console.WriteLine(num1 + num2);
            //Console.WriteLine(num1 - num2);
            //Console.WriteLine(num1 * num2);
            //Console.WriteLine(num1 / num2);
            //Console.WriteLine(num1 % num2);


            ///dessa forma estou declarando a variavel no começo///
            //int num1, num2, resultado;

            //Console.WriteLine("Digite o primeiro numero");
            //num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o segundo numero");
            ///Uso o Parse pq num1 e num2 são string e não int///
            //num2 = int.Parse(Console.ReadLine()); 

            //resultado = num1 + num2;

            //Console.WriteLine("O valor dessa soma é\n" + resultado);
            //Console.ReadKey();  


            ///dessa forma declaro a variavel já na sua respectiva linha///
            //Console.WriteLine("Digite o primeiro numero");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o segundo numero");
            ///a numeração dps do int representa o valor que cabe nele///
            //int num2 = Int32.Parse(Console.ReadLine());

            //int resultado = num1 - num2;

            //Console.WriteLine("O resultado é:\n" + resultado);
            //Console.ReadLine();
            #endregion

            #region Precedência de Operadores 
            //double num1 = 100;
            //double num2 = 10;
            //double num3 = 5;
            ///igual na matematica, fizemos a conta do que estiver () primeiro, depois / e *///
            //double res = (num1 + num2) * (num3 / 3);

            //Console.WriteLine(res);
            //Console.ReadKey();
            #endregion

            #region Operadores de Incremento e Decremento
            //int num1 = 10;
            ///++ é para incrementer +1 na variavel num1(10)///
            //num1++;


            //int num1, num2, resultado;

            //num1 = 5;
            //num2 = 15;

            ///como eu usei o ++antes do num2 ele vai aparecer logo após eu dar o start///
            ///implementa e já processa///
            ///o ++ foi no num2 que tinha como valor 15, então esse num2 vai ter como valor 16(5*16)por causa do ++///
            //resultado = num1 * ++num2;

            //Console.WriteLine(resultado);
            //Console.ReadKey();


            //int num1 = 10;
            ///nesse caso como o ++ veio depois do num1, ele só vai aparecer no segundo WriteLine///
            ///primeiro ele implementa, no proximo WriteLine ele processa///
            ///difrente do exemplo acima, como nao é uma conta de * e o num1 é 10,o ++ vai transformar ele em +1(11)///
            //Console.WriteLine(num1++);
            //Console.WriteLine(num1);
            //Console.ReadKey();

            ///num1 = num1 +1;///
            ///num1++///
            ///++num///
            ///num1--///
            ///--num1///
            #endregion

            #region Operador de Concatenação
            //string nome = "Leonardo ";
            //string segundoNome = "Sarto ";
            //string sobrenome = "Conselheiro";
            ///concatenando as variaveis acima/// 
            ///quando se trata de string o + junta os valores para se tratar de apenas um valor///
            //string nomeInteiro = nome + segundoNome + sobrenome;

            //Console.WriteLine(nomeInteiro);
            //Console.ReadKey();

            #endregion

            #region Operadores de Atribuição
            //int num1 = 10;

            ///serve para todas as operações (+-*/%) e tbm para string///
            ///a variavel passa a valer seu proprio valor(10) + 20///
            //num1 += 20;

            ///a variavel passa a valer seu proprio valor(10) - 2///
            //num1 -= 2;

            ///exemplo na string, não soma e sim concatena///
            //string nome = "Leonardo ";
            //nome += "Sarto";

            //Console.WriteLine(nome);
            //Console.ReadKey();
            #endregion

            #region Operadores de Igualdade
            ///como 100 não é igual 50 vai dar false///
            //bool resultado = 100 == 50;

            //Console.WriteLine(resultado);
            //Console.ReadKey();


            ///como 50*2 é igual a 100 ele vai dar true///
            //bool resultado = 100 == 50 * 2;
            ///o !=(diferente de)///
            ///só vai me retornar true se 200 for diferente de 100+100, como é igual me retornou true///
            //bool resultado2 = 200 != 100 + 100;

            //Console.WriteLine(resultado2);
            //Console.ReadKey();


            ///Como Gabriel é igual Gabriel, vai me retornar true///
            //string nome = "Gabriel";
            //bool resultado3 = nome == "Gabriel";

            //Console.WriteLine(resultado3);
            //Console.ReadKey();
            #endregion

            #region Operadores Relacionais
            ///como 100 não é menor que 50, vai retornar false///
            //bool res1 = 100 < 50;
            ///como 100 é menor que 115, vai retornar true///
            //bool res2 = 100 < 50 + 65;
            ///como 100 não é maior que 100, vai retornar false///
            //bool res3 = 100 > 100;
            ///como 100 é igual(ou maior) que 100, vai retornar true///
            //bool res4 = 100 >= 100;

            //Console.WriteLine(res4);
            //Console.ReadKey();  
            #endregion

            #region Operadores Lógicos
            ///&& quando esperamos que as duas expressões sejam verdadeiras///
            /// 
            bool res1 = 100 > 50;
            ///como coloquei != então não pode me retornar true se o valor for true///
            ///então como 50 == 50(true) e tem o != vai me retornar false///
            bool res2 = 50 != 50;
            bool res3 = 100 > 50;
            bool res4 = 100 < 50;

            ///como a res1 é true e res2 é false, vai me retornar false, já que os dois precisavam ser true///
            bool final1 = res1 && res2;
            ///usando o operador || somente um precisa ser true, no caso res3 é verdadeira e res4 é falso///
            ///mesmo assim vai me retornar true, pq é necessario que somente uma seja verdadeira///
            bool final2 = res3 || res4;

            Console.WriteLine(final1);
            Console.WriteLine(final2);
            Console.ReadKey();
            #endregion
        }
    }
}
