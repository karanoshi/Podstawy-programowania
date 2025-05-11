using System;

namespace Zadanie14
{
    class Program
    {
        // Funkcja obliczająca integer square root (pomocnicza)
        static int IntSqrt(int n)
        {
            if (n < 0) return -1; // Nie ma rzeczywistego pierwiastka
            if (n == 0) return 0;

            int i = 1;
            while (i * i <= n)
            {
                if (i * i == n) return i;
                i++;
            }
            return -1; // Nie jest idealnym kwadratem
        }

        // Funkcja sprawdzająca, czy liczba kończy się swoim pierwiastkiem
        static int czyKonczySiePierwiastkiem(int liczba)
        {
            if (liczba < 0) return 0;
            if (liczba == 0) return 1; // 0 kończy się 0

            int pierwiastek = IntSqrt(liczba);

            if (pierwiastek == -1) return 0; // Nie jest idealnym kwadratem

            // Sprawdzenie, czy liczba kończy się pierwiastkiem
            string liczbaStr = liczba.ToString();
            string pierwiastekStr = pierwiastek.ToString();

            if (liczbaStr.EndsWith(pierwiastekStr))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę całkowitą do sprawdzenia:");
            int liczba = Convert.ToInt32(Console.ReadLine());

            int wynik = czyKonczySiePierwiastkiem(liczba);

            if (wynik == 1)
            {
                Console.WriteLine($"Liczba {liczba} kończy się swoim pierwiastkiem.");
            }
            else
            {
                Console.WriteLine($"Liczba {liczba} nie kończy się swoim pierwiastkiem lub nie jest idealnym kwadratem.");
            }

            Console.ReadKey();
        }
    }
}