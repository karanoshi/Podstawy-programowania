using System;

namespace ConsoleApplication1
{
    class Program
    {
        //funkcja wyznacza maksimum z jej argumentów
        static double max(double x, double y)
        {
            if (x > y) return x;
            else return y;
        }

        //testujemy naszą funkcję
        static void Main(string[] args)
        {
            Console.WriteLine($"Max z 3 i 8 to {max(3, 8)}");
            Console.WriteLine($"Max z 8 i 3 to {max(8, 3)}");
            Console.WriteLine($"Max z 3 i 3 to {max(3, 3)}");
            Console.ReadKey(true); //pauza
        }
    }
}