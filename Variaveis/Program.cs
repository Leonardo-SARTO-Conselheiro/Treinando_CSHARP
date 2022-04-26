using System;

namespace Variaveis
{
    internal class Program
    {
        //enum tem que ser declarado na raiz da classe, para ser utilizada nela
        //enum e como se criaciamos a variavel Notas, e ela aceitasse Minimo, Media e Maxima 
        //enum Notas
        //{
            //Minimo = 5,
            //Media = 7,
            //Maxima = 20
        //}

        //struct Pessoa // crio a estrutura para engolar essas variaveis, evitando eu criar variavel por variavel
                      // assim como no enum e como se criaciamos a variavel pessoa e ela
                      // aceitasse nome, idade e altura.
        //{           
            //public string nome;
            //public int idade;
            //public double altura;
        //}

        static void Main(string[] args)
        {

            #region Numeros Integrais
            //int num1 = 200;
            //int num2;
            //int num3;

            //eu declarei que minha variavel num1 tinha o valor de 200 e a num2 era igual a num1
            //num2 = num1;
            // declarei minha variavel num3 sem valor, só inclui o valor agora
            //num3 = 100;

            //vai mostrar a num2(200)+ a num3 (100) que é = 300
            //Console.WriteLine(num2 + num3);
            //Console.ReadKey();
            #endregion


            #region Numeros Reais 
            //float real1 = 100.75f; //preciso por f no final de float
            //double real2 = 12500.45;
            //decimal real3 = 752538.457m; //preciso por m no final de real

            //double valor; // iniciando uma nova variavel do tipo double
            //valor = real1 / real2; // falando que a variavel valor criada acima é o valor da variavel 
            // real1 dividio pelo valor da variavel real2

            //Console.WriteLine(valor); 
            //Console.ReadKey();
            #endregion


            #region Tipo Caractere (char)

            // \u e mais a sequencia do codigo (no caso do a é 0041) vao ser imprimido a letra a tbm
            // pq esse codigo representa os numeros binarios, de linguagem direta com a maquina
            //char letra = '\u0041'; //só cabe 1 caractere, esse codigo representa o a
            //char escape = '\0'; // \\ representar uma barra só,\n para pular linha e \0 declara nulo
            //char literal = 'c';

            //Console.WriteLine(literal);
            //Console.WriteLine(escape);
            //Console.WriteLine(letra);
            //Console.ReadKey();

            #endregion


            #region Tipo Booleano
            //bool verificar = false; //declarei que verificar quer dizer falso
            //verificar = true; //aqui eu troquei, disse que verificar quer dizer verdadeiro

            //Console.WriteLine(verificar);   
            //Console.ReadKey();
            #endregion


            #region Tipo String
            //string texto = "Leonardo $arto 1.9.9.9\n"; //declarei que texto é igual a mensagem
            //string mensagem = null; //declarei que texto é nulo, ele pode receber a mensagem de outra
            // string, como da texto2
            //string texto2 = "dev jr, buscando a primeira oportunidade\n"; //disse que a string mensagem
            // esta recebendo o valor escrito nesse texto2
            //string mensagem2 = //deixei vazio, e na mensagem2 disse o que queria que fosse escrito

            //mensagem = texto2; //diz que mensagem é igual ao que ta escrito no texto2

            //mensagem2 = "Conhecimentos em C# e JS\n";//como deixei a string mensagem2 vazia,
            // aqui passo a mensagem pra ela 

            //Console.WriteLine(texto);
            //Console.WriteLine(mensagem);
            //Console.WriteLine(mensagem2);
            //Console.ReadKey();
            #endregion


            #region Tipo Var
            //var valor1 = 100;//se eu iniciliar ela como um valor inteiro, ela vai ser sempre inteiro
            // no caso coloquei valor1 = 100, entao não posso colocar que valor1
            // é igual a "leo" ou "true", por exemplo.
            //var valor2 = 200;

            //var nome1 = "leonardo sarto";



            //Console.WriteLine( valor1 * valor2 );
            //Console.WriteLine(nome1);
            //Console.ReadKey();
            #endregion


            #region Tipo Object

            //object são object, por exemplo, não é um int, então nao conseguira fazer uma conta

            //object obj1 = 100; //object nao assume valores igual var, ela é a base de todos os valores(tipos)
            // diferente do var, eu posso fazer um int virar uma string
            //object obj2 = "Leo";
            //obj1 = true;

            //object obj3 = 100;
            //object obj4 = 200;

            // ao tentar vai aparecer que object nao pode ser aplicado operadores
            //Console.WriteLine(obj3 + obj2);
            //Console.ReadKey(); 
            #endregion


            #region Tipo Const
            //const double pi = 3.1415;//o valor inicial precisa ser declarado e não pode ser alterado
            //const string nome = "Leonardo";

            //vai dar erro, pois não é possivel alterar o valor de pi, por causa da const
            //pi = 2222;

            //Console.WriteLine(pi);
            //Console.WriteLine(nome);
            //Console.ReadKey();
            #endregion


            #region Enum

            //Notas notasAulanos = Notas.Minimo;


            //Console.WriteLine(notasAulanos);
            //Console.ReadKey();
            #endregion


            #region Struct

            //Pessoa p1 = new Pessoa();
            //p1.nome = "Leonardo";
            //p1.idade = 22;
            //p1.altura = 1.85;

            //Pessoa p2 = new Pessoa() //como abre ele com {} não preciso colocar p2.
            //{
                //nome = "Yasmin",
                //idade = 22,
                //altura = 1.55
            //};

            //p1.nome = "Léo"; //para alterar o nome

            //Console.WriteLine(p1.nome);
            //Console.WriteLine(p1.idade);
            //Console.WriteLine(p1.altura);

            //Console.WriteLine();

            //Console.WriteLine(p2.nome);
            //Console.WriteLine(p2.idade);
            //Console.WriteLine(p2.altura);
            //Console.ReadKey();
            #endregion

        }
    }
}
