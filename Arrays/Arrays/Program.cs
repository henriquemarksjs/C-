using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays:

            // Criando uma Array:
            int[] scores = new int[] { 97, 96, 95, 94, 90, 70, 60, 50 };

            // Definindo a Query:
            IEnumerable<int> scoreQuery =
            from score in scores
            where score >= 90
            select score;

            // ForEach Loop:
            foreach(int i in scoreQuery)
            {
                Console.WriteLine("Pontuações: " + i);
            }
            Console.ReadKey();
        }
    }
}
