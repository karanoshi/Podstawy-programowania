using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.Write("Podaj liczbę nr 1: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbę nr 2: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbę nr 3: ");
            c = Convert.ToDouble(Console.ReadLine());
            //szukamy liczby najmniejszej
            if ((a <= b) && (a <= c))
                Console.WriteLine("Liczba {0} jest najmniejsza.", a);
            else if ((b <= a) && (b <= c))
                Console.WriteLine("Liczba {0} jest najmniejsza.", b);
            else
                Console.WriteLine("Liczba {0} jest najmniejsza.", c);
            //szukamy liczby największej
            if ((a >= b) && (a >= c))
                Console.WriteLine("Liczba {0} jest największa.", a);
            else if ((b >= a) && (b >= c))
                Console.WriteLine("Liczba {0} jest największa.", b);
            else
                Console.WriteLine("Liczba {0} jest największa.", c);
            Console.ReadKey(true); //pauza
        }
    }
}