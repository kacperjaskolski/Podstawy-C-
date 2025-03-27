using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Wczytaj z klawiatury dwie liczby naturalne a i b (0<a<b). Wyznacz wszystkie liczby parzyste z
//przedziału[a, b].Użyj pętli while.
namespace _04_petle_while_do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, i;
            Console.WriteLine("podaj liczbę naturalną a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("podaj liczbę naturalną b:");
            b = Convert.ToInt32(Console.ReadLine());
            i = a;
            while (i <= b)
            {
                if (i % 2 == 0)
                    Console.WriteLine("{0}, ", i);
                i++;
            }
            Console.ReadKey(true);

        }
    }
}
