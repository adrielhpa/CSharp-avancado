using System;

namespace Propriedades
{
    class Program
    {
        public class MensalidadeNegativaException: Exception
        {
            public MensalidadeNegativaException (string message):
                base(message)
            {

            }
        }

        public enum TipoAluno
        {
            Regular, Especial
        }
        public class Aluno
        {
            private string _nome;
            private double _mensalidade;
            private TipoAluno _tipo;
            private int _matricula;
            public int Matricula
            {
                get { return this._matricula; }
                set { this._matricula = value; }
            }

            public string Nome { get => _nome; set => _nome = value; }
            public double Mensalidade
            {
                get { return _mensalidade; }
                set
                {
                    if (value < 0)
                        throw new MensalidadeNegativaException("Valor da mesalidade não pode ser negativo");
                    else
                        _mensalidade = value;
                }
            }
            internal TipoAluno Tipo { get => _tipo; set => _tipo = value; }            
        }

        static void Main(string[] args)
        {
            try
            {
                Aluno a = new Aluno();
                a.Matricula = 123;
                a.Nome = "Fulano";
                a.Mensalidade = -100;
                a.Tipo = TipoAluno.Regular;
            }
            catch (MensalidadeNegativaException E)
            {
                Console.WriteLine(E.Message);
            }
            catch(Exception E)
            {
                Console.WriteLine(E.Message);
            }
            Console.ReadLine();
        }
    }
}
