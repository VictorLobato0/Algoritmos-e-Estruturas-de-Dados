using System;
using System.Globalization;


namespace Calcular_triangulos_classe
{


        internal class Program
        {
            static void Main(string[] args)
            {

                //usando a classe traingulo para criar os objetos triangulo x e y
                Triangulo x, y;
                x = new Triangulo();
                y = new Triangulo();

                //Recebendo valores para o objeto triangulo x
                Console.WriteLine("Entre com as medidas do triângulo X:");
                x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //recebendo os valores para o objeto triangulo y
                Console.WriteLine("Entre com as medidas do triângulo Y:");
                y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //calculando a area do objeto traingulo x
                double p = (x.A + x.B + x.C) / 2.0;
                double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

                //calculando a area do objeto traingulo y
                p = (y.A + y.B + y.C) / 2.0;
                double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));
                Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
                Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

                //verificando quem tem a maior area
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
