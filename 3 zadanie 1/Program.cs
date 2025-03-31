using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            for (i = 11; i <= 33; i++)
                Console.Write("{0}, ", i);
            Console.ReadKey(true); //pauza
        }
    }
}