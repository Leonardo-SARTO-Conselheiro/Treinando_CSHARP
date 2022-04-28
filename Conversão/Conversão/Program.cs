using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversão
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Conversão Implícita de Tipos Numéricos
            //a variavel do tipo float cabem na do tipo double, então posso fazer essa conversão//
            //a abragência de valores deve estar dentro do compatível, no caso a variavel double//
            //não caberia na float, já que ela "tem o dobro" de seu valor.//
            //float num1 = 100.00f;
            //double num2;

            //num2 = num1;

            //Console.WriteLine(num2);
            //Console.ReadKey();
            #endregion

            #region Conversão Explícita de Tipos Numéricos

            //a variavel que vai receber o valor não suporta aquele tipo de dado//
            //como double é maior que float, não é possivel fazer conversão implícita//
            //então temos que fazer a explícita "forçando" essa conversão//
            //double num1 = 10000;
            //float num2 = (float)num1;

            //Console.WriteLine(num2);
            //Console.ReadKey();


            //nesse caso vai haver perda de dados, pq int não aceita as casas decimais do float//
            //float num3 = 2500.00f;
            //int num4 = (int)num3;

            //nao preciso por necessesariamente o valor da variavel, posso por o valor direto//
            //int num4 = (int)1999.01;

            //Console.WriteLine(num4);
            //Console.ReadKey();
            #endregion

            #region Método Parse
            //converte uma string que corresponde a numero a um valor numerico//
            //ao realizar um Parse eu transformo essa string em um numero//
            //possibilitando até a realização de contas matematicas//
            //todos os valores numericos (float, double, int, etc) aceitam o PARSE//
            //string txtNumero1 = "1999";
            //int numero1 = int.Parse(txtNumero1);
            //string txtNumero2 = "2022";
            //int numero2 = int.Parse(txtNumero2);


            //no caso eu tenho que usar a , nao o . pq inicialmente se trata de uma string//
            //string txtNumero3 = "10,0";
            //double numero3 = double.Parse(txtNumero3);
            //aqui eu não define o valor da variavel numero, como no caso acima//
            //double numero4 = double.Parse("15,5");


            //nesse caso, não preciso colocar o f no final dos valores//
            //string txtNumero5 = "5";
            //float numero5 = float.Parse(txtNumero5);
            //float numero6 = float.Parse("8,7");


            //nesse exemplo fiz as contas//
            //Console.WriteLine(numero2 - numero1);
            //Console.WriteLine(numero3 + numero4);
            //Console.WriteLine(numero5 * numero6);
            //Console.ReadKey();
            #endregion

            #region Classe Convert
            //permite converter um tipo de dado base em outro tipo de dado base//
            //através dos métodos disponiveis// 
            //posso converter qualquer tipo de dado para qualquer outro tipo de dado//
            

            //aqui eu estou convertento uma string que recebeu como valor um int//
            //ao executar, vai me voltar como uma string, mesmo esse valor sendo int//
            string texto = Convert.ToString(2500);


            //nesse caso ele vai me retornar o numero do double,//
            //mesmo sendo um booleano, como o valor numero de true é 1 ele vai me retornar 1//
            double num1 = Convert.ToDouble(true);


            //aqui um int recebeu como valor um char//
            // vou ter como retorno 65 que é o numero int que representa o A (char)//
            int num2 = Convert.ToInt32('A');


            //esse é um exemplo de como não é possivel converter tudo//
            double num3 = Convert.ToDouble('C');


            Console.WriteLine(num3);
            Console.ReadKey();
            #endregion
        }
    }
}
