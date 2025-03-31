using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, wynik = 1, n;
            Console.Write("Podaj liczbę naturalną n = ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
                wynik *= 2;

            Console.WriteLine("2^{0}={1}", n, wynik);
            Console.ReadKey(true); //pauza
        }
    }
}