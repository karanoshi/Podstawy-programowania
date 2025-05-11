using System;

namespace Zadanie8
{
    class Program
    {
        // Funkcja sprawdzająca czy rok jest przestępny
        static int czyPrzestepny(int rok)
        {
            if ((rok % 4 == 0 && rok % 100 != 0) || (rok % 400 == 0))
            {
                return 1; // Rok jest przestępny
            }
            else
            {
                return 0; // Rok nie jest przestępny
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj rok do sprawdzenia:");
            int rok = Convert.ToInt32(Console.ReadLine());

            int wynik = czyPrzestepny(rok);

            if (wynik == 1)
            {
                Console.WriteLine($"Rok {rok} jest przestępny.");
            }
            else
            {
                Console.WriteLine($"Rok {rok} nie jest przestępny.");
            }

            Console.ReadKey();
        }
    }
}