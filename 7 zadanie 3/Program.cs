using System;

namespace ConsoleApplication1
{
    class Program
    {
        //funkcja oblicza pole koła dla zadanego argumentu
        static double pole_kola(double r)
        {
            return Math.PI * r * r;
        }

        //testujemy naszą funkcję
        static void Main(string[] args)
        {
            Console.WriteLine($"Dla r=1.5 Pole = {pole_kola(1.5)}");
            Console.ReadKey(true); //pauza
        }
    }
}