using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeInference_Dynamic
{
    public class Connection
    {
        public string ConnectionString;
        public void Conectar()
        {
            Console.WriteLine("Conectando...");
        }
        public void Fechar()
        {
            Console.WriteLine("Fechando...");
        }
    }

    public static class Fabrica
    {
        public static Connection CriarConnection()
        {
            return new Connection();
        }
    }
    class Program
    {


        static void Main(string[] args)
        {
            var str = "TESTE";
            var x = 10;
            dynamic v = "TESTE";
            var con = Fabrica.CriarConnection();
            con.ConnectionString = "BANCO";
            con.Conectar();
            con.Fechar();

            Console.ReadLine();
        }
    }
}
