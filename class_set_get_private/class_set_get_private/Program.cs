using System;


namespace class_set_get_private
{

    
        internal class Program
        {
            static void Main(string[] args)
            {

                // Cria um objeto da classe Pessoa chamado manutor.
                // Inicialmente o objeto é criado sem nenhuma informação.
                // As informações são adicionadas pelos métodos set.
                bd_provisorio manutor = new bd_provisorio();
                manutor.setNome("Renato Violin");
                manutor.setIdade(28);
                manutor.setRg("12.345-67");

                // Vamos exibir os valores na tela. Para isso usaremos
                // os métodos get.
                Console.WriteLine("Nome.: " + manutor.getNome());
                Console.WriteLine("Rg...: " + manutor.getRg());
                Console.WriteLine("Idade: " + manutor.getIdade());

                // Pular duas linhas
                Console.WriteLine();
                Console.WriteLine();

            // Agora vamos criar um novo objeto manutor2 com os valores já inicializados.
            bd_provisorio manutor2 = new bd_provisorio("Charles", "22.483-95", 75);

                // Vamos exibir os dados na tela
                Console.WriteLine("Nome.: " + manutor2.getNome());
                Console.WriteLine("Rg...: " + manutor2.getRg());
                Console.WriteLine("Idade: " + manutor2.getIdade());

            }
        }
    }
