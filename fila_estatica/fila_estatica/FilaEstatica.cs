using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fila_estatica
{
    class FilaEstatica
    {
        private int[] vetor;
        private int inicio;
        private int fim;
        private int tamanho;

        public void CriarFila(int tamanhoMaximo)
        {
            vetor = new int[tamanhoMaximo];
            tamanho = tamanhoMaximo;
            inicio = -1;
            fim = -1;
        }

        public void Enfileirar(int valor)
        {
            if (fim == tamanho - 1)
            {
                Console.WriteLine("A fila está cheia.");
            }
            else
            {
                fim++;
                vetor[fim] = valor;
                if (inicio == -1)
                {
                    inicio = 0;
                }
            }
        }

        public void Desenfileirar()
        {
            if (inicio == -1 || inicio > fim)
            {
                Console.WriteLine("A fila está vazia.");
            }
            else
            {
                Console.WriteLine("Valor removido: {0}", vetor[inicio]);
                inicio++;
                if (inicio > fim)
                {
                    inicio = fim = -1;
                }
            }
        }

        public void FilaCheia()
        {
            if (fim == tamanho - 1)
            {
                Console.WriteLine("A fila está cheia.");
            }
            else
            {
                Console.WriteLine("A fila não está cheia.");
            }
        }

        public void FilaVazia()
        {
            if (inicio == -1 || inicio > fim)
            {
                Console.WriteLine("A fila está vazia.");
            }
            else
            {
                Console.WriteLine("A fila não está vazia.");
            }
        }

        public void ImprimirFila()
        {
            if (inicio == -1 || inicio > fim)
            {
                Console.WriteLine("A fila está vazia.");
            }
            else
            {
                Console.Write("Valores na fila: ");
                for (int i = inicio; i <= fim; i++)
                {
                    Console.Write("{0} ", vetor[i]);
                }
                Console.WriteLine();
            }
        }
    }
}