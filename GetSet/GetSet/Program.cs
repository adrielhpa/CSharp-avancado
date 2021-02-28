using System;

namespace GetSet
{

    public class Conta
    {
        private string _cliente;
        private double _valor;
        public Conta()
        {

        }
        public string getCliente()
        {
            return this._cliente;
        }
        public void setCliente(string value)
        {
            this._cliente = value;
        }

        public void Sacar(double valor)
        {
            this._valor = this._valor - valor;
        }
        public void Depositar(double valor)
        {
            this._valor = this._valor + valor;
        }
        public double getValor()
        {
            return this._valor;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();
            c.setCliente("Adriel");
            c.Depositar(1000);
            c.Sacar(500);
            Console.WriteLine("Cliente: "+ c.getCliente());
            Console.WriteLine("Saldo na data = "+ c.getValor());
            Console.ReadLine();
        }
    }
}
