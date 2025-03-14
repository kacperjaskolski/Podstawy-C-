using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Wczytaj z klawiatury rok_początkowy i rok_końcowy oraz wypisz na ekranie wszystkie lata
//przestępne od roku_początkowego do roku_końcowego włącznie. Użyj pętli for.

namespace zad_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rok_poczotkowy, rok_koncowy, i ;
            Console.Write("podaj rok poczatkowy");
            rok_poczotkowy = Convert.ToInt32(Console.ReadLine());
            Console.Write("podaj rok koncowy");
            rok_koncowy = Convert.ToInt32(Console.ReadLine());
            for (i = rok_poczotkowy; i <= rok_koncowy; i++)
                if (((i % 4 == 0) && (i % 100 == 0)) || (i % 400 == 0))
                    Console.Write("{0} ", i);
            Console.ReadKey(true);


        }
    }
}
