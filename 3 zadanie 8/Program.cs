using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rok1, rok2, i;

            Console.Write("Podaj rok początkowy: ");
            rok1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Podaj rok końcowy: ");
            rok2 = Convert.ToInt32(Console.ReadLine());

            for (i = rok1; i <= rok2; i++)
                if (((i % 4 == 0) && (i % 100 != 0)) || (i % 400 == 0))
                    Console.Write("{0}, ", i);

            Console.ReadKey(true); //pauza
        }
    }
}