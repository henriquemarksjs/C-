using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarando Variáveis:

            char myChar = 'Z';
            int myInt = 10;
            float myFloat = 20.897f;
            double myDouble = 22.987215;
            bool myBoolTrue = true;
            bool myBoolFalse = false;

            // Output na tela:
            Console.WriteLine("Caractere: " + myChar);
            Console.WriteLine("Número Inteiro: " + myInt);
            Console.WriteLine("Número Decimal: " + myFloat);
            Console.WriteLine("Número Double: " + myDouble);
            Console.WriteLine("Booleano Verdadeiro: " + myBoolTrue);
            Console.WriteLine("Booleano Falso: " + myBoolFalse);

            // Esperando o usuário apertar alguma tecla: 
            Console.ReadKey();



        }
    }
}
