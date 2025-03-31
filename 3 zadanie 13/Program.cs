using System;

namespace Zadanie13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę naturalną n (n > 4): ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n > 4)
            {
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        if (i == 1 || i == n || j == 1 || j == i)
                        {
                            Console.Write("X");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Podana wartość n jest nieprawidłowa.");
            }

            Console.ReadKey();
        }
    }
}