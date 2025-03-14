using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Wczytaj dwie liczby naturalne dodatnie n i k. Narysuj z gwiazdek na ekranie prostokąt
//posiadający n wierszy i k kolumn. Użyj pętli for
namespace ZAD_4_petle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, k, j, i;
            Console.WriteLine("podaj liczbę dodatnia n:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("podaj liczbę dodatnia k:");
            k = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= k; j++)
                    Console.Write("*");
                Console.WriteLine("");
            }
            Console.ReadKey(true);

        }
    }
}
