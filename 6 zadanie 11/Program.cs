using System;

namespace Zadanie11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę naturalną: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("Podano nieprawidłową wartość (liczba naturalna).");
                Console.ReadKey();
                return;
            }

            if (n == 0)
            {
                Console.WriteLine("Liczba w systemie ósemkowym: 0");
                Console.ReadKey();
                return;
            }

            string octal = "";
            int tempN = n;

            while (tempN > 0)
            {
                octal = (tempN % 8).ToString() + octal;
                tempN /= 8;
            }

            Console.WriteLine($"Liczba {n} w systemie ósemkowym: {octal}");
            Console.ReadKey();
        }
    }
}