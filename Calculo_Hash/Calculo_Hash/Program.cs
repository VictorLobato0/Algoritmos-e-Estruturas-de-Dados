using System;

namespace calculo_Hash { 

    public class HashTable
    {
        private int size; // Tamanho da tabela hash definido pelo usuário
        private int[] data; // Vetor para armazenar os dados

        public HashTable(int size)
        {
            this.size = size;
            data = new int[size]; // Inicializa o vetor com o tamanho definido
        }

        private int HashFunction(int key)
        {
            // Função hash simples que retorna um índice com base no resto da divisão da chave pelo tamanho da tabela
            return key % size;
        }

        public void Insert(int key)
        {
            int index = HashFunction(key); // Obtém o índice usando a função hash

            // Verifica se o índice está vazio
            if (data[index] == 0)
            {
                data[index] = key; // Insere o valor no índice vazio
            }
            else
            {
                // Tratamento de colisão: procura pelo próximo índice vazio utilizando sondagem linear
                int nextIndex = (index + 1) % size; // Calcula o próximo índice
                while (data[nextIndex] != 0)
                {
                    nextIndex = (nextIndex + 1) % size; // Avança para o próximo índice
                }
                data[nextIndex] = key; // Insere o valor no próximo índice vazio
            }
        }

        public bool Retrieve(int key)
        {
            int index = HashFunction(key); // Obtém o índice usando a função hash

            // Verifica se o índice contém o valor procurado
            if (data[index] == key)
            {
                return true; // Valor encontrado na tabela hash
            }
            else
            {
                // Tratamento de colisão: realiza uma busca linear no vetor até encontrar o valor ou um índice vazio
                int nextIndex = (index + 1) % size; // Calcula o próximo índice
                while (nextIndex != index && data[nextIndex] != 0 && data[nextIndex] != key)
                {
                    nextIndex = (nextIndex + 1) % size; // Avança para o próximo índice
                }

                // Verifica se encontrou o valor ou se chegou ao índice inicial (valor não encontrado)
                if (data[nextIndex] == key)
                {
                    return true; // Valor encontrado na tabela hash
                }
            }

            return false; // Valor não encontrado na tabela hash
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o tamanho da tabela hash:");
            int size = Convert.ToInt32(Console.ReadLine());

            HashTable table = new HashTable(size);

            Console.WriteLine("Digite os valores a serem inseridos (digite 'fim' para encerrar):");
            string input = Console.ReadLine();
            while (input != "fim")
            {
                int value = Convert.ToInt32(input);
                table.Insert(value);
                input = Console.ReadLine();
            }

            Console.WriteLine("Digite o valor a ser consultado:");
            int searchValue = Convert.ToInt32(Console.ReadLine());

            bool found = table.Retrieve(searchValue);

            if (found)
            {
                Console.WriteLine("O valor {0} foi encontrado na tabela hash.", searchValue);
            }
            else
            {
                Console.WriteLine("O valor {0} não foi encontrado na tabela hash.", searchValue);
            }
        }
    }

}