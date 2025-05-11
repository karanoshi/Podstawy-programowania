using System;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj współrzędną x punktu A:");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj współrzędną y punktu A:");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj współrzędną x punktu B:");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj współrzędną y punktu B:");
            double y2 = Convert.ToDouble(Console.ReadLine());

            if (x1 == x2)
            {
                Console.WriteLine($"Prosta ma równanie x = {x1}");
            }
            else
            {
                double a = (y2 - y1) / (x2 - x1);
                double b = y1 - a * x1;
                Console.WriteLine($"Równanie prostej przechodzącej przez punkty A i B to: y = {a}x + {b}");
            }

            Console.ReadKey();
        }
    }
}