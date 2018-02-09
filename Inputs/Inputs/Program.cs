using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inputs
{
    class Program 
    {
        static void Main(string[] args)
        {
            // Criando Variável:
            string seuNome = "";
            Console.Write("Qual é o seu nome: ");

            // Puxando Input:
            seuNome = Console.ReadLine();
            Console.WriteLine("Olá {0}!", seuNome);

            Console.ReadKey();

        }
        
    }
}
