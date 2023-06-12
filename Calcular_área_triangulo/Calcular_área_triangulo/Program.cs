using System;
using System.Globalization;


namespace Calcular_área_triangulo
{



    internal class Program
    {
        static void Main(string[] args)
        {

            //Calcular a area de 2 triangulos e exibir o que tem maior area

            //criando as variaveis dos triangulos
            double vA, vB, vC, v2A, v2B, v2C;

            //Primeiro Triangulo X
            Console.WriteLine("Entre com as medidas do triângulo X:");
            Console.WriteLine("Digite o valor do lado a:");
            vA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor do lado b:");
            vB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor do lado c:");
            vC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Segundo traingulo Y
            Console.WriteLine("Entre com as medidas do triângulo Y:");
            Console.WriteLine("Digite o valor do lado a:");
            v2A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor do lado b:");
            v2B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor do lado c:");
            v2C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Calculando area do traingulo x
            double p = (vA + vB + vC) / 2.0;
            double areaX = Math.Sqrt(p * (p - vA) * (p - vB) * (p - vC));

            //calculando a area do triangulo y
            p = (v2A + v2B + v2C) / 2.0;
            double areaY = Math.Sqrt(p * (p - v2A) * (p - v2B) * (p - v2C));

            //Exibindo os resultados das areas
            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            //testando quem tem a maior area.
            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");

            }


        }
    }


}  