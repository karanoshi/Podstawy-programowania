using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int wybor;
            double a, b;
            do
            {
                Console.WriteLine("MENU:");
                Console.WriteLine("1 - oblicz pole prostokąta");
                Console.WriteLine("2 - oblicz pole kwadratu");
                Console.WriteLine("3 - oblicz pole trojkąta");
                Console.WriteLine("0 - koniec");
                Console.Write("Twój wybór: ");
                wybor = Convert.ToInt32(Console.ReadLine());
                switch (wybor)
                {
                    case 0:
                        break;
                    case 1:
                        Console.Write("Podaj długość boku a= ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Podaj długość boku b=");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Pole prostokąta wynosi ={0}", a * b);
                        break;
                    case 2:
                        Console.Write("Podaj długość boku a=");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Pole kwadratu wynosi ={0}", a * a);
                        break;
                    case 3:
                        Console.Write("Podaj długość podstawy a=");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Podaj długość wysokości h=");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Pole trójkąta wynosi ={0}", a * b / 2.0);
                        break;
                    default:
                        Console.WriteLine("Błąd: Nienany wybór");
                        break;
                }
            } while (wybor != 0);
            Console.ReadKey();
        }
    }
}