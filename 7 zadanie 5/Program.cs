using System;

namespace ConsoleApplication1
{
    class Program
    {
        //funkcja sprawdza, czy jej argument jest liczbą pierwszą
        // Jako wartość funkcja powinna zwracać 1 dla liczb pierwszych i 0 dla pozostałych liczb.
        static int czy_pierwsza(int liczba)
        {
            if (liczba <= 1) return 0; //liczba nie jest pierwsza
            if (liczba <= 3) return 1; //liczba jest pierwsza
            if (liczba % 2 == 0 || liczba % 3 == 0) return 0; //liczba nie jest pierwsza

            for (int i = 5; i * i <= liczba; i = i + 6)
            {
                if (liczba % i == 0 || liczba % (i + 2) == 0)
                    return 0; //liczba nie jest pierwsza
            }
            return 1; //liczba musi być pierwsza
        }

        //testujemy naszą funkcję
        static void Main(string[] args)
        {
            Console.WriteLine($"Czy 12 jest l. pierwszą: {czy_pierwsza(12)}");
            Console.WriteLine($"Czy 13 jest l. pierwszą: {czy_pierwsza(13)}");
            Console.WriteLine($"Czy 1 jest l. pierwszą: {czy_pierwsza(1)}");
            Console.WriteLine($"Czy 2 jest l. pierwszą: {czy_pierwsza(2)}");
            Console.WriteLine($"Czy 4 jest l. pierwszą: {czy_pierwsza(4)}");
            Console.ReadKey(true); //pauza
        }
    }
}