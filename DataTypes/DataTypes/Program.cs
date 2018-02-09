using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output de valores Máximos e Mínimos de um Data Type:

            Console.WriteLine("Maior Número Inteiro: {0}", int.MaxValue);
            Console.WriteLine("Menor Número Inteiro: {0}", int.MinValue);
            Console.WriteLine("Maior Número Float: {0}", float.MaxValue);
            Console.WriteLine("Menor Número Float: {0}", float.MinValue);
            Console.WriteLine("Maior Número Long: {0}", long.MaxValue);
            Console.WriteLine("Menor Número Long: {0}", long.MinValue);
    
            // Outros Data Types:
            /* 
             byte: 8-bit unsigned int: 0 até 255
             char: 16-bit unicode caractere
             sbyte: 8-bit signed int 128 até 127
             short: 16-bit signed int -32,768 até 32,767
             uint: 32-bit unsigned int 0 até 4,294,967,295
             ulong: 64-bit unsigned int 0 até 18,466,744,073,709,551,615
             ushort: 16-bit unsigned int 0 até 65,355
             */
            Console.ReadKey();
        }
    }
}
