using System;

namespace Zadanie_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, h, l, V, PC;
            Console.Write("Podaj r=");
            r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj h=");
            h = Convert.ToDouble(Console.ReadLine());
            l = Math.Sqrt(r * r + h * h); //tworząca
            V = 1.0 / 3 * Math.PI * r * r * h;
            PC = Math.PI * r * r + Math.PI * r * l;
            Console.WriteLine("V={0}", V);
            Console.WriteLine("PC={0}", PC);
            Console.ReadKey(true); //pauza
        }
    }
}