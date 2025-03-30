using System;

namespace zadanie_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string imie;
            Console.Write("Podaj swoje imię: ");
            imie = Console.ReadLine(); ;
            Console.WriteLine("Witaj {0}!", imie);
            Console.ReadKey(true);
        }
    }
}
