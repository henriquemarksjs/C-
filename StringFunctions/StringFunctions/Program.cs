using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Funções de uma String:
            string randString = "Isso é uma String!";
            
            Console.WriteLine("Tamanho da String: {0}", randString.Length);

            Console.WriteLine("String contém uma: {0}", randString.Contains("uma"));

            Console.WriteLine("Index de uma: {0}", randString.IndexOf("uma"));

            Console.WriteLine("Removendo String: {0}", randString.Remove(0, 6));

            Console.WriteLine("Adicionando uma String: {0}", randString.Insert(10, " >>> adicionado <<< "));

            Console.WriteLine("Trocando String: {0}", randString.Replace("Isso", "Isto"));

            Console.WriteLine("Para maiúsculo:  {0}", randString.ToUpper());

            Console.WriteLine("Para minúsculo: {0}", randString.ToLower());

            Console.ReadKey();



        }
    }
}
