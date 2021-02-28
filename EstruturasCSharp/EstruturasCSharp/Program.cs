using System;

namespace EstruturasCSharp
{
    public class PosicaoClass
    {
        public int x;
        public int y;
        public override string ToString()
        {
            return "X = " + x.ToString() + ", Y = " + y.ToString();
        }
    }

    public struct PosicaoStruct //STRUCTS SÃO VALUE TYPES
    {
        public int x;
        public int y;
        public override string ToString()
        {
            return "X = " + x.ToString() + ", Y = " + y.ToString();
        }
    }
    
    public enum Role
    {
        Arquiteto, Developer, Tester
    }

    public enum Color
    {
        Red = 0, Green = 1, Blue = 2
    }

    public enum FormasPgto
    {
        Boleto, Cartao, Cheque
    }

    class Program
    {
        static void Main(string[] args)
        {
            PosicaoClass pos1 = new PosicaoClass();
            pos1.x = 10;
            pos1.y = 20;

            PosicaoStruct pos2 = new PosicaoStruct();
            pos2.x = 30;
            pos2.y = 40;

            PosicaoStruct pos3 = pos2; //value types, so, it's a copy.
            pos3.y = 50;               //so this change has not changed the pos2.y

            FormasPgto formaPgto = FormasPgto.Boleto;
            Role role = Role.Arquiteto;
            Color cor = Color.Blue;



            Console.WriteLine(formaPgto);
            Console.WriteLine(role);
            Console.WriteLine(cor);
            Console.WriteLine(pos1);
            Console.WriteLine(pos2);
            Console.WriteLine(pos3);
            Console.ReadLine();
        }
    }
}
