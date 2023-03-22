using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Pr2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exercicio 1
            //double x, y;
            //Console.WriteLine("Quantas laranjas voce vai comprar ? ");
            //x = double.Parse(Console.ReadLine());
            //if (x < 12) ;
            //y = x * 0.35;
            //Console.WriteLine(y + " reais");
            //else
            //    y = x * 0.28;
            //Console.WriteLine(y + "reais ");

            //exercicio 2
            //double a1, af;

            //Console.WriteLine("digite o ano do seu nascimento");
            //a1=double.Parse(Console.ReadLine());
            //af = 2026 -a1;
            //    if(af<16)
            //    Console.WriteLine("voce nao pode votar pq voce tem : "+af+" anos");
            //    else
            //    Console.WriteLine( "voce pode votarpq voce tem : " + af + " anos");

            //exerc 3
            //double l1, l2, l3;
            //Console.WriteLine("digite o lado 1: ");
            //l1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("digite o lado 2: ");
            //l2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("digite o lado 3: ");
            //l3 = double.Parse(Console.ReadLine());

            //if (l1 == l2 && l1 == l3)
            //    Console.WriteLine("o triangulo é equilatero");
            //else if (l1 == l2 && l2 != l3 || l1==l3 && l2!=l3)
            //    Console.WriteLine("o triangulo é isosceles");
            //else if (l1!=l2 && l2!= l3)
            //    Console.WriteLine("o triangulo é escaleno");

            //exerc 4 
            //double a, b, c, delta, b1, bah ,a1;
            //Console.WriteLine("digite o valor de A: ");
            //a=double.Parse(Console.ReadLine());
            //Console.WriteLine( "digite o valor de B: " );
            //b=double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor de C: ");
            //c=double.Parse(Console.ReadLine());
            //b1 = b * b;
            //delta = b1 - 4 * a * c;

            //a1 = 2 * a;
            //bah = - b +- Math.Sqrt (delta) / (a1);

            //Console.WriteLine(bah); 

            //exerc5
            //double n, div3, div5;
            // Console.WriteLine("digite o número: ");
            // n = double.Parse(Console.ReadLine());

            // if (n % 3 == 0) 
            // Console.WriteLine("o numemro é divisivel por 5");

            //else if (n % 5  == 0) 
            // Console.WriteLine("o numero é divisivel por 3");

            //else if (n % 3 == 0 && n % 5 == 0) 
            // Console.WriteLine("o numero é dividido por 3 e por 5");

            //exerc 6
            //double a1, a2, a3;
            //Console.WriteLine( "insira o valor do angulo 1: ");
            //a1=double.Parse( Console.ReadLine() );
            //Console.WriteLine("insira o valor do angulo 2: ");
            //a2=double.Parse( Console.ReadLine() );
            //Console.WriteLine("digite o valor do angulo 3: ");
            //a3=double.Parse( Console.ReadLine() );

            //if (a1 == 90 || a2 == 90 || a3 == 90)
            //    Console.WriteLine("o triangulo é retangulo");
            //else if (a1 < 90 && a2 < 90 && a3 < 90)
            //    Console.WriteLine("o triangulo é agudo");
            //else if (a1 > 90 || a2 > 90 || a3 > 90) ;
            //Console.WriteLine("o triangulo é obtuso");

            //exerc7
            //int a, b, c;
            //Console.WriteLine("escreva o 1º valor: ");
            //a=int.Parse(Console.ReadLine());
            //Console.WriteLine("escreva o 2º valor: ");
            //b = int.Parse(Console.ReadLine());
            //Console.WriteLine("escreva o 3º valor: ");
            //c = int.Parse(Console.ReadLine());

            //if (a < b && b < c) 
            //Console.WriteLine(a + " " + b + " " +  c);
            //else  if (a > b && b > c ) 
            //Console.WriteLine(c + " " + b + " " + a);
            //else if (b > a && a > c) 
            //Console.WriteLine(c + " " + a + " " + b );
            //else if (b<a && a<c)
            //Console.WriteLine(b + " "+ a + " " + c);
            //else if (a<c && c<b)
            //Console.WriteLine(a + " " + c + " " + b);
            //else if (b<c && c<a)
            //Console.WriteLine(b + " " + c + " " + a);

            //exerc 8 
            //int ano;
            //Console.WriteLine("Digite um ano: ");
            //ano = int.Parse(Console.ReadLine());

            //if (DateTime.IsLeapYear(ano))
            //{
            //    Console.WriteLine("{0} é um ano bissexto.", ano);
            //}
            //else
            //{
            //    Console.WriteLine("{0} não é um ano bissexto.", ano);

            //exerc 9
            //Console.Write("Digite o primeiro número: ");
            //double num1 = double.Parse(Console.ReadLine());

            //Console.Write("Digite o segundo número: ");
            //double num2 = double.Parse(Console.ReadLine());

            //Console.Write("Digite a operação (+, -, / ou *): ");
            //char operacao = char.Parse(Console.ReadLine());

            //double resultado = 0;

            //switch (operacao)
            //{
            //    case '+':
            //        resultado = num1 + num2;
            //        break;
            //    case '-':
            //        resultado = num1 - num2;
            //        break;
            //    case '/':
            //        resultado = num1 / num2;
            //        break;
            //    case '*':
            //        resultado = num1 * num2;
            //        break;
            //    default:
            //        Console.WriteLine("Operação inválida.");
            //        return;
            //}

            //Console.WriteLine("Resultado: " + resultado);

            // exerc 10
            // Na linguagem de programação C#, os números inteiros podem ser gerados aleatoriamente usando a classe Random. A classe Random é uma classe que fornece métodos para gerar números aleatórios em C#.
            // Para gerar um número inteiro aleatório, você pode usar o método Next da classe Random.O método Next retorna um número inteiro aleatório dentro de um intervalo especificado.Por exemplo, o seguinte código gera um número inteiro aleatório entre 0 e 99:
            //Para gerar números reais aleatórios em C#, você pode usar o método NextDouble da classe Random. O método NextDouble retorna um número aleatório entre 0,0 e 1,0. Você pode multiplicar o resultado pelo intervalo desejado para obter um número real aleatório dentro desse intervalo
        }
    }
   }

