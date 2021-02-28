using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueRef2
{
    public class Cliente: Object // Reference type
    {
        public int Codigo;
        public string Nome;
        public string Telefone;
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Codigo: " + Codigo);
            sb.AppendLine("Nome: " + Nome);
            sb.AppendLine("Telefone: " + Telefone);
            return sb.ToString();
        }
    }


    class Program
    {
        public static void MostrarValueTypes()
        {
            int x = 10;
            string s = "Andrade";
            bool b = false;
            Console.WriteLine(x);
            Console.WriteLine(s);
            Console.WriteLine(b);
        }

        static void Main(string[] args)
        {
            
            Cliente c1 = new Cliente();
            c1.Codigo = 123;
            c1.Nome = "Andrade";
            c1.Telefone = "99999999";
            Cliente c2 = new Cliente(); //aponta para a mesma posição de memória que o c1. NÃO É CÓPIA ! É APONTAMENTO DE MEMÓRIA.
            c2.Nome = "Rudolfo";
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            if (c1.Equals(c2))
                Console.WriteLine("c1 e c2 são os mesmos objetos");
            else
                Console.WriteLine("c1 e c2 são objetos diferentes");
            //Console.WriteLine(c1.Codigo);
            //Console.WriteLine(c1.Nome);
            //Console.WriteLine(c1.Telefone);

            Console.ReadLine();
        }
    }
}
