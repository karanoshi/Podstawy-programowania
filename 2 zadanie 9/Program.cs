using System;

namespace Zadanie9
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x1, x2;

            Console.WriteLine("Podaj współczynnik a:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj współczynnik b:");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj współczynnik c:");
            c = Convert.ToDouble(Console.ReadLine());

            delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Miejsca zerowe to: x1 = {x1}, x2 = {x2}");
            }
            else if (delta == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine($"Jedno miejsce zerowe: x = {x1}");
            }
            else
            {
                Console.WriteLine("Funkcja nie ma rzeczywistych miejsc zerowych.");
            }

            Console.ReadKey();
        }
    }
}