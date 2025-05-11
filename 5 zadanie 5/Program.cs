using System;

namespace Zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę naturalną n > 0:");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Podano nieprawidłową wartość.");
                return;
            }

            long wynik = 1;
            for (int i = 0; i < n; i++)
            {
                wynik *= n;
            }

            Console.WriteLine($"{n}^{n} = {wynik}");
            Console.ReadKey();
        }
    }
}