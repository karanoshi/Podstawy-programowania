using System;

namespace Zadanie12
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
                Console.WriteLine("Liczba w systemie szesnastkowym: 0");
                Console.ReadKey();
                return;
            }

            string hexadecimal = "";
            int tempN = n;

            while (tempN > 0)
            {
                int remainder = tempN % 16;
                if (remainder < 10)
                {
                    hexadecimal = remainder.ToString() + hexadecimal;
                }
                else
                {
                    hexadecimal = ((char)('A' + remainder - 10)).ToString() + hexadecimal;
                }
                tempN /= 16;
            }

            Console.WriteLine($"Liczba {n} w systemie szesnastkowym: {hexadecimal}");
            Console.ReadKey();
        }
    }
}