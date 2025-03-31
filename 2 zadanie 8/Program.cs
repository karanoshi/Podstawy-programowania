using System;

namespace Zadanie8
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.WriteLine("Podaj długość pierwszego odcinka:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj długość drugiego odcinka:");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj długość trzeciego odcinka:");
            c = Convert.ToDouble(Console.ReadLine());

            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                Console.WriteLine("Z podanych odcinków można zbudować trójkąt.");
            }
            else
            {
                Console.WriteLine("Z podanych odcinków nie można zbudować trójkąta.");
            }

            Console.ReadKey();
        }
    }
}