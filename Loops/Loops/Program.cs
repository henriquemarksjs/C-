using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chamando as funções no método principal:
            forloop();
            whileloop();
            foreachloop();
        }

        static void forloop()
        {
            // For Loop:
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Looping: " + i);
            }
            Console.ReadKey();
        }

        static void whileloop()
        {
            // While Loop:
            int g = 0;
            while (g < 30)
            {
                g++;
                Console.WriteLine("Looping: " + g);
            }
            Console.ReadKey();
        }
        
        static void foreachloop()
        {
            // Array:
            int[] myArrayOfNumbers = new int[] { 0, 1, 2, 3, 4, 5, 6 };
            // ForEach In Loop:
            foreach (int element in myArrayOfNumbers)
            {
                Console.WriteLine(element);
            }
            Console.ReadKey();

        }
    }
}
