using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueRef
{
    public class PosicaoClass //reference type
    {
        public int x;
        public int y;
    }

    class Program
    {
        public static void Dobrar(ref int valor) // o ref trata um ValueType como um RefType. 
        {
            valor = valor * 2;
        }

        public static void Dobrar(PosicaoClass valor)
        {
            valor.x = valor.x * 2;
            valor.y = valor.y * 2;
        }

        static void Main(string[] args)
        {
            PosicaoClass pos1 = new PosicaoClass();
            pos1.x = 10;
            pos1.y = 20;
            PosicaoClass pos2 = new PosicaoClass();
            pos2.x = 30;
            pos2.y = 40;
            Dobrar(pos1);
            Dobrar(pos2);
            Console.WriteLine(pos1.x);
            Console.WriteLine(pos1.y);
            Console.WriteLine(pos2.x);
            Console.WriteLine(pos2.y);

            Console.ReadLine();
        }

        private static void DobrarValue()
        {
            int x = 10;
            Dobrar(ref x);
            Console.WriteLine(x);
        }

        private static void RefTypeInt()
        {
            PosicaoClass pos1 = new PosicaoClass();
            pos1.x = 10;
            pos1.y = 20;
            PosicaoClass pos2 = new PosicaoClass();
            pos2.x = 30;
            pos2.y = 40;
            pos2 = pos1; // apontando ambos para a mesma posiçao de memória
            pos2.x = 50;

            Console.WriteLine(pos1.x);
            Console.WriteLine(pos1.y);
            Console.WriteLine(pos2.x);
            Console.WriteLine(pos2.y);
        }

        private static void ValueTypeInt()
        {
            int x = 10;
            int y = 20;
            y = x; // deep copy 
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}
