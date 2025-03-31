using System;
using System.Collections.Generic;

namespace Zadanie10
{
    class Program
    {
        private static readonly Dictionary<int, string> jednostki = new Dictionary<int, string>()
        {
            { 1, "jeden" }, { 2, "dwa" }, { 3, "trzy" }, { 4, "cztery" }, { 5, "pięć" },
            { 6, "sześć" }, { 7, "siedem" }, { 8, "osiem" }, { 9, "dziewięć" }
        };

        private static readonly Dictionary<int, string> nastki = new Dictionary<int, string>()
        {
            { 10, "dziesięć" }, { 11, "jedenaście" }, { 12, "dwanaście" }, { 13, "trzynaście" },
            { 14, "czternaście" }, { 15, "piętnaście" }, { 16, "szesnaście" }, { 17, "siedemnaście" },
            { 18, "osiemnaście" }, { 19, "dziewiętnaście" }
        };

        private static readonly Dictionary<int, string> dziesiatki = new Dictionary<int, string>()
        {
            { 20, "dwadzieścia" }, { 30, "trzydzieści" }, { 40, "czterdzieści" }, { 50, "pięćdziesiąt" },
            { 60, "sześćdziesiąt" }, { 70, "siedemdziesiąt" }, { 80, "osiemdziesiąt" }, { 90, "dziewięćdziesiąt" }
        };

        private static readonly Dictionary<int, string> setki = new Dictionary<int, string>()
        {
            { 100, "sto" }, { 200, "dwieście" }, { 300, "trzysta" }, { 400, "czterysta" },
            { 500, "pięćset" }, { 600, "sześćset" }, { 700, "siedemset" }, { 800, "osiemset" },
            { 900, "dziewięćset" }
        };

        private static string LiczbaNaSlowa(int liczba)
        {
            if (liczba == 0) return "zero";
            if (jednostki.ContainsKey(liczba)) return jednostki[liczba];
            if (nastki.ContainsKey(liczba)) return nastki[liczba];
            if (dziesiatki.ContainsKey(liczba)) return dziesiatki[liczba];
            if (setki.ContainsKey(liczba)) return setki[liczba];

            if (liczba < 100)
            {
                int dz = liczba / 10 * 10;
                int j = liczba % 10;
                return dziesiatki[dz] + (j > 0 ? " " + jednostki[j] : "");
            }

            if (liczba < 1000)
            {
                int s = liczba / 100 * 100;
                int reszta = liczba % 100;
                return setki[s] + (reszta > 0 ? " " + LiczbaNaSlowa(reszta) : "");
            }

            if (liczba < 1000000)
            {
                int tysiace = liczba / 1000;
                int reszta = liczba % 1000;
                string slowoTysiace = "";

                if (tysiace == 1)
                {
                    slowoTysiace = "tysiąc";
                }
                else if (tysiace > 1 && tysiace < 5)
                {
                    slowoTysiace = LiczbaNaSlowa(tysiace) + " tysiące";
                }
                else
                {
                    slowoTysiace = LiczbaNaSlowa(tysiace) + " tysięcy";
                }

                return slowoTysiace + (reszta > 0 ? " " + LiczbaNaSlowa(reszta) : "");
            }

            return "Liczba poza zakresem";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę arabską od 1 do 1 000 000:");
            if (int.TryParse(Console.ReadLine(), out int liczba))
            {
                if (liczba >= 1 && liczba <= 1000000)
                {
                    Console.WriteLine($"Słownie: {LiczbaNaSlowa(liczba)}");
                }
                else
                {
                    Console.WriteLine("Podana liczba jest poza zakresem.");
                }
            }
            else
            {
                Console.WriteLine("Nieprawidłowe dane wejściowe.");
            }

            Console.ReadKey();
        }
    }
}