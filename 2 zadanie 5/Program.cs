using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rok;

            Console.Write("Podaj rok: ");
            rok = Convert.ToInt32(Console.ReadLine());

            if (((rok % 4 == 0) && (rok % 100 != 0)) || (rok % 400 == 0))
            {
                Console.WriteLine("Rok {0} jest przestępny.", rok);
            }
            else
            {
                Console.WriteLine("Rok {0} nie jest przestępny.", rok);
            }
            Console.ReadKey(true); //pauza
        }
    }
}