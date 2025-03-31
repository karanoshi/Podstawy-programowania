using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, suma = 0;
            Console.Write("Podaj n=");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
                suma += i; //suma=suma+i;

            Console.WriteLine("1+...+{0}={1}", n, suma);
            Console.ReadKey(true); //pauza
        }
    }
}