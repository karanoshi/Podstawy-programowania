using System;

namespace Zadanie8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę naturalną n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n <= 1)
            {
                Console.WriteLine($"{n} nie jest liczbą pierwszą.");
                Console.ReadKey();
                return;
            }

            int i = 2;
            bool jestPierwsza = true;

            while (i * i <= n)
            {
                if (n % i == 0)
                {
                    jestPierwsza = false;
                    break;
                }
                i++;
            }

            if (jestPierwsza)
            {
                Console.WriteLine($"{n} jest liczbą pierwszą.");
            }
            else
            {
                Console.WriteLine($"{n} nie jest liczbą pierwszą.");
            }

            Console.ReadKey();
        }
    }
}