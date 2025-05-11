using System;

namespace Zadanie9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę naturalną n (1<=n<=1000): ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 1 || n > 1000)
            {
                Console.WriteLine("Nieprawidłowa wartość n.");
                Console.ReadKey();
                return;
            }

            long sumaKwadratow = 0; // Używamy long, aby uniknąć przepełnienia

            // Obliczamy sumę kwadratów liczb od 1 do n
            for (int i = 1; i <= n; i++)
            {
                sumaKwadratow += (long)i * i;
            }

            Console.WriteLine($"Suma kwadratów liczb od 1 do {n} wynosi: {sumaKwadratow}");
            Console.ReadKey();
        }
    }
}