using System;
using System.Linq;

namespace Zadanie8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę naturalną n (1<=n<=1000): ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 1 || n > 1000)
            {
                Console.WriteLine("Nieprawidłowa wartość n.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine($"Parzyste liczby z ciągu [1, ..., {n}] w kolejności niemalejącej:");

            // Iterujemy przez liczby od 1 do n i drukujemy parzyste
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i}, ");
                }
            }
            Console.WriteLine(); // Nowa linia na końcu

            Console.ReadKey();
        }
    }
}