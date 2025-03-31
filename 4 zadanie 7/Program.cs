using System;

namespace Zadanie7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę naturalną n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            long silnia = 1;
            int i = 1;

            while (i <= n)
            {
                silnia *= i;
                i++;
            }

            Console.WriteLine($"{n}! = {silnia}");
            Console.ReadKey();
        }
    }
}