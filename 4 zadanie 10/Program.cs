using System;

namespace Zadanie10
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int liczba;

            do
            {
                Console.Write("Podaj liczbę całkowitą (0 kończy): ");
                liczba = Convert.ToInt32(Console.ReadLine());
                suma += liczba;
            } while (liczba != 0);

            Console.WriteLine($"Suma podanych liczb wynosi: {suma}");
            Console.ReadKey();
        }
    }
}