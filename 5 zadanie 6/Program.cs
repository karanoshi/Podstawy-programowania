using System;

namespace Zadanie6
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

            long suma = 0;
            for (int i = 1; i <= n; i++)
            {
                long potega = 1;
                for (int j = 0; j < i; j++)
                {
                    potega *= i;
                }
                suma += potega;
            }

            Console.WriteLine($"Suma szeregu wynosi: {suma}");
            Console.ReadKey();
        }
    }
}