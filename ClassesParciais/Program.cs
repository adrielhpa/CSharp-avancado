using System;

namespace ClassesParciais
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new Usuario(123, "Adriel", "010241");
            if(user.Autenticar())
                System.Console.WriteLine("Usuário autenticado com sucesso");
            else
                System.Console.WriteLine("Credenciais inválidas");
            Console.ReadLine();
        }
    }
}
