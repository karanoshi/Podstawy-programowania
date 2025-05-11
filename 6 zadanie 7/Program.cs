using System;
using System.Linq;

namespace Zadanie7
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

            // Generujemy ciąg liczb od 1 do n
            int[] ciag = Enumerable.Range(1, n).ToArray();

            // Najmniejsza liczba w ciągu [1, ..., n] to 1 (dla n>=1)
            int min = 1;
            // Największa liczba w ciągu [1, ..., n] to n
            int max = n;

            Console.WriteLine($"Najmniejsza liczba w ciągu [1, ..., {n}] to: {min}");
            Console.WriteLine($"Największa liczba w ciągu [1, ..., {n}] to: {max}");

            Console.ReadKey();
        }
    }
}