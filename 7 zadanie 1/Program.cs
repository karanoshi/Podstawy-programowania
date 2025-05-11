using System;

namespace ConsoleApplication1
{
    class Program
    {
        //funkcja oblicza sumę jej argumentów
        static int suma(int a, int b)
        {
            return a + b;
        }

        //testujemy naszą funkcję
        static void Main(string[] args)
        {
            Console.WriteLine($"2+5={suma(2, 5)}");
            Console.ReadKey(true); //pauza
        }
    }
}