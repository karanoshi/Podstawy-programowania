using System;

namespace Zadanie7
{
    class Program
    {
        // Funkcja obliczająca pole deltoidu
        static double poleDeltoidu(double p, double q)
        {
            return (p * q) / 2.0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj długość pierwszej przekątnej deltoidu (p):");
            double przekatna_p = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj długość drugiej przekątnej deltoidu (q):");
            double przekatna_q = Convert.ToDouble(Console.ReadLine());

            double pole = poleDeltoidu(przekatna_p, przekatna_q);
            Console.WriteLine($"Pole deltoidu wynosi: {pole}");

            Console.ReadKey();
        }
    }
}