using System;

namespace POrientacao_objetos_vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nome;
            int data_nascimento;
            double cpf, tel;

            Pessoa[] pessoa = new Pessoa[3];
            //

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("\nDigite seu Nome: ");
                nome = Console.ReadLine();

                Console.WriteLine("\nDigite a data de nascimento: ");
                data_nascimento = int.Parse(Console.ReadLine());

                Console.WriteLine("\nDigite seu CPF: ");
                cpf = double.Parse(Console.ReadLine());

                Console.WriteLine("\nDigite seu Telefone: ");
                tel = double.Parse(Console.ReadLine());

                pessoa[i] = new Pessoa(nome, data_nascimento, cpf, tel);
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(pessoa[i].ToString());

            }


        }
    }
}
