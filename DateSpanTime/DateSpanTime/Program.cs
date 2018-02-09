using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSpanTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime();
            SpanTime();
        }

        static void SpanTime()
        {
            // Criando um tempo:
            TimeSpan horaDoLanche = new TimeSpan(12, 30, 0);

            // Métodos de Adição e Subtração do tempo (horas, minutos e segundos):
            horaDoLanche = horaDoLanche.Subtract(new TimeSpan(0, 15, 0));
            horaDoLanche = horaDoLanche.Add(new TimeSpan(1, 0, 0));

            // Output da nova hora do lanche:
            Console.WriteLine("Nova Hora do Lanche: {0}", horaDoLanche.ToString());

            Console.ReadKey();
        }

        static void DateTime()
        {
            // Criando uma nova Data:
            DateTime umaData = new DateTime(1999, 02, 08);

            // Output da Data com o dia da semana:
            Console.WriteLine("Dia da Semana: {0}", umaData.DayOfWeek);

            umaData = umaData.AddDays(5); // Adicionando 5 dias à data anterior.
            umaData = umaData.AddMonths(2); // Adicionando 2 meses à data anterior.
            umaData = umaData.AddYears(19); // Adicionando 19 anos à data anterior.

            // Output da nova Data:
            Console.WriteLine("Nova Data: {0}", umaData.Date);

            Console.ReadKey();
        }
    }
}
