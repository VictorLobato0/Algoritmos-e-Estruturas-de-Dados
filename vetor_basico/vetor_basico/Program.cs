using System;
using System.Linq;


namespace vetor_basico { 

public class Program
{
        public static void Main()
        {
            int[] numeros = new int[5];
            numeros[0] = 2;
            numeros[1] = 4;
            numeros[2] = 15;
            numeros[3] = 11;
            numeros[4] = 2; // meu vetor acaba aqui.
                           

            Console.WriteLine("Eu sou o número da posição 0: " + numeros[0]);  // exibir 2
            Console.WriteLine("Eu sou o número da posição 1: " + numeros[1]);  // exibir 4
            Console.WriteLine("Eu sou o número da posição 2: " + numeros[2]);  // exibir 15
            Console.WriteLine("Eu sou o número da posição 3: " + numeros[3]);  // exibir 11
            Console.WriteLine("Eu sou o número da posição 4: " + numeros[4]);  // exibir 2

            int[] numeros2 = new int[5];

            Console.WriteLine("Digite 5 números (pressione Enter para cada número");

            // Armazena dados no vetor
            for (int p = 0; p < numeros2.Length; p++)
            {
                numeros2[p] = Convert.ToInt32(Console.ReadLine());
            }

            // Recupera os dados armazenados no vetor
            Console.WriteLine("\n\nEstes são os números que você digitou");
            for (int p = 0; p < numeros2.Length; p++)
            {
                Console.WriteLine(numeros2[p]);
            }

            // Recupera os dados armazenados no vetor
            Console.WriteLine("\n\nEstes são os números que você digitou");
            foreach (int item in numeros2)
            {
                Console.WriteLine(item);
            }
        }
    }

}