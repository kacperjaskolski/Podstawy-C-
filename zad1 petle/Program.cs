using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1. Napisać program wypisujący na ekranie kolejne liczby całkowite od 11 do 33. Użyj pętli for.
namespace zad1_petle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            for (a = 11; a <= 33; a++)
                Console.Write("{0} ", a);
            Console.ReadKey(true);



        }
    }
}
