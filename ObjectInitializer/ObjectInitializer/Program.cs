using System;
using System.Collections.Generic;

namespace ObjectInitializer
{
    public class Filme
    {
        public string Nome;
        public int Ano;
    }
    public class Ator
    {
        public int Codigo;
        public string Nome;
        public List<Filme> Filmes;
        //public Ator(int codigo, string nome, string filme)
        //{
        //    this.Codigo = codigo;
        //    this.Nome = nome;
        //    this.Filme = filme;
        //}
        //public Ator(string nome)
        //{
        //    this.Nome = nome; 
        //}
        //public Ator(int codigo)
        //{
        //    this.Codigo = codigo;
        //}
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Ator a = new Ator() {
                Codigo = 10,
                Nome = "Michael",
                Filmes = new List<Filme>()
                {
                    new Filme() {Nome = "Prision Break", Ano = 2006},
                    new Filme() {Nome = "Programa", Ano = 2013}
                }
            };

        }
    }
}
