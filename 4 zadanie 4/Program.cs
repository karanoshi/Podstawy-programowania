using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k, i, j;
            Console.Write("Podaj n=");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj k = ");
            k = Convert.ToInt32(Console.ReadLine());
            i = 1;
            while (i <= n) //liczba wierszy
            {
                j = 1;
                while (j <= k) //liczba gwiazdek
                {
                    Console.Write("*");
                    j++;
                }//while j
                Console.WriteLine(""); //nowa linia
                i++;
            } //while i
            Console.ReadKey(true); //pauza
        }
    }
}