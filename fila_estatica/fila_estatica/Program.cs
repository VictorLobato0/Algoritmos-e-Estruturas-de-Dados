using System;

namespace fila_estatica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho da fila: ");
            int tamanho = int.Parse(Console.ReadLine());

            FilaEstatica fila = new FilaEstatica();
            fila.CriarFila(tamanho);

            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine();
                Console.WriteLine("Escolha uma das opções abaixo:");
                Console.WriteLine("1 - Enfileirar um valor");
                Console.WriteLine("2 - Desenfileirar um valor");
                Console.WriteLine("3 - Verificar se a fila está cheia");
                Console.WriteLine("4 - Verificar se a fila está vazia");
                Console.WriteLine("0 - Sair");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o valor a ser enfileirado: ");
                        int valor = int.Parse(Console.ReadLine());
                        fila.Enfileirar(valor);
                        fila.ImprimirFila();
                        break;
                    case 2:
                        fila.Desenfileirar();
                        fila.ImprimirFila();
                        break;
                    case 3:
                        fila.FilaCheia();
                        fila.ImprimirFila();
                        break;
                    case 4:
                        fila.FilaVazia();
                        fila.ImprimirFila();
                        break;
                    case 0:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }
    }
}