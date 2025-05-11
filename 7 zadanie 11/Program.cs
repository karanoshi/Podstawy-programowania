using System;

namespace Zadanie11
{
    class Program
    {
        // Funkcja obliczająca Największy Wspólny Dzielnik (potrzebna do NWW)
        static int NWD(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Funkcja obliczająca Najmniejszą Wspólną Wielokrotność
        static int NWW(int a, int b)
        {
            if (a == 0 || b == 0) return 0;
            return Math.Abs(a * b) / NWD(a, b);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę naturalną:");
            int liczba1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbę naturalną:");
            int liczba2 = Convert.ToInt32(Console.ReadLine());

            int wynik = NWW(liczba1, liczba2);
            Console.WriteLine($"Najmniejsza wspólna wielokrotność ({liczba1}, {liczba2}) wynosi: {wynik}");

            Console.ReadKey();
        }
    }
}