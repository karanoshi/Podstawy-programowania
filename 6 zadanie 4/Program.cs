using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[1000]; //tablica 1000 liczb typu int
            int i; //i licznik pętli,
            int n, suma; //n-ilość elementów tablicy, suma-suma elem tab
            //wczytuję n
            Console.Write("Podaj ilość elementów tablicy n<=1000: ");
            n = Convert.ToInt32(Console.ReadLine());
            //wczytuję n elementów do tablicy
            for (i = 0; i < n; i++)
            {
                Console.Write("Podaj tab [{0}]=", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            //obliczamy sumę wczytanych elementów
            suma = 0;
            for (i = 0; i < n; i++) suma += tab[i];
            //wypisujemy wynik
            Console.WriteLine("Suma elementów tablicy wynosi {0}.", suma);
            Console.ReadKey(true); //pauza
        }
    }
}