using System;

namespace Zadanie13
{
    class Program
    {
        // Funkcja sprawdzająca czy liczba jest kwadratem liczby całkowitej bez użycia Math.Sqrt()
        static int czy_kw(int liczba)
        {
            if (liczba < 0) return 0;
            if (liczba == 0) return 1; // 0*0 = 0

            long i = 1; // Używamy long na wypadek dużych liczb wejściowych
            while (i * i <= liczba)
            {
                if (i * i == liczba)
                {
                    return 1; // Jest kwadratem
                }
                i++;
            }

            return 0; // Nie jest kwadratem
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę całkowitą do sprawdzenia:");
            int liczba = Convert.ToInt32(Console.ReadLine());

            int wynik = czy_kw(liczba);

            if (wynik == 1)
            {
                Console.WriteLine($"Liczba {liczba} jest kwadratem liczby całkowitej.");
            }
            else
            {
                Console.WriteLine($"Liczba {liczba} nie jest kwadratem liczby całkowitej.");
            }

            Console.ReadKey();
        }
    }
}