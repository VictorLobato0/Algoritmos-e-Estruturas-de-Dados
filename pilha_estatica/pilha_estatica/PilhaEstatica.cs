using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilha_estatica
{
    internal class PilhaEstatica
    {
        private int[] vetor;
        private int topo;

        public PilhaEstatica(int tamanho)
        {
            vetor = new int[tamanho];
            topo = -1;
        }

        public void empilhar (int valor)
        {
            if (cheio())
            {
                Console.WriteLine("Vetor está cheio");
            }

            topo++;
            vetor[topo] = valor;
        }
        public bool cheio()
        {
            return topo == vetor.Length - 1;
        }
        public int desempilhar()
        {
            int valor = vetor[topo];
            topo--;
            return valor;
        }
        public bool vazia ()
        {
            return topo == -1;
        }

        public void Imprimir()
        {
            if (vazia())
            {
                Console.WriteLine("A pilha está vazia!");
                return;
            }
            Console.Write("Pilha: ");
            for (int i = 0; i <= topo; i++)
            {
                Console.Write("{0} ", vetor[i]);
            }
            Console.WriteLine();
        }

    }
}
