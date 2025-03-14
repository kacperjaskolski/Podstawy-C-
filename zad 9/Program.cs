using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Wypisz tabliczkę mnożenia do 100 w formie tabelki:
namespace zad_9
{
    internal class Program
    {
        static void Main(string[] args)
        { int a, b;
            for (a = 1; a <= 10; a++)
            {
                for (b = 1; b <= 10; b++)
                    Console.Write("{0,5}", a * b);
                Console.WriteLine(" ");
            }
            Console.ReadKey(true);
        }
    }
}
