using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesConvertions
{
    class Program
    {
        static void Main(string[] args)
        {
            bool boolDeString = bool.Parse("true");
            int intDeString = int.Parse("100");
            double doubleDeString = double.Parse("1.2345");

            Console.WriteLine("{0}\n{1}\n{2}", boolDeString, intDeString, doubleDeString);

            Console.ReadKey();
        }
    }
}
