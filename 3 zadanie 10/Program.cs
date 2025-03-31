using System;

namespace Zadanie10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj ilość liczb do wypisania: ");
            int ile = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < ile; i++)
            {
                Console.Write("{0}, ", i * 7);
            }

            Console.ReadKey();
        }
    }
}