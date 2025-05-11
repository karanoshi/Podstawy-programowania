using System;

namespace Zadanie10
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

            // W ciągu liczb od 1 do n:
            int dodatnie = n; // Wszystkie liczby są dodatnie
            int ujemne = 0;   // Brak liczb ujemnych
            int zera = 0;     // Brak zer

            Console.WriteLine($"W ciągu liczb od 1 do {n}:");
            Console.WriteLine($"Ilość liczb dodatnich: {dodatnie}");
            Console.WriteLine($"Ilość liczb ujemnych: {ujemne}");
            Console.WriteLine($"Ilość liczb równych zero: {zera}");

            Console.ReadKey();
        }
    }
}