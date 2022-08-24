using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POrientacao_objetos_vetor
{
    internal class Pessoa
    {
        String nome, data_nascimento;
        double cpf, tel;


        public Pessoa(string nome, string data_nascimento, double cpf, double tel) // método construtor  
        {
            this.nome = nome;
            this.data_nascimento = data_nascimento;
            this.tel = tel;
            this.cpf = cpf;

        }


        public void setNome(String nome) //método público para inserção de valores
        {
            this.nome = nome;   // inserção de idade pelo usuario 
        }
        public void setIdade(String data_nascimento) // método público para inserção de valores 
        {
            this.data_nascimento = data_nascimento; // inserção de data de nascimento pelo usuario 
        }

        public void settel(double tel) // método público para inserção de valores 
        {
            this.tel = tel; // inserção do telefone pelo usuario 
        }

        public void setcpf(double cpf) // método público para inserção de valores 
        {
            this.cpf = cpf; // inserção do cpf pelo usuario 
        }

        public override String ToString() // override - escrever por cima 
        {
            return "\nNome: " + nome + "\nData de Nascimento: " + data_nascimento + "\nTelefone: " + tel + "\nCPF: " + cpf;

        }
    }
}
