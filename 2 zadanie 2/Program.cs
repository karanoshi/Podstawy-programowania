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

            if (a > 0)
            {
                Console.WriteLine("Liczba {0} jest dodatnia.", a);
            }
            else if (a < 0)
            {
                Console.WriteLine("Liczba {0} jest ujemna.", a);
            }
            else
            {
                Console.WriteLine("Liczba {0} jest równa zero.", a);
            }
            Console.ReadKey(true); //pauza
        }
    }
}