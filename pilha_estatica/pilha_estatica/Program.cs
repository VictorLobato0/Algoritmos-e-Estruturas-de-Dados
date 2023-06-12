using System;

namespace pilha_estatica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho da pilha: ");
            int tamanho = int.Parse(Console.ReadLine());

            PilhaEstatica pilha = new PilhaEstatica(tamanho);

            while (true)
            {
                Console.WriteLine();
                Console.Write("Deseja manipular a pilha? (S/N) ");
                string resposta = Console.ReadLine();
                if (resposta.ToLower() == "n")
                {
                    break;
                }

                Console.WriteLine();
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Empilhar um valor");
                Console.WriteLine("2 - Desempilhar um valor");
                Console.WriteLine("3 - Verificar se a pilha está cheia");
                Console.WriteLine("4 - Verificar se a pilha está vazia");
                Console.WriteLine();

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o valor a ser empilhado: ");
                        int valor = int.Parse(Console.ReadLine());
                        pilha.empilhar(valor);
                        pilha.Imprimir();
                        break;
                    case 2:
                        int valorDesempilhado = pilha.desempilhar();
                        Console.WriteLine("Valor desempilhado: {0}", valorDesempilhado);
                        pilha.Imprimir();
                        break;
                    case 3:
                        bool pilhaCheia = pilha.cheio();
                        Console.WriteLine("A pilha está cheia? {0}", pilhaCheia);
                        pilha.Imprimir();
                        break;
                    case 4:
                        bool pilhaVazia = pilha.vazia();
                        Console.WriteLine("A pilha está vazia? {0}", pilhaVazia);
                        pilha.Imprimir();
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }
    }

}