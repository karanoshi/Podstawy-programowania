using System;

namespace Zadanie7
{
    class Program
    {
        static bool CzyPierwsza(int liczba)
        {
            if (liczba <= 1) return false;
            if (liczba <= 3) return true;
            if (liczba % 2 == 0 || liczba % 3 == 0) return false;
            for (int i = 5; i * i <= liczba; i = i + 6)
                if (liczba % i == 0 || liczba % (i + 2) == 0)
                    return false;
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę naturalną n > 1:");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n <= 1)
            {
                Console.WriteLine("Podano nieprawidłową wartość.");
                return;
            }

            Console.WriteLine($"Liczby pierwsze z przedziału [1, {n}]:");
            for (int i = 1; i <= n; i++)
            {
                if (CzyPierwsza(i))
                {
                    Console.Write($"{i}, ");
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}