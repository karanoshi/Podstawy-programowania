using System;

namespace Zadanie10
{
    class Program
    {
        // Funkcja obliczająca Największy Wspólny Dzielnik (algorytm Euklidesa)
        static int NWD(int a, int b)
        {
            a = Math.Abs(a); // NWD jest zdefiniowane dla liczb naturalnych, ale algorytm działa też na nieujemnych
            b = Math.Abs(b);

            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę naturalną:");
            int liczba1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbę naturalną:");
            int liczba2 = Convert.ToInt32(Console.ReadLine());

            int wynik = NWD(liczba1, liczba2);
            Console.WriteLine($"Największy wspólny dzielnik ({liczba1}, {liczba2}) wynosi: {wynik}");

            Console.ReadKey();
        }
    }
}