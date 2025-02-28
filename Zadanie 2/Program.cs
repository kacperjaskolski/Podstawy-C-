using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Napisać program wczytujący liczbę całkowitą i wypisujący informację, czy wczytana liczba jest
//dodatnia, ujemna, czy też równa zero
namespace Zadanie_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("podaj liczbę całkowitą: ");
            a=Convert.ToInt32( Console.ReadLine() );
            if (a > 0)
                Console.WriteLine("liczba jest dodatnia:{0}", a);
            else if (a < 0)
                Console.WriteLine("liczba jest ujemna:{0}", a);
            else if (a == 0)
                Console.WriteLine("liczba jest równa zero:{0}", a);
            Console.ReadKey(true);
        }
    }
}
