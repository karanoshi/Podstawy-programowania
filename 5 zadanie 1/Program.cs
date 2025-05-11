using System;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj współrzędną x punktu P:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj współrzędną y punktu P:");
            double y = Convert.ToDouble(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Punkt P leży w I ćwiartce.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Punkt P leży w II ćwiartce.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Punkt P leży w III ćwiartce.");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Punkt P leży w IV ćwiartce.");
            }
            else if (x == 0 && y != 0)
            {
                Console.WriteLine("Punkt P leży na osi OY.");
            }
            else if (x != 0 && y == 0)
            {
                Console.WriteLine("Punkt P leży na osi OX.");
            }
            else
            {
                Console.WriteLine("Punkt P leży w początku układu współrzędnych (0,0).");
            }

            Console.ReadKey();
        }
    }
}