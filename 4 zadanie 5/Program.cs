using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            do
            {
                Console.Write("Podaj x=");
                x = Convert.ToDouble(Console.ReadLine());
            } while (x <= 0);
            Console.WriteLine("Wczytano liczbę x={0}", x);
            Console.ReadKey(true); //pauza
        }
    }
}