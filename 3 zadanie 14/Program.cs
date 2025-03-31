using System;

namespace Zadanie14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj dolną granicę przedziału:");
            int dolnaGranica = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj górną granicę przedziału:");
            int gornaGranica = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Trójki pitagorejskie w przedziale [{dolnaGranica}, {gornaGranica}]:");

            for (int a = dolnaGranica; a <= gornaGranica; a++)
            {
                for (int b = a; b <= gornaGranica; b++)
                {
                    for (int c = b; c <= gornaGranica; c++)
                    {
                        if (a * a + b * b == c * c)
                        {
                            Console.WriteLine($"{a}, {b}, {c}");
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}