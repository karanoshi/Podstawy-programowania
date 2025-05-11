using System;

namespace ConsoleApplication1
{
    class Program
    {
        //procedura rysująca kwadrat (procedura funkcja nie zwracająca wartości)
        static void kwadrat(int a, char znak1, char znak2)
        {
            if (a <= 0) return;

            // pierwsza linia kwadratu
            for (int i = 0; i < a; i++) Console.Write(znak1);
            Console.WriteLine(); //wypisuję enter

            // środek kwadratu
            for (int i = 0; i < a - 2; i++) // a-2 środkowych wierszy
            {
                Console.Write(znak1); // początek linii
                for (int j = 0; j < a - 2; j++) Console.Write(znak2); // wypełnienie
                Console.Write(znak1); // koniec linii
                Console.WriteLine(); // wypisuję enter
            }

            // ostatnia linia kwadratu (jeśli a > 1)
            if (a > 1)
            {
                for (int i = 0; i < a; i++) Console.Write(znak1);
                Console.WriteLine();
            }
        }

        //testujemy naszą funkcję
        static void Main(string[] args)
        {
            kwadrat(6, '#', '*');
            Console.ReadKey(true); //pauza
        }
    }
}