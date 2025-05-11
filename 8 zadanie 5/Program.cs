using System;

namespace Zadanie5
{
    class Program
    {
        // Rekurencyjna funkcja obliczająca NWD algorytmem Euklidesa
        static int NWD_rekurencyjnie(int a, int b)
        {
            // Algorytm Euklidesa działa na liczbach nieujemnych, więc bierzemy wartości bezwzględne.
            a = Math.Abs(a);
            b = Math.Abs(b);

            if (b == 0)
            {
                return a;
            }
            else
            {
                return NWD_rekurencyjnie(b, a % b);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Podaj pierwszą liczbę całkowitą: ");
            int liczba1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Podaj drugą liczbę całkowitą: ");
            int liczba2 = Convert.ToInt32(Console.ReadLine());

            int wynik = NWD_rekurencyjnie(liczba1, liczba2);
            Console.WriteLine($"Największy wspólny dzielnik ({liczba1}, {liczba2}) wynosi: {wynik}");

            Console.ReadKey();
        }
    }
}