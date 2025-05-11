using System;

namespace Zadanie3
{
    class Program
    {
        static double PoleTrojkata(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            return Math.Abs((x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2.0);
        }

        static void Main(string[] args)
        {
            double ax = -4, ay = -4;
            double bx = 4, by = -2;
            double cx = 6, cy = 6;

            Console.WriteLine("Podaj współrzędną x punktu P:");
            double px = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj współrzędną y punktu P:");
            double py = Convert.ToDouble(Console.ReadLine());

            double poleABC = PoleTrojkata(ax, ay, bx, by, cx, cy);
            double polePAB = PoleTrojkata(px, py, ax, ay, bx, by);
            double polePBC = PoleTrojkata(px, py, bx, by, cx, cy);
            double polePCA = PoleTrojkata(px, py, cx, cy, ax, ay);

            if (Math.Abs(poleABC - (polePAB + polePBC + polePCA)) < 1e-9) // Używamy małej tolerancji dla porównań double
            {
                // Sprawdzenie, czy punkt leży na boku (pole jednego z trójkątów PAB, PBC, PCA jest bliskie zeru)
                if (Math.Abs(polePAB) < 1e-9 || Math.Abs(polePBC) < 1e-9 || Math.Abs(polePCA) < 1e-9)
                {
                    Console.WriteLine("Punkt P leży na boku trójkąta ABC.");
                }
                else
                {
                    Console.WriteLine("Punkt P leży wewnątrz trójkąta ABC.");
                }
            }
            else
            {
                Console.WriteLine("Punkt P leży na zewnątrz trójkąta ABC.");
            }

            Console.ReadKey();
        }
    }

}