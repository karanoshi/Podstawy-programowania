using System;

namespace Zadanie9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę naturalną: ");
            int liczba = Convert.ToInt32(Console.ReadLine());

            int sumaCyfr = 0;
            int tempLiczba = liczba;

            while (tempLiczba > 0)
            {
                sumaCyfr += tempLiczba % 10;
                tempLiczba /= 10;
            }

            Console.WriteLine($"Suma cyfr liczby {liczba} wynosi: {sumaCyfr}");
            Console.ReadKey();
        }
    }
}