using System;

namespace Zadanie15
{
    class Program
    {
        // Procedura rysująca choinkę z gwiazdek
        static void rysujChoinke(int wysokosc)
        {
            if (wysokosc <= 0) return;

            for (int i = 0; i < wysokosc; i++)
            {
                // Rysowanie spacji (wyrównanie)
                for (int j = 0; j < wysokosc - i - 1; j++)
                {
                    Console.Write(" ");
                }

                // Rysowanie gwiazdek
                for (int k = 0; k < 2 * i + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(); // Nowa linia po każdym rzędzie
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wysokość choinki:");
            int wysokosc = Convert.ToInt32(Console.ReadLine());

            rysujChoinke(wysokosc);

            Console.ReadKey();
        }
    }
}