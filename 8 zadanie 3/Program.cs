using System;

namespace Zadanie3
{
    class Program
    {
        // Rekurencyjna funkcja f(n)
        static int f(int n)
        {
            if (n < 1)
            {
                return 1;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return 2 * f(n - 1) + 1;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę całkowitą n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int fn = f(n);
            Console.WriteLine($"f({n}) = {fn}");
            Console.WriteLine("\nSprawdzenie wartości obliczonych ręcznie:");
            Console.WriteLine($"f(3) = {f(3)} (Oczekiwano: 7)");
            Console.WriteLine($"f(f(3)) = f(7) = {f(f(3))} (Oczekiwano: 127)");


            Console.ReadKey();
        }
    }
}