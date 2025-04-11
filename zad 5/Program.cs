using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Napisz funkcję, która sprawdza czy jej argument jest liczbą pierwszą. Jako wartość funkcja
//powinna zwracać 1 dla liczb pierwszych i 0 dla pozostałych liczb. Przetestuj działanie
//utworzonej funkcji.

namespace zad_5
{
    class Program
    {
        static int czy_pierwsza(int liczba)
        {
            if (liczba < 2) return 0; // Liczby mniejsze niż 2 nie są pierwsze

            for (int i = 2; i <= Math.Sqrt(liczba); i++) // Sprawdzamy do pierwiastka z liczby
            {
                if (liczba % i == 0)
                    return 0; // Liczba nie jest pierwsza
            }

            return 1; // Liczba jest pierwsza
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Czy liczba 12 jest liczbą pierwszą? {0}", czy_pierwsza(12));
            Console.WriteLine("Czy liczba 13 jest liczbą pierwszą? {0}", czy_pierwsza(13));
            Console.WriteLine("Czy liczba 1 jest liczbą pierwszą? {0}", czy_pierwsza(1)); // Test dla liczby 1

            Console.ReadKey(true);
        }
    }