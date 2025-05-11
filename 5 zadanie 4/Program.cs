using System;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj kwotę w złotych:");
            double pln = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wybierz walutę, na którą chcesz przeliczyć:");
            Console.WriteLine("1 - Funty (GBP)");
            Console.WriteLine("2 - Dolary (USD)");
            Console.WriteLine("3 - Euro (EUR)");
            Console.Write("Twój wybór: ");
            int wybor = Convert.ToInt32(Console.ReadLine());

            double przeliczonaKwota;
            double kursGBP = 5.0; // Przykładowy kurs
            double kursUSD = 4.0; // Przykładowy kurs
            double kursEUR = 4.5; // Przykładowy kurs

            switch (wybor)
            {
                case 1:
                    przeliczonaKwota = pln / kursGBP;
                    Console.WriteLine($"{pln} PLN to {przeliczonaKwota:F2} GBP.");
                    break;
                case 2:
                    przeliczonaKwota = pln / kursUSD;
                    Console.WriteLine($"{pln} PLN to {przeliczonaKwota:F2} USD.");
                    break;
                case 3:
                    przeliczonaKwota = pln / kursEUR;
                    Console.WriteLine($"{pln} PLN to {przeliczonaKwota:F2} EUR.");
                    break;
                default:
                    Console.WriteLine("Nieprawidłowy wybór waluty.");
                    break;
            }

            Console.ReadKey();
        }
    }
}