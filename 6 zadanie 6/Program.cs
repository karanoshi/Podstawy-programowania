using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dni = new string[] {"poniedziałek",
                "wtorek", "środa", "czwartek", "piątek",
                "sobota", "niedziela"};

            //wypisujemy elementy tablicy
            foreach (string elem in dni)
            {
                Console.Write("{0}, ", elem);
            }

            Console.ReadKey(true); //pauza
        }
    }
}