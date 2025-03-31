using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;

            for (i = 1; i <= 10; i++) //wiersze
            {
                for (j = 1; j <= 10; j++) //kolumny
                    Console.Write("{0,3} ", i * j); //wiersz*kolumna
                Console.WriteLine("");
            }
            Console.ReadKey(true); //pauza
        }
    }
}