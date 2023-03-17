using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_4
{     // criação de classe
    internal class triangulo
    {  
        // declaração de atributos privados
        private float a;
        private float b;
        private float c;

        //deixando classe publica
        public triangulo() { }

        public triangulo(float a, float b, float c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        // metodo para trocar o valor da variavel A
        public void setA(float a)
        {
            this.a = a;
        } 
        // metodo para pegar o  valor da variavel A
        public float getA()
        {
            return this.a;
        }
        // metodo para trocar o valor da variavel B
        public void setB(float b)
        {
            this.b = b;
        }
        // metodo para pegar o valor da variavel B
        public float getB()
        {
            return this.b;
        }
        // metodo para mudar o valor da variavel C
        public void setC(float c)
        {
            this.c = c;
        }
        // metodo para pegar o valor da variavel C
        public float getC()
        {
            return this.c;
        }
        // metodo para calcular e imprimir tipo do triangulo
        public void imprimirDados()
        {
            if (a >= b + c)
            {
                Console.WriteLine("Não forma um triangulo");
            }

            else if (a * a == ((b * b) + (c * c)))
            {
                Console.WriteLine("Triangulo Retaingulo");
            }

            else if (a * a > ((b * b) + (c * c)))
            {
                Console.WriteLine("Triangulo Obtusangulo");
            }
            else if ((a == b) && (b == c))
            {
                Console.WriteLine("Triangulo equilatero");
            }
            else if (a * a < ((b * b) + (c * c)))
            {
                Console.WriteLine("Triangulo Acutangulo");
            }
            else
            {
                Console.WriteLine("Triangulo isosceles");
            }
        }
    }
}
