using System;

namespace Zadanie12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj wysokość h: ");
            int h = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= h; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0} ", i * j);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}