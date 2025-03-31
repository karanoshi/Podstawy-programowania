using System;

namespace Zadanie11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int suma = 0;

            for (int i = 0; i < n; i++)
            {
                suma += (2 * i + 1);
            }

            Console.WriteLine($"Suma {n} początkowych liczb nieparzystych wynosi: {suma}");
            Console.ReadKey();
        }
    }
}