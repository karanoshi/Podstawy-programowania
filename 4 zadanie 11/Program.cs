using System;

namespace Zadanie11
{
    class Program
    {
        static void Main(string[] args)
        {
            int wybor;
            double promien, wysokosc, a, b, c;
            const double PI = Math.PI;

            do
            {
                Console.WriteLine("\nMENU - Obliczanie objętości:");
                Console.WriteLine("1 - Kula");
                Console.WriteLine("2 - Stożek");
                Console.WriteLine("3 - Walec");
                Console.WriteLine("4 - Prostopadłościan");
                Console.WriteLine("5 - Sześcian");
                Console.WriteLine("0 - Koniec");
                Console.Write("Twój wybór: ");
                wybor = Convert.ToInt32(Console.ReadLine());

                switch (wybor)
                {
                    case 0:
                        Console.WriteLine("Koniec programu.");
                        break;
                    case 1: // Kula
                        Console.Write("Podaj promień kuli: ");
                        promien = Convert.ToDouble(Console.ReadLine());
                        double objKuli = (4.0 / 3.0) * PI * Math.Pow(promien, 3);
                        Console.WriteLine($"Objętość kuli wynosi: {objKuli:F2}");
                        break;
                    case 2: // Stożek
                        Console.Write("Podaj promień podstawy stożka: ");
                        promien = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Podaj wysokość stożka: ");
                        wysokosc = Convert.ToDouble(Console.ReadLine());
                        double objStozka = (1.0 / 3.0) * PI * Math.Pow(promien, 2) * wysokosc;
                        Console.WriteLine($"Objętość stożka wynosi: {objStozka:F2}");
                        break;
                    case 3: // Walec
                        Console.Write("Podaj promień podstawy walca: ");
                        promien = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Podaj wysokość walca: ");
                        wysokosc = Convert.ToDouble(Console.ReadLine());
                        double objWalca = PI * Math.Pow(promien, 2) * wysokosc;
                        Console.WriteLine($"Objętość walca wynosi: {objWalca:F2}");
                        break;
                    case 4: // Prostopadłościan
                        Console.Write("Podaj długość boku a: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Podaj długość boku b: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Podaj długość boku c: ");
                        c = Convert.ToDouble(Console.ReadLine());
                        double objProstopadloscianu = a * b * c;
                        Console.WriteLine($"Objętość prostopadłościanu wynosi: {objProstopadloscianu:F2}");
                        break;
                    case 5: // Sześcian
                        Console.Write("Podaj długość boku sześcianu: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        double objSzescianu = Math.Pow(a, 3);
                        Console.WriteLine($"Objętość sześcianu wynosi: {objSzescianu:F2}");
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                        break;
                }
            } while (wybor != 0);

            Console.ReadKey();
        }
    }
}