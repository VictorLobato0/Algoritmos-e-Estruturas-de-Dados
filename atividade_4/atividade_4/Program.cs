using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_4
{
    internal class Program
    {
        static void Main(string[] args)
        {   // Criação do objeto para uso da classe triangulo
            triangulo blastoise = new triangulo();


            Console.WriteLine("Digite um valor para a:");
            blastoise.setA(float.Parse(Console.ReadLine()));
            Console.WriteLine("Digite um valor para b:");
            blastoise.setB(float.Parse(Console.ReadLine()));
            Console.WriteLine("Digite um valor para a:");
            blastoise.setC(float.Parse(Console.ReadLine()));

            blastoise.imprimirDados();




        }
    }
}
