using System;

namespace POrientacao_objetos_vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nome, data_nascimento; 
            double cpf, tel;

            Pessoa[] pessoa = new Pessoa[3]; // vetor para objetos "Pessoas"
            

            for (int i = 0; i < 3; i++) // laço para leitura de valores e alimentação do vetor 
            {
                Console.Write("\nDigite o "+ (i+1) + "º Nome: ");
                nome = Console.ReadLine();

                Console.Write("\nDigite a " +(i +1) + "º data de  nascimento: ");
                data_nascimento = Console.ReadLine();

                Console.Write("\nDigite o " + (i + 1) + "º CPF: ");
                cpf = double.Parse(Console.ReadLine());

                Console.Write("\nDigite o " + (i + 1) + "º Telefone: ");
                tel = double.Parse(Console.ReadLine());

                pessoa[i] = new Pessoa(nome, data_nascimento, cpf, tel);

                Console.Clear();
            }

            for (int i = 0; i < 3; i++) // laço para exibição 
            {
                Console.WriteLine("\n");
                Console.WriteLine("\nDados da " + (i + 1) + "º Pessoa: ");
                Console.Write(pessoa[i].ToString());

                Console.WriteLine("Tecle ENTER para SAIR");
                Console.ReadKey();

            }


        }
    }
}
