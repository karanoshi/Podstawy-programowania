using System;

namespace Zadanie_3

{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Podaj a=");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a^3={0}", a * a * a);
            Console.ReadKey(true); //pauza
        }
    }
}