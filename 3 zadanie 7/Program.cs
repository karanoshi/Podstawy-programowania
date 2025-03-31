using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 13; i <= 100; i += 13)
                Console.Write("{0}, ", i);

            Console.ReadKey(true); //pauza
        }
    }
}