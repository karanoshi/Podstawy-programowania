using System;

namespace ConsoleApplication1
{
    class Program
    {
        //funkcja oblicza ilość cyfr jej argumentu
        static int ile_cyfr(int liczba)
        {
            if (liczba == 0) return 1; // Liczba 0 ma jedną cyfrę
            int i = 0; //ilość cyfr
            int tempLiczba = Math.Abs(liczba); // Liczymy cyfry dla wartości bezwzględnej

            while (tempLiczba > 0)
            {
                tempLiczba /= 10;
                i++;
            }
            return i;
        }

        //testujemy naszą funkcję
        static void Main(string[] args)
        {
            Console.WriteLine($"Liczba 0 ma {ile_cyfr(0)} cyfrę");
            Console.WriteLine($"Liczba 1234 ma {ile_cyfr(1234)} cyfry");
            Console.WriteLine($"Liczba -567 ma {ile_cyfr(-567)} cyfry");
            Console.ReadKey(true); //pauza
        }
    }
}