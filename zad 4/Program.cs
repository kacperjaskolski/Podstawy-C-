using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Napisz funkcję o nazwie ile_cyfr, która wyznacza liczbę cyfr dla zadanej liczby naturalnej jako
//argument tej funkcji. Napisz program wykorzystujący funkcję ile_cyfr
namespace zad_4
{
    class Program
    {
        static int ile_cyfr(int liczba)
        {
            if (liczba == 0) return 1; // Obsługuje przypadek dla liczby 0

            int i = 0;
            while (liczba / 10 > 0)
            {
                liczba /= 10;
                i++;
            }
            return i + 1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Liczba 0 ma {0} cyfr.", ile_cyfr(0));
            Console.WriteLine("Liczba 1234 ma {0} cyfr.", ile_cyfr(1234));
            Console.ReadKey(true);
        }
    }
}