using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_3_AED1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vendedor a = new Vendedor();

            Console.WriteLine("Digite o Nome do infeliz assalariado:" );
            a.Nome =  Console.ReadLine();
            Console.WriteLine("Digite o salario do infeliz assalariado:");
            a.Salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o vendas do infeliz assalariado:");
            a.Vendas = double.Parse(Console.ReadLine());

            a.transacao();



        }
    }
}
