using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n, k;
            Console.Write("Podaj liczbę naturalną dodatnią n=");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj liczbę naturalną dodatnią k=");
            k = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++) //liczba wierszy
            {
                for (j = 1; j <= k; j++) //liczba kolumn
                    Console.Write("*");
                Console.WriteLine("");//nowa linia
            }
            Console.ReadKey(true); //pauza
        }
    }
}