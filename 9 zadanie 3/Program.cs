using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 10; //maksymalna ilość elementów tablicy
            string[] owoce = new string[N];
            int ile = 0; //ilość elementów jest tablicy

            int w, nr, i; //wybor; numer elementu tablicy; licznik pętli

            do
            {
                Console.WriteLine("\nMENU: \n1-dodaj\n2-modyfikuj\n3-usuń");
                Console.Write("4-wypisz\n0-koniec\nTwój wybór: ");
                w = Convert.ToInt32(Console.ReadLine());

                switch (w)
                {
                    case 0: break;

                    case 1: //dodaj owoc
                        if (ile < N)
                        {
                            Console.Write("Podaj nazwę owocu: ");
                            owoce[ile++] = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Tablica pełna, nie można dodać więcej owoców.");
                        }
                        break;

                    case 2: //modyfikuj nazwę owocu
                        Console.Write("Podaj numer owocu do modyfikacji: ");
                        nr = Convert.ToInt32(Console.ReadLine());

                        if ((nr <= ile) && (nr > 0))
                        {
                            Console.WriteLine("Obecna nazwa owocu: {0}", owoce[nr - 1]);
                            Console.Write("Podaj nową nazwę owocu: ");
                            owoce[nr - 1] = Console.ReadLine();
                        }
                        else Console.WriteLine("Błędny numer!!!");
                        break;

                    case 3: //usuń owoc
                        if (ile == 0)
                        {
                            Console.WriteLine("Brak elementów !!!");
                        }
                        else
                        {
                            Console.Write("Podaj numer owocu do usunięcia: ");
                            nr = Convert.ToInt32(Console.ReadLine());

                            if ((nr <= ile) && (nr > 0))
                            {
                                Console.WriteLine("Usunięty owoc: {0}", owoce[nr - 1]);

                                if (ile == 1)
                                {
                                    ile = 0;
                                }
                                else
                                {
                                    for (i = nr - 1; i < ile - 1; i++) owoce[i] = owoce[i + 1];
                                    ile--;
                                }
                            }
                            else Console.WriteLine("Błędny numer !!!");
                        }
                        break;

                    case 4: //wypisz wszystkie owoce
                        Console.WriteLine("Wpisane owoce:");
                        if (ile == 0)
                        {
                            Console.WriteLine("Brak owoców na liście.");
                        }
                        else
                        {
                            for (i = 0; i < ile; i++)
                                Console.WriteLine("{0}. {1}", i + 1, owoce[i]);
                        }
                        break;

                    default: Console.WriteLine("Nieznany wybor !!!"); break;
                }

            } while (w != 0);

            Console.ReadKey(true); //pauza
        }
    }
}