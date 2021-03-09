using System;
using System.Data;

namespace ClassesExtensao
{
    public static class MyExtensions
    {
        public static void WriteJSON(this DataSet ds, string filaName)
        {
            //...
        }

        public static string ToUrl(this string str)
        {
            return str = "http://" + str;
        }
    }    

    class Program
    {        
        static void Main(string[] args)
        {
            // var ds = new DataSet();
            // ds.WriteJSON("dados.js");
            
            // ds.WriteXml("dados.xml");

            string url = "www.linkedin.com/in/adriel-andrade-78024a163/";
            System.Console.WriteLine(url.ToUrl());
            Console.ReadLine();

            
        }
    }
}
