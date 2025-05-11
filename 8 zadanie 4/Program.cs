using System;

namespace Zadanie4
{
    class Program
    {
        // Rekurencyjna funkcja obliczająca n-ty wyraz ciągu
        static long a(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else if (n > 1)
            {
                long poprzedni_wyraz = a(n - 1);
                return poprzedni_wyraz * poprzedni_wyraz - 3;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(n), "Argument n musi być większy lub równy 1.");
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę całkowitą n (>= 1): ");
            int n = Convert.ToInt32(Console.ReadLine());

            try
            {
                long an = a(n);
                Console.WriteLine($"a({n}) = {an}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Błąd: {ex.Message}");
            }


            Console.ReadKey();
        }
    }
}