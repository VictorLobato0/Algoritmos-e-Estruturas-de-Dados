using System;
using System.Collections.Generic;

namespace arvore_binaria { 

    public class No
    {
        public int valor;
        public No esquerda;
        public No direita;

        public No(int valor)
        {
            this.valor = valor;
            this.esquerda = null;
            this.direita = null;
        }
    }

    public class ArvoreBinaria
    {
        public static void Inserir(No raiz, int valor)
        {
            if (valor < raiz.valor)
            {
                if (raiz.esquerda == null)
                {
                    raiz.esquerda = new No(valor);
                }
                else
                {
                    Inserir(raiz.esquerda, valor);
                }
            }
            else if (valor > raiz.valor)
            {
                if (raiz.direita == null)
                {
                    raiz.direita = new No(valor);
                }
                else
                {
                    Inserir(raiz.direita, valor);
                }
            }
        }

        public static void ImprimirNiveis(No raiz)
        {
            if (raiz == null)
            {
                return;
            }

            Queue<No> fila = new Queue<No>();
            fila.Enqueue(raiz);

            while (fila.Count > 0)
            {
                int tamanhoNivel = fila.Count;
                Console.Write("Nível: ");

                for (int i = 0; i < tamanhoNivel; i++)
                {
                    No no = fila.Dequeue();
                    Console.Write($"{no.valor} ");

                    if (no.esquerda != null)
                    {
                        fila.Enqueue(no.esquerda);
                    }
                    if (no.direita != null)
                    {
                        fila.Enqueue(no.direita);
                    }
                }

                Console.WriteLine();
            }
        }

        public static void Main()
        {
            No raiz = null;

            Console.WriteLine("Digite uma sequência de números inteiros separados por espaço:");

            string entrada = Console.ReadLine();
            string[] valores = entrada.Split(' ');

            foreach (string valorStr in valores)
            {
                int valor;
                if (int.TryParse(valorStr, out valor))
                {
                    if (raiz == null)
                    {
                        raiz = new No(valor);
                    }
                    else
                    {
                        Inserir(raiz, valor);
                    }
                }
                else
                {
                    Console.WriteLine($"Valor inválido: {valorStr}. Ignorando o valor.");
                }
            }

            Console.WriteLine("\nÁrvore binária construída!\n");

            Console.WriteLine("Impressão dos níveis da árvore:");
            ImprimirNiveis(raiz);
        }
    }

}