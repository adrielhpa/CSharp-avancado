using System;

namespace Construtores
{

    public class Contato
    {
        public string Tipo;
        public string Descricao;
    }

    public class Cliente
    {
        public int Codigo;
        public string Nome;
        public Contato Contato;

        //padrão
        public Cliente() 
        {
            this.Codigo = 0;
            this.Nome = "sem nome";
            this.Contato = new Contato();
        }

        //overloads
        public Cliente(int codigo) 
        {
            this.Codigo = codigo;
            this.Nome = "sem nome";
            this.Contato = new Contato();
        }
        public Cliente(int codigo, string nome)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Contato = new Contato();
        }

        public override string ToString()
        {
            return "Código: " + Codigo + ", Nome: " + Nome;
        }
    }

    public class ClienteVIP: Cliente
    {
        public int Tempo;
        public ClienteVIP(int codigo, string nome)
            :base(codigo,nome) // chamando o construtor da classe base.
        {
            this.Tempo = 10;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cliente cli1 = new Cliente();
            cli1.Codigo = 123;
            cli1.Nome = "Adriel";
            cli1.Contato.Tipo = "Telefone";
            cli1.Contato.Descricao = "(xx)xxxx-xxxx";

            Cliente cli2 = new Cliente(456);
            cli2.Nome = "Heloísa";
            cli2.Contato.Tipo = "E-mail";
            cli2.Contato.Descricao = "email@exemplo.com.br";

            Cliente cli3 = new Cliente(789, "Andrade");

            Cliente cli4 = new ClienteVIP(123, "Fulano");

            Console.WriteLine(cli1);
            Console.WriteLine(cli2);
            Console.WriteLine(cli3);
            Console.WriteLine(cli4);
            Console.ReadLine();
        }
    }
}
