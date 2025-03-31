using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.Write("Podaj liczbę całkowitą: ");
            a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("Liczba {0} jest parzysta.", a);
            }
            else
            {
                Console.WriteLine("Liczba {0} jest nieparzysta.", a);
            }
            Console.ReadKey(true); //pauza
        }
    }
}