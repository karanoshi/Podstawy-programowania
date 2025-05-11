using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[1000]; //tablica 1000 liczb typu int
            int i = 0, j, liczba;
            //wczytuję liczbę naturalną
            Console.Write("Podaj liczbę naturalną: ");
            liczba = Convert.ToInt32(Console.ReadLine());

            //zapisuję do tablicy reszty z dzielenia przez 2
            // Pętla while(liczba > 0) jest prostsza i wystarczająca dla liczby naturalnej > 0
            while (liczba > 0)
            {
                tab[i++] = liczba % 2;
                liczba /= 2;
            }


            //wypisuje elementy tablicy w odwrotnej kolejności
            for (j = i - 1; j >= 0; j--) Console.Write(tab[j]);
            Console.ReadKey(true); //pauza
        }
    }
}