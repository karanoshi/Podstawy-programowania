using System;
using System.Collections.Generic; // Używamy List<T> dla dynamicznej tablicy

namespace Zadanie4
{
    // Definicja struktury Samochod
    struct Samochod
    {
        public string marka;
        public string typ;
        public int rok_produkcji;
        public int przebieg;
        public string kolor;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Używamy List<Samochod> zamiast stałej tablicy, aby łatwiej zarządzać ilością samochodów
            List<Samochod> samochody = new List<Samochod>();

            int wybor;
            int numerSamochodu;

            do
            {
                Console.WriteLine("\n--- MENU ZARZĄDZANIA SAMOCHODAMI ---");
                Console.WriteLine("1 - Dodaj nowy samochód");
                Console.WriteLine("2 - Usuń samochód");
                Console.WriteLine("3 - Modyfikuj dane samochodu");
                Console.WriteLine("4 - Wyświetl informacje o wybranym samochodzie");
                Console.WriteLine("5 - Wyświetl listę wszystkich samochodów");
                Console.WriteLine("0 - Zakończ program");
                Console.Write("Twój wybór: ");

                if (int.TryParse(Console.ReadLine(), out wybor))
                {
                    switch (wybor)
                    {
                        case 1: // Dodaj nowy samochód
                            Samochod nowySamochod = new Samochod();

                            Console.Write("Podaj markę: ");
                            nowySamochod.marka = Console.ReadLine();

                            Console.Write("Podaj typ: ");
                            nowySamochod.typ = Console.ReadLine();

                            Console.Write("Podaj rok produkcji: ");
                            nowySamochod.rok_produkcji = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Podaj przebieg: ");
                            nowySamochod.przebieg = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Podaj kolor: ");
                            nowySamochod.kolor = Console.ReadLine();

                            samochody.Add(nowySamochod);
                            Console.WriteLine("Samochód został dodany.");
                            break;

                        case 2: // Usuń samochód
                            Console.Write("Podaj numer samochodu do usunięcia: ");
                            if (int.TryParse(Console.ReadLine(), out numerSamochodu) && numerSamochodu > 0 && numerSamochodu <= samochody.Count)
                            {
                                samochody.RemoveAt(numerSamochodu - 1);
                                Console.WriteLine($"Samochód numer {numerSamochodu} został usunięty.");
                            }
                            else
                            {
                                Console.WriteLine("Nieprawidłowy numer samochodu.");
                            }
                            break;

                        case 3: // Modyfikuj dane samochodu
                            Console.Write("Podaj numer samochodu do modyfikacji: ");
                            if (int.TryParse(Console.ReadLine(), out numerSamochodu) && numerSamochodu > 0 && numerSamochodu <= samochody.Count)
                            {
                                // Struktury są typami wartościowymi, musimy pracować na kopii, a potem przypisać z powrotem
                                Samochod samochodDoModyfikacji = samochody[numerSamochodu - 1];

                                Console.WriteLine($"Modyfikujesz samochód: {samochodDoModyfikacji.marka} {samochodDoModyfikacji.typ}");

                                Console.Write("Podaj nową markę (lub wciśnij Enter aby pominąć): ");
                                string nowaMarka = Console.ReadLine();
                                if (!string.IsNullOrWhiteSpace(nowaMarka)) samochodDoModyfikacji.marka = nowaMarka;

                                Console.Write("Podaj nowy typ (lub wciśnij Enter aby pominąć): ");
                                string nowyTyp = Console.ReadLine();
                                if (!string.IsNullOrWhiteSpace(nowyTyp)) samochodDoModyfikacji.typ = nowyTyp;

                                Console.Write("Podaj nowy rok produkcji (lub 0 aby pominąć): ");
                                if (int.TryParse(Console.ReadLine(), out int nowyRok) && nowyRok != 0) samochodDoModyfikacji.rok_produkcji = nowyRok;

                                Console.Write("Podaj nowy przebieg (lub -1 aby pominąć): ");
                                if (int.TryParse(Console.ReadLine(), out int nowyPrzebieg) && nowyPrzebieg >= 0) samochodDoModyfikacji.przebieg = nowyPrzebieg;

                                Console.Write("Podaj nowy kolor (lub wciśnij Enter aby pominąć): ");
                                string nowyKolor = Console.ReadLine();
                                if (!string.IsNullOrWhiteSpace(nowyKolor)) samochodDoModyfikacji.kolor = nowyKolor;

                                samochody[numerSamochodu - 1] = samochodDoModyfikacji; // Przypisanie zmodyfikowanej kopii
                                Console.WriteLine("Dane samochodu zostały zmodyfikowane.");
                            }
                            else
                            {
                                Console.WriteLine("Nieprawidłowy numer samochodu.");
                            }
                            break;

                        case 4: // Wyświetl informacje o wybranym samochodzie
                            Console.Write("Podaj numer samochodu do wyświetlenia: ");
                            if (int.TryParse(Console.ReadLine(), out numerSamochodu) && numerSamochodu > 0 && numerSamochodu <= samochody.Count)
                            {
                                Samochod s = samochody[numerSamochodu - 1];
                                Console.WriteLine($"\nInformacje o samochodzie numer {numerSamochodu}:");
                                Console.WriteLine($"Marka: {s.marka}");
                                Console.WriteLine($"Typ: {s.typ}");
                                Console.WriteLine($"Rok produkcji: {s.rok_produkcji}");
                                Console.WriteLine($"Przebieg: {s.przebieg} km");
                                Console.WriteLine($"Kolor: {s.kolor}");
                            }
                            else
                            {
                                Console.WriteLine("Nieprawidłowy numer samochodu.");
                            }
                            break;

                        case 5: // Wyświetl listę wszystkich samochodów
                            Console.WriteLine("\n--- LISTA SAMOCHODÓW ---");
                            if (samochody.Count == 0)
                            {
                                Console.WriteLine("Brak samochodów w bazie.");
                            }
                            else
                            {
                                for (int i = 0; i < samochody.Count; i++)
                                {
                                    Samochod s = samochody[i];
                                    Console.WriteLine($"{i + 1}. {s.marka} {s.typ} ({s.rok_produkcji}), {s.kolor}, {s.przebieg} km");
                                }
                            }
                            break;

                        case 0: // Zakończ program
                            Console.WriteLine("Zamykanie programu...");
                            break;

                        default:
                            Console.WriteLine("Nieznany wybór. Spróbuj ponownie.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Nieprawidłowe dane wejściowe.");
                }

            } while (wybor != 0);

            Console.ReadKey(); // Pauza przed zamknięciem konsoli
        }
    }
}