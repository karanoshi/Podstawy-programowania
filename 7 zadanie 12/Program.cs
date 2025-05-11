using System;

namespace Zadanie12
{
    class Program
    {
        // Funkcja konwertująca liczbę dziesiętną na ósemkową (jako int)
        // Uwaga: Ta funkcja zadziała tylko dla liczb, których reprezentacja ósemkowa mieści się w int.
        // Dla większych liczb należałoby zwrócić string.
        static int DziesietnaNaOsemkowa(int liczbaDziesietna)
        {
            if (liczbaDziesietna == 0) return 0;

            int liczbaOsemkowa = 0;
            int potega = 1; // potęga liczby 10, służąca do budowania liczby ósemkowej

            while (liczbaDziesietna > 0)
            {
                int reszta = liczbaDziesietna % 8;
                liczbaOsemkowa += reszta * potega;
                liczbaDziesietna /= 8;
                potega *= 10;
            }

            return liczbaOsemkowa;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę naturalną w systemie dziesiętnym:");
            int liczbaDziesietna = Convert.ToInt32(Console.ReadLine());

            if (liczbaDziesietna < 0)
            {
                Console.WriteLine("Podano nieprawidłową wartość (oczekiwana liczba naturalna).");
            }
            else
            {
                int liczbaOsemkowa = DziesietnaNaOsemkowa(liczbaDziesietna);
                Console.WriteLine($"Liczba {liczbaDziesietna} w systemie ósemkowym (jako int) to: {liczbaOsemkowa}");
            }

            Console.ReadKey();
        }
    }
}