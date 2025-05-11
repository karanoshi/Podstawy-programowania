using System;

namespace Zadanie9
{
    class Program
    {
        // Funkcja zwracająca ilość rzeczywistych pierwiastków funkcji kwadratowej
        static int iloscPierwiastkowKwadratowych(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;

            if (a == 0) // Funkcja liniowa
            {
                if (b == 0)
                {
                    return 0; // Brak pierwiastków (równanie sprzeczne) lub nieskończenie wiele (tożsamość, ale zazwyczaj liczymy pojedyncze pierwiastki)
                }
                else
                {
                    return 1; // Jeden pierwiastek dla funkcji liniowej
                }
            }
            else // Funkcja kwadratowa
            {
                if (delta > 0)
                {
                    return 2; // Dwa pierwiastki rzeczywiste
                }
                else if (delta == 0)
                {
                    return 1; // Jeden pierwiastek rzeczywisty (podwójny)
                }
                else
                {
                    return 0; // Brak pierwiastków rzeczywistych
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj współczynnik a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj współczynnik b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj współczynnik c:");
            double c = Convert.ToDouble(Console.ReadLine());

            int ilosc = iloscPierwiastkowKwadratowych(a, b, c);
            Console.WriteLine($"Ilość rzeczywistych pierwiastków: {ilosc}");

            Console.ReadKey();
        }
    }
}