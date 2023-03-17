using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_3_AED1
{
    internal class Vendedor
    {
        private double salario;
        private string nome;
        private double vendas;



        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        public double Vendas
        {
            get
            {
                return vendas;
            }
            set
            {
                vendas = value;
            }
        }
        public double Salario
        { 
            get { return salario; }
            
            set { salario = value; }
        }

        public void transacao()
        {
            Console.WriteLine("Nome:" + Nome);
            Console.WriteLine("Salario" + Salario);
            Console.WriteLine("Bonus:" + Math.Round((Vendas * 0.15),2));
        }

  

    }        

}

